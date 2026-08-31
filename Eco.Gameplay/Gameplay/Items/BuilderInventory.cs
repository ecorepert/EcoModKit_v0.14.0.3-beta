// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BuilderInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Blocks;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class BuilderInventory : SelectionInventory
{
  public override bool NeedsAuth { get; }

  [Notify]
  public BlockForm SelectedForm { get; }

  [Notify]
  public int SelectedFormRotation { get; internal set; }

  [RPC]
  public void SetSelectedFormServer(Player player, BlockForm form);

  [RPC]
  public void SetSelectedFormRotationServer(Player player, int rotation);

  protected BuilderInventory();

  public BuilderInventory(int numStacks);
}
