// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.DurabilityItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Localization;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary> Items that can get broken or spoiled, that can be discrete or continious in progression, See DurabilityItems.md for more informations. </summary>
public abstract class DurabilityItem : Item, INotifyPropertyChanged
{
  public virtual float OriginalMaxDurability { get; }

  [SyncToView(null, true)]
  public virtual bool Decays { get; }

  [SyncToView(null, true)]
  public virtual float DurabilityPercent { get; }

  public virtual float PercentBrokenFromOriginal { get; }

  public string DisplayDurability { get; }

  public abstract float GetDurability();

  public abstract void SetDurability(float d);

  [SyncToView(null, true)]
  public virtual bool CanBeUsedInCraftWithoutFullDurability { get; }

  [SyncToView(null, true)]
  [Notify]
  public bool Broken { get; protected set; }

  public virtual int GetQualityGroup();

  public override bool IsStackable { get; }

  public override int StackingHash { get; }

  public override bool CanStack(Item? other);

  public override bool RepresentsItem(Item other);

  public override int RepresentativeHash();

  public override Item Clone();

  /// <summary>Splits durability items by cloning — each half keeps the same durability.</summary>
  public override (Item Moved, Item Remaining) SplitItem(int movedCount, int remainingCount);

  /// <summary>Update Durability value before merging items to apply correct durability value.</summary>
  public override Item Merge(Item? mergingInto, int thisCount, int otherCount);

  public virtual LocString BrokenDescription { get; }

  public virtual float DefaultMinRequiredDurabilityInTradeOffers { get; }

  public event PropertyChangedEventHandler? PropertyChanged;
}
