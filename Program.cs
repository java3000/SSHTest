// See https://aka.ms/new-console-template for more information
using Renci.SshNet;
using SSHTest;
using SSHTest.Object;

public class Program
{
    public static void Main(String[] argc)
    {
        var connectionInfo = new ConnectionInfo("192.168.39.128", "administrator",
            new PasswordAuthenticationMethod("administrator", "P@ssw0rd"));
    
        Provider provider = new Provider();
        provider.ConnectionInfo = connectionInfo;
        provider.currentDevice = new Device("test", DateTime.Now, new ProviderType(), String.Empty, new CacheContainer());
    
    //provider.InquireProcessor();
    //provider.InquireMotherboard();
        provider.InquireMemory(provider.currentDevice);
    }
}
