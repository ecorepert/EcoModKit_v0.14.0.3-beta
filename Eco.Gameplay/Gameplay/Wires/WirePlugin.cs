// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Wires.WirePlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Wires;

public class WirePlugin : 
  Singleton<WirePlugin>,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab
{
  public void Add(WireOutput wire);

  public override string ToString();

  public string GetCategory();

  public string GetDisplayText();

  public string GetStatus();
}
