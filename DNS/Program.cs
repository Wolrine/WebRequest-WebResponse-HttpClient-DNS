using System.Net;

Console.WriteLine(new String('*', 30));
string url = "www.contoso.com";
var domainEntry = Dns.GetHostEntry(url);
Console.WriteLine(domainEntry.HostName);
foreach (var ip in domainEntry.AddressList)
{
    Console.WriteLine(ip);
}
Console.WriteLine(new String('*', 30));
var domainEntryByAddress = Dns.GetHostEntry("127.0.0.1");
Console.WriteLine(domainEntryByAddress.HostName);
foreach (var ip in domainEntryByAddress.AddressList)
{
    Console.WriteLine(ip);
}
Console.ReadLine();