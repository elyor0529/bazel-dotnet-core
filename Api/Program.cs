using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Friends {
  public class Program {
    public static void Main (string[] args) {
      CreateHostBuilder (args).Build ().Run ();
    }

    public static IHostBuilder CreateHostBuilder (string[] args) =>
      Host.CreateDefaultBuilder (args)
      .UseContentRoot (".")
      .ConfigureWebHostDefaults (webBuilder => {
        webBuilder.UseStartup<Startup> ()
          .UseUrls ("http://localhost:6050", "http://localhost:7050");
      });
  }
}