// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PicturePrinterComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>Worldobject component that allows selecting local images on the client and uploading them to server to be used as PictureItem. Is used on PicturePrinterObject and uses PicturePrinterUI on the client.</summary>
[Serialized]
[HasIcon(null)]
public class PicturePrinterComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IInventoryWorldObjectComponent,
  IPermanentDestroyHandler
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  public 
  #nullable disable
  LimitedInventory PictureSlot { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public LimitedInventory ConsumableSlot { get; set; }

  public override void Initialize();

  [RPC]
  public bool RemovePicture(Player player);

  /// <summary>Called from the button on client PicturePrinterUI.</summary>
  [RPC]
  public Task PrintPicture(Player player, byte[] data);

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Inventory targetInventory,
    bool force);

  Inventory IInventoryWorldObjectComponent.Inventory { get; }
}
