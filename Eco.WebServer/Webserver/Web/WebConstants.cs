// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.WebConstants
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

#nullable disable
namespace Eco.WebServer.Web;

/// <summary>Constants used throughout the Eco Web Server.</summary>
public static class WebConstants
{
  /// <summary>
  /// Default webpage file to load when a directory is requested.
  /// </summary>
  public const string DefaultWebpage = "index.html";
  /// <summary>The location of our web client files.</summary>
  public static readonly string WebRoot;
}
