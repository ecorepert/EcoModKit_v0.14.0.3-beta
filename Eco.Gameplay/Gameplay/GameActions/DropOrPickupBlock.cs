// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.DropOrPickupBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Construction")]
[LocDescription("A block was dropped or picked up.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[ChangeParentConfigLoc("ItemUsed", "Block Placed or Picked Up", null, typeof (BlockItem), false)]
public class DropOrPickupBlock : ItemInteractAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the block dropped or picked up?")]
  public DroppedOrPickedUp DroppedOrPickedUp { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the block rubble or not when picked up?")]
  public RubbleBlockForm BlockForm { get; set; }

  public DropOrPickupBlock();

  public DropOrPickupBlock(DroppedOrPickedUp value);
}
