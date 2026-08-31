// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Utils.ServiceCollectionExtensions
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.Extensions.DependencyInjection;

#nullable enable
namespace Eco.WebServer.Web.Utils;

/// <summary>
/// Extension methods for <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
/// </summary>
public static class ServiceCollectionExtensions
{
  /// <summary>
  /// Configures restful api versioning and documentation generation
  /// </summary>
  public static void ConfigureApiVersioning(this 
  #nullable disable
  IServiceCollection services);

  /// <summary>
  /// Registers all our currently loaded Eco Asp.Net MVC mod controllers.
  /// </summary>
  public static void AddEcoMvcMods(this IServiceCollection services);

  /// <summary>
  /// Adds Eco server authentication services to the service colllection
  /// </summary>
  public static void AddEcoAuthentication(this IServiceCollection services);
}
