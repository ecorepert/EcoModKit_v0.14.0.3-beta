// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PickerObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Serialization;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Utils;

/// <summary> A picker that targets objects. Contract clauses use this to determine the target of their operation.</summary>
/// <remarks> e.g.: "Put 10 Advanced Upgrade 2 to SomeUsers's Storage Chest". This is what's used to select "SomeUser's Storage Chest". </remarks>
[Serialized]
public class PickerObject : Picker
{
  public 
  #nullable disable
  ConcurrentBag<Inventory> SubscribedContainers;

  [Serialized]
  public WorldObjectHandle ObjectChoice { get; set; }

  public override string Choice { get; }

  public WorldObject PickedObj { get; }

  [SyncToView(null, true)]
  public virtual string Contents { get; }

  public override Deed Deed { get; }

  public IEnumerable<ItemStack> ItemStacks { get; }

  public IEnumerable<ItemStack> ConsolidatedItemsInContainer { get; }

  protected IEnumerable<StorageComponent> Storages { get; }

  public override bool IsSet { get; }

  public PickerObject();

  public PickerObject(string cat, bool positionOnly, string desc);

  public override void SetLocation(Player player, PointOfInterest obj);

  public override void Initialize();

  public override Result ValidOwnership(string pickerName, User user);

  public Result CheckAnyCanContain(IEnumerable<ItemStack> stacks);

  public Result CheckAllCanContain(IEnumerable<ItemStack> stacks);

  public void ForceLocation(WorldObject obj);
}
