
using System.Runtime.InteropServices;

Console.WriteLine("Good afternoon OWASP BeNeLux 2023!");
Console.WriteLine($"Running on: {RuntimeInformation.OSArchitecture}!");

var content = System.IO.File.ReadAllText("/etc/hosts");
Console.WriteLine(content);