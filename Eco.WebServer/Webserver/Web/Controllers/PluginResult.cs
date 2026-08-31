// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.PluginResult
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Core.Plugins;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

[TypeConverter(typeof (ExpandableObjectConverter))]
internal class PluginResult
{
  public object Config { get; set; }

  public Dictionary<string, IPluginConfigProperty> ConfigProperties { get; set; }
}
