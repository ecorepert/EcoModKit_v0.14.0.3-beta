// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemStack
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using JetBrains.Annotations;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class ItemStack : 
  IController,
  IViewController,
  IHasUniversalID,
  IStack,
  INotifyPropertyChanged,
  ICloneable
{
  public Inventory Parent { get; internal set; }

  [Serialized]
  [SyncToView(null, true)]
  [CanBeNull]
  [NewTooltipChildren(CacheAs.Instance)]
  public Item Item { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int Quantity { get; set; }

  public float FractionalQuantity { get; set; }

  public virtual string TypeString { get; }

  public float Weight { get; }

  public virtual ItemRepresentation StackObject { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  public ItemStack();

  public ItemStack(Type type, int quantity, Inventory parent = null);

  public ItemStack(Item item, int quantity, Inventory parent = null);

  /// <summary>Clear item and quantity (leave Inventory alone)</summary>
  public void Clear();

  /// <param name="notifyParentInventory">
  /// We set this to true when we want the parent inventory to be automatically notified about the stack change.
  /// We set it to false in the rare cases where we actually want to do that manually. (I.E when we want to replace many stacks in an inventory, it's better to do that and then notify the inventory in the end for better performance).
  /// </param>
  /// <param name="user">The user that's doing the replacement.</param>
  public void ReplaceStack(Item item, int quantity, bool notifyParentInventory, User user = null);

  /// <summary>Modifies item together with it's <see cref="P:Eco.Gameplay.Items.ItemStack.FractionalQuantity" />.</summary>
  /// <param name="user">The user that's doing the replacement.</param>
  public void ModifyFractional(Item item, float fractional, User user = null);

  public override string ToString();

  [RPC]
  public void Sync();

  public ItemStack Clone();

  public virtual int NumberToTake(Item item, int quantity);

  public bool CanFit(int more);

  public float FilledPercent();

  /// <summary> Deconstructs <see cref="T:Eco.Gameplay.Items.ItemStack" /> into <see cref="P:Eco.Gameplay.Items.ItemStack.Item" /> and <see cref="P:Eco.Gameplay.Items.ItemStack.Quantity" />. </summary>
  public void Deconstruct(out Item item, out int quantity);

  /// <summary>Clones the underlying item, if its unique.</summary>
  public ItemStack CloneStack();

  object ICloneable.Clone();
}
