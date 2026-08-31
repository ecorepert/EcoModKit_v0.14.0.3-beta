// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ClothingInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Gameplay;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class ClothingInventory : Inventory
{
  public static ThreadSafeAction<User, ClothingInventory> ClothingChangedEvent;

  protected override IEnumerable<Inventory> SubInventories { get; }

  /// <summary> Swap not hidden clothing between two inventories (empty slots are swapping too) </summary>
  public void SwapInventories(Player player, ClothingInventory anotherInv);

  protected override void Initialize();

  [RPC]
  public void TryEquipItem(Player player, ItemStack itemToEquip);

  [RPC]
  public void SaveChanges(string slot, int itemTypeId, Dictionary<string, Color> colors);

  /// <summary> Load clothing from customization data. </summary>
  /// <remarks> At the moment, this should happen only on first login, to load from default avatar data. </remarks>
  public void LoadFromCustomizationData(User user, AvatarCustomizationData data);

  [Serialized]
  private class ClothingSlotData : 
    IController,
    IViewController,
    IHasUniversalID,
    INotifyPropertyChanged
  {
    ref int IHasUniversalID.ControllerID { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    [Serialized]
    [SyncToView(null, true)]
    public LimitedInventory Inventory { get; set; }

    [Serialized]
    [ThreadSafe]
    [SyncToView(null, true)]
    public Dictionary<string, Color> Colors { get; set; }
  }
}
