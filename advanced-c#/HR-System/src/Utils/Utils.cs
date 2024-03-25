using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace advanced_c_.src.Utils
{
    public static class Utils
    {
        public static void GetIPAddress()
        {
            Console.WriteLine("GET IP ADDRESS => ");

            string hostName = Dns.GetHostName();

            IPAddress[] iPAddresses = Dns.GetHostAddresses(hostName);

            Console.WriteLine($"IP Addresses for host {hostName}");

            foreach (IPAddress iPAddress in iPAddresses)
            {
                Console.WriteLine("IP Address => " + iPAddress);
            }
        }

        public static void GetDeviceInfo()
        {
            Console.WriteLine("GET DEVICE INFO => ");
            OperatingSystem os = Environment.OSVersion;
            Version version = os.Version;

            Console.WriteLine($"Operation System version : {version}");
        }

        public static void CreateAndExecuteBashFile()
        {
            Console.WriteLine("Create and Execute Bash File => ");
            string bashScriptPath = "script.sh";
            string bashScriptContent = "#!/bin/bash\n" +
                                  "echo 'Hello, from the bash script!'";

            File.WriteAllText(bashScriptPath, bashScriptContent);

            ProcessStartInfo startInfo = new()
            {
                FileName = "/bin/bash",
                Arguments = $"-c \"chmod +x {bashScriptPath} && ./{bashScriptPath}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo)!)
            {
                string? output = process?.StandardOutput.ReadToEnd();

                if (output == null)
                {
                    Console.WriteLine("No output");
                }
                Console.WriteLine(output);
            }

            // File.Delete(bashScriptPath);
        }

        public static void CreateAndReadJsonFile()
        {
            // Define the object to serialize to JSON
            var data = new
            {
                Name = "John Doe",
                Age = 30,
                IsActive = true
            };

            // Serialize the object to JSON
            string jsonString = JsonSerializer.Serialize(data);

            // Define the path for the JSON file
            string jsonFilePath = "data.json";

            // Write the JSON string to the file
            File.WriteAllText(jsonFilePath, jsonString);

            Console.WriteLine("JSON file created successfully.");

            // Read the JSON file back into a string
            string jsonFromFile = File.ReadAllText(jsonFilePath);
            Console.WriteLine("jsonFromFile " + jsonFromFile);
        }

        public static void ByteSample()
        {
            byte myByte = 100;
            Console.WriteLine(myByte);

            myByte++;
            Console.WriteLine(myByte);

            myByte = byte.MaxValue;
            myByte++;
            Console.WriteLine(myByte);
        }

        public static void ReadFromFileWriteToAnotherUsingBuffer()
        {
            string sourceFilePath = "source.txt";
            string targetFilePath = "target.txt";
            int bufferSize = 1024;

            using (FileStream sourceStream = new(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                using FileStream targetStream = new(targetFilePath, FileMode.Create, FileAccess.Write);
                byte[] buffer = new byte[bufferSize];
                int bytesRead;

                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Console.WriteLine("reading...." + bytesRead);
                    targetStream.Write(buffer, 0, bytesRead);
                }
            }
            Console.WriteLine("File copies successfully");
        }
    }
}