// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.StackMultiplierRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Scales each item's own stack size instead of flattening every item to one fixed cap, so a x2 storage doubles whatever it is given.</summary>
public class StackMultiplierRestriction : StackLimitRestriction
{
  /// <summary>How many times the item's regular stack size fits in a stack of this inventory.</summary>
  public float Multiplier { get; }

  public StackMultiplierRestriction(float multiplier);

  public override bool Enabled { get; }

  protected override int GetMaxItemsOverrider(Item item);
}
