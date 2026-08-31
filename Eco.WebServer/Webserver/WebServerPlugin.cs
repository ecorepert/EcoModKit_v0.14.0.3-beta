// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.WebServerPlugin
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.WebServer;

[LocDisplayName("WebServerPlugin")]
[Priority(200)]
public class WebServerPlugin : IServerPlugin, IInitializablePlugin
{
  public static void PreInit();

  public void Initialize(TimedTask task);

  public string GetStatus();

  public string GetCategory();

  public override string ToString();
}
