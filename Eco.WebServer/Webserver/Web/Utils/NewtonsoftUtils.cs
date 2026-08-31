// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Utils.NewtonsoftUtils
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Mvc;

#nullable disable
namespace Eco.WebServer.Web.Utils;

/// <summary>
/// Static methods and extensions for working with Newtonsoft Json
/// </summary>
public static class NewtonsoftUtils
{
  /// <summary>
  /// Configures a <see cref="T:Microsoft.AspNetCore.Mvc.MvcNewtonsoftJsonOptions" /> instance for serializing Eco types.
  /// </summary>
  public static void ConfigureEcoOptions(this MvcNewtonsoftJsonOptions options);
}
