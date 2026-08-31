// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SpoilageItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>A durability item that can spoil, like food and flowers.</summary>
public abstract class SpoilageItem : DurabilityItem
{
  [Serialized]
  [SyncToView(null, true)]
  public ImmutableCountdown SpoilageTime { get; set; }

  public override float DefaultMinRequiredDurabilityInTradeOffers { get; }

  public override Item Clone();

  public abstract float BaseShelfLife { get; }

  public void SetSpoilageTimeBasedOnDurability(float durability);

  /// <summary> Sets the spoilage time based on durability or updates the durability with spoilage progress if the storage is still the same. </summary>
  public void UpdateSpoilageTime(float shelfLifeMultiplier = 1f);

  public override float GetDurability();

  public override void SetDurability(float d);

  /// <summary> Create a new immutable countdown based on the given durability value and the current storage modifier. </summary>
  public ImmutableCountdown GetSpoilageTimeBasedOnDurability(float durability, bool paused = false);
}
