using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class App
    {
        private readonly IConfiguration _config;
        private readonly IUser _user;

        public App(IConfiguration config, IUser user)
        {
            _config = config;
            _user = user;
        }

        public void Run()
        {
            var logDirectory = _config.GetValue<string>("Runtime:LogOutputDirectory");
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logDirectory)
                .CreateLogger();


            _user.TruncateName("Jerry     ");


            logger.Information("Hello, from Serilog logging");
            Console.WriteLine($"Hello {_user.Name}");
        }
    }
}
