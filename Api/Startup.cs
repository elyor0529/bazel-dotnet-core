using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace Friends {
  public class Startup {
    public void ConfigureServices (IServiceCollection services) {
      services.AddControllers ();
      services.AddResponseCompression ();
    }

    public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
      app.UseResponseCompression ();

      if (env.IsDevelopment ()) {
        app.UseDeveloperExceptionPage ();
      }

      app.UseDefaultFiles ();

      app.UseRouting ();

      app.UseEndpoints (endpoints => {
        endpoints.MapControllers ();
      });
    }
  }
}