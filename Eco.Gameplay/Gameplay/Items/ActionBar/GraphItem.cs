// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Actionbar.GraphItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items.Actionbar;

[Serialized]
[LocDisplayName("Graphs")]
[Priority(4)]
[System.ComponentModel.Category("Hidden")]
[LocDescription("Opens the world graphs.")]
public class GraphItem : ActionbarItem
{
  public override void OnLeftClicked(Player player, ItemStack stack);
}
