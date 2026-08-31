// Decompiled with JetBrains decompiler
// Type: DevPaintToolItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable disable
[Serialized]
[LocDisplayName("Dev Paint Tool")]
[LocDescription("Paint tool! It paints with some developer features.")]
[System.ComponentModel.Category("Hidden")]
public class DevPaintToolItem : PaintToolItem
{
  public override bool PaintBlock(Player player, InteractionTarget target, byte coat);

  public override bool PaintWorldObject(
    Player player,
    InteractionTarget target,
    WorldObject worldObj,
    int channel,
    byte coat);

  public override bool ClearPaintWorldObject(
    Player player,
    InteractionTarget target,
    WorldObject worldObj,
    int channel);

  public override bool ClearPaint(Player player, InteractionTarget target);
}
