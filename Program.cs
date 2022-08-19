// See https://aka.ms/new-console-template for more information
using Renci.SshNet;

using SSHTest;

Console.WriteLine("Hello, World!");

var connectionInfo = new ConnectionInfo("192.168.39.128", "administrator", new PasswordAuthenticationMethod("administrator", "P@ssw0rd"));

Provider provider = new Provider();
provider.ConnectionInfo = connectionInfo;

//provider.InquireProcessor();
//provider.InquireMotherboard();
provider.InquireMemory();

