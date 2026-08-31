// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Utils.EcoPluginUtils
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Core.Plugins.Interfaces;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Web.Utils;

/// <summary>Static utility methods and extensions for working with Eco's plugin system</summary>
public static class EcoPluginUtils
{
  /// <summary>Returns an <see cref="T:System.Collections.Generic.IEnumerable`1" /> containing all our loaded web plugins.</summary>
  public static IEnumerable<IWebPlugin> GetEcoWebPlugins();

  /// <summary>Retrieves a <see cref="T:Eco.Core.Plugins.Interfaces.IServerPlugin" /> plugin instance by its name.</summary>
  /// <param name="name">Name of the plugin to retrieve</param>
  /// <returns>The discovered plugin if found, otherwise default.</returns>
  public static IServerPlugin GetPlugin(string name);

  /// <summary>Retrieves a <see cref="T:Eco.Core.Plugins.Interfaces.IConfigurablePlugin" /> plugin instance by its name.</summary>
  /// <inheritdoc cref="M:Eco.WebServer.Web.Utils.EcoPluginUtils.GetPlugin(System.String)" />
  public static IConfigurablePlugin GetConfigPlugin(string name);

  /// <summary>Retrieves a <see cref="T:Eco.Core.Plugins.Interfaces.IWebPlugin" /> plugin instance by its name.</summary>
  /// <inheritdoc cref="M:Eco.WebServer.Web.Utils.EcoPluginUtils.GetPlugin(System.String)" />
  public static IWebPlugin GetWebPlugin(string name);

  /// <summary>Configures the static content for all our loaded web plugins.</summary>
  public static void UseEcoWebPluginStaticContent(this IApplicationBuilder app);
}
