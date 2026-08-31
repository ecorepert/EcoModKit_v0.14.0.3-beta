// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Utils.JsonSerializerSettingsExtensions
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Newtonsoft.Json;

#nullable disable
namespace Eco.WebServer.Utils;

/// <summary>Static extension methods for the Newtonsoft <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> object.</summary>
public static class JsonSerializerSettingsExtensions
{
  /// <summary>Configures the serialization settings of a Newtonsoft instance.</summary>
  /// <param name="settings">Settings to configure</param>
  public static void ConfigureEcoJsonOptions(this JsonSerializerSettings settings);
}
