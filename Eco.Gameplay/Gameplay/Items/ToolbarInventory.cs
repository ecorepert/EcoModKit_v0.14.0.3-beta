// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ToolbarInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class ToolbarInventory : SelectionInventory
{
  public override bool NeedsAuth { get; }

  protected ToolbarInventory();

  public ToolbarInventory(int numStacks);

  public void RefreshSelectableStacks();

  public override void SelectIndex(Player player, int slot);
}
