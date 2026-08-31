// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PricedItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Items;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>One row in the bounty price table: an item type and its per-unit price.</summary>
[Serialized]
public sealed class PricedItem : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IRPCAuthChecks
{
  internal Func<IWorldObserver, bool> AuthCheck;

  public bool IsRPCAuthorized(IWorldObserver observer, AccessType requiredAccess, object[] args);

  [Eco.Shared.Networking.Eco(true)]
  [UITypeName("Selector")]
  [AllowEmpty]
  public GamePickerList<Item> ItemFilter { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Range(0.0f, 10000f)]
  [LocDescription("Per-item amount for this item, paid in whichever direction the container's Payment Direction is set to.")]
  public float Price { get; set; }

  /// <summary>The item Type selected in <see cref="P:Eco.Gameplay.Components.PricedItem.ItemFilter" />, or null if no entry was picked.</summary>
  public Type ItemType { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
