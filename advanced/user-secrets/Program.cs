using System;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddUserSecrets()
            .Build();

        Console.WriteLine(config["message"]);
    }
}
