// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryRelated.VoidStorageManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items.InventoryRelated;

[Serialized]
public class VoidStorageManager : IController, IViewController, IHasUniversalID
{
  [Serialized]
  public ControllerList<VoidStorageWrapper> VoidStorages;

  [SyncToView(null, true)]
  public IEnumerable<VoidStorageWrapper> AccessibleVoidStorages(Player player);

  /// <summary>Makes and lock a new void storage with a given inventory.</summary>
  /// <param name="items">Items to fill with the new void storage with.</param>
  /// <param name="name">Name of the new void storage.</param>
  /// <param name="user">User the void storage belongs to.</param>
  /// <param name="position">Position of the new void storage.</param>
  /// <param name="icon">Icon to give the new void storage.</param>
  /// <param name="maxXZDistance"></param>
  /// <param name="maxYDistance"></param>
  public void FillNewVoidStorage(
    IEnumerable<Type> items,
    LocString name,
    User user,
    Vector3i position,
    string icon = "slgicon",
    float maxXZDistance = 10f,
    float maxYDistance = 5f);

  /// <param name="stacks">Item stacks to fill the new void storage with.</param>
  /// <inheritdoc cref="M:Eco.Gameplay.Items.InventoryRelated.VoidStorageManager.FillNewVoidStorage(System.Collections.Generic.IEnumerable{System.Type},Eco.Shared.Localization.LocString,Eco.Gameplay.Players.User,Eco.Shared.Math.Vector3i,System.String,System.Single,System.Single)" />
  public void FillNewVoidStorage(
    IEnumerable<ItemStack> stacks,
    LocString name,
    User user,
    Vector3i position,
    string icon = "slgicon",
    float maxXZDistance = 10f,
    float maxYDistance = 5f);

  /// <summary>Removes all but the oldest of the user's void storages named with any translation of the given English name.
  /// Cleans up duplicates granted when claim records baked in one language failed to match after a language switch.</summary>
  public void RemoveDuplicateStorages(User user, string englishName);

  /// <summary>Makes a new void storage. We can leave it locked (only mergeitem can be called) or unlocked (needs to be locked after initial add).</summary>
  /// <inheritdoc cref="M:Eco.Gameplay.Items.InventoryRelated.VoidStorageManager.FillNewVoidStorage(System.Collections.Generic.IEnumerable{System.Type},Eco.Shared.Localization.LocString,Eco.Gameplay.Players.User,Eco.Shared.Math.Vector3i,System.String,System.Single,System.Single)" />
  /// <param name="icon"></param>
  /// <returns>Wrapper for the requested void storage.</returns>
  public VoidStorageWrapper MakeNewVoidStorage(
    LocString name,
    User user,
    Vector3i position,
    float maxXZDistance = 10f,
    float maxYDistance = 5f,
    string icon = "slgicon");

  public ref int ControllerID { get; }
}
