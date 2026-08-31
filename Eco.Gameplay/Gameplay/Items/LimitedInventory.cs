// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.LimitedInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class LimitedInventory : Inventory
{
  public override IEnumerable<ItemStack> Stacks { get; }

  protected LimitedInventory();

  public LimitedInventory(int numStacks);

  public LimitedInventory(ItemStack stack);

  protected override void Initialize();

  public void AddStacks(int numStacks);

  public void EnsureStacks(int numStacks);

  /// <summary>Returns true if shrinking to targetCount is possible — i.e. enough empty slots in the surviving zone to relocate items from the doomed zone.
  /// <paramref name="reservedInSurviving" /> reduces available empty slots to account for items that will land in the surviving zone (e.g. clothing being unequipped into backpack).</summary>
  public bool CanShrinkTo(int targetCount, int reservedInSurviving = 0);

  /// <summary>Shrinks to targetCount, relocating items from doomed stacks into empty surviving slots. Returns false if not enough room.</summary>
  public bool ShrinkTo(int targetCount);

  protected ItemStack GetStack(int index);

  protected int IndexOfStack(ItemStack stack);

  protected int Size { get; }
}
