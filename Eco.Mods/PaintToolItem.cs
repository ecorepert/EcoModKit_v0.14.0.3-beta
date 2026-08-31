// Decompiled with JetBrains decompiler
// Type: PaintToolItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;

#nullable enable
/// <summary>Base class for item that can paint things.</summary>
[Serialized]
[System.ComponentModel.Category("Hidden")]
[Tag("Painter")]
public class PaintToolItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public bool CanHoldToPaint { get; }

  [RPC]
  public virtual bool PaintBlock(
  #nullable disable
  Player player, InteractionTarget target, byte coat);

  [RPC]
  public virtual bool PaintWorldObject(
    Player player,
    InteractionTarget target,
    WorldObject worldObj,
    int channel,
    byte coat);

  [RPC]
  public virtual bool ClearPaintWorldObject(
    Player player,
    InteractionTarget target,
    WorldObject worldObj,
    int channel);

  [RPC]
  public virtual bool ClearPaint(Player player, InteractionTarget target);
}
