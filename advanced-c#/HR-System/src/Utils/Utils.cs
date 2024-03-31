using System.Diagnostics;
using System.Net;
using System.Text.Json;
using YamlDotNet.Serialization;

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
            Console.WriteLine("Byte Sample =>");
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

        public static bool IsNullOrEmpty(object obj)
        {
            return obj == null || string.IsNullOrWhiteSpace(obj.ToString());
        }

        public static Dictionary<string, object> ObjectToDictonary(object obj)
        {
            return obj.GetType()
                .GetProperties()
                .ToDictionary(prop => prop.Name, prop => prop.GetValue(obj)!);
        }

        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static void ReadYamlFile()
        {
            Console.WriteLine("Read YAML File ==>");

            string filePath = "example.yaml";
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"File not found: {filePath}");
                }

                string yamlContent = File.ReadAllText(filePath);

                var deserializer = new DeserializerBuilder()
                    .Build();

                Employee employee = deserializer.Deserialize<Employee>(yamlContent);

                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine($"Department: {employee.Department}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading YAML file: {ex.Message}");
                throw;
            }
        }
    }
}

public class Employee
{
    public required string Name { get; set; }
    public int Age { get; set; }
    public required string Department { get; set; }
}