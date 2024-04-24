using advanced_c_.src.Delegates;
using advanced_c_.src.Pointers;
using advanced_c_.src.SchoolHRAdministration;
using advanced_c_.src.Utils;

Console.WriteLine("WELCOME TO C# ADVANCED CONCEPTS.... 🚀");

// ---------------------------- School HR System 🚀 ----------------------------
SchoolHRSystem.SampleOne();

// ---------------------------- Async/Await 🚀 ----------------------------
// Console.WriteLine("------->> Async/Await Sample 🚀");

// Console.WriteLine("CPU Bound Operation => " + await CPUBoundOperation.CalculateResultAsync("This is string input"));

// Console.WriteLine("I/O Bound Operation => " + await IOBOundOperation.DownlaodDataAsync());
// await IOBOundOperation.MultipleTasks();

// await AwaitKeywordImpact.Main();

// ---------------------------- Delegates 🚀 ----------------------------
DelegateReferenceToStaticMethod.SampleOne();

// ---------------------------- Utils 🚀 ----------------------------
Utils.GetIPAddress();
Utils.GetDeviceInfo();
Utils.CreateAndExecuteBashFile();
Utils.CreateAndReadJsonFile();
Utils.ReadFromFileWriteToAnotherUsingBuffer();

Console.WriteLine("Cache Utils ==> ");
Console.WriteLine(CacheUtil.GetData("key1"));

Console.WriteLine("Random String ==>");
Console.WriteLine(Utils.RandomString(3));

var value = "Value1";
var enumValue = Utils.ParseEnum<MyEnum>(value);
Console.WriteLine("Parse Enum ==>" + enumValue);

EncryptionDecryption.UsageSample();

Utils.ReadYamlFile();

// ---------------------------- Pointers 🚀 ----------------------------
PointerSampleOne.Intro();
PointerSampleOne.IntroTwo();
PointerAndMethod.SampleMethod();