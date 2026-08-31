// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.TagStack
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;
using JetBrains.Annotations;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>
/// should handle all of the tags =&gt; item conversions and comparisons.
/// Tag stacks SHOULD NOT be used to represent actual items.
/// Mostly should be not-displayed to the user (crafting elements are used for that).
/// </summary>
[Serialized]
public class TagStack : ItemStack, IStack
{
  [Serialized]
  public float FractionalQuantity;
  public HashSet<string>? AllowedItemTypeNames;

  [SyncToView(null, true)]
  [DependsOnController("Item", true)]
  public bool IsSpecificItem { get; }

  [SyncToView(null, true)]
  [DependsOnController("Item", true)]
  public Tag? Tag { get; }

  public override string TypeString { get; }

  public override int GetHashCode();

  public override bool Equals(object? obj);

  public override ItemRepresentation? StackObject { get; }

  [UsedImplicitly]
  public TagStack();

  public TagStack(Tag? tag, Item? item, int quantity, float fractionalQuantity);

  public TagStack(string name, Item? item, int quantity, float fractionalQuantity);

  public bool IsLiquid { get; }

  public int NumberToTake(ItemStack stack);

  public override int NumberToTake(Item? item, int quantity);
}
