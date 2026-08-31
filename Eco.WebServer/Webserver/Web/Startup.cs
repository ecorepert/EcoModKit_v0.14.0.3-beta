// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Startup
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

#nullable enable
namespace Eco.WebServer.Web;

public class Startup
{
  public void ConfigureServices(
  #nullable disable
  IServiceCollection services);

  /// <summary>
  /// Configures Web API contained in the class Startup, which is additionally specified as the type parameter in WebApplication.Start
  /// </summary>
  public void Configure(IApplicationBuilder app, IWebHostEnvironment env);
}
