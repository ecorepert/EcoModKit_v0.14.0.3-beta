// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ActionBar.TechTreeVizItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Items.Actionbar;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items.ActionBar;

[Serialized]
[LocDisplayName("Tech Tree Visualizer")]
[Priority(6)]
[System.ComponentModel.Category("Hidden")]
[LocDescription("Displays the tech tree visualizer and the research progress across the world.")]
public class TechTreeVizItem : ActionbarItem
{
  [SyncToView(null, true)]
  public override string UIName { get; }
}
