// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemRepresentation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Represents a specific item or a group of items.</summary>
[ForceCreateView]
public abstract class ItemRepresentation : ItemLinkable
{
  /// <summary>
  /// Checks if this instance represents an item of the given type.
  /// If this instance represents more than one item type it checks if those types include that one.
  /// </summary>
  /// <remarks>
  /// This method of checking for item match ignores any unique properties an item instance might have and only checks the type.
  /// If matching some conditions other than type for a unique item (like durability level) is necessary use <see cref="M:Eco.Gameplay.Items.ItemRepresentation.RepresentsItem(Eco.Gameplay.Items.Item)" /> instead.
  /// </remarks>
  public abstract bool RepresentsItemType(Type itemType);

  /// <summary>
  /// Checks if this instance represents an item of the same type as <paramref name="item" />.
  /// If this instance represents more than one item type it checks if those types include that one.
  /// </summary>
  /// <inheritdoc cref="M:Eco.Gameplay.Items.ItemRepresentation.RepresentsItemType(System.Type)" />
  public bool RepresentsItemType(Item item);

  /// <summary>
  /// Checks if this instance represents the given item taking into the account its type and any unique properties it might have,
  /// like durability level, using rules defined for that specific item type.
  /// </summary>
  /// <remarks>
  /// Use this method if you need custom comparison rules for unique items, like similar durability levels or same associated settlement.
  /// If only item type is relevant, use <see cref="M:Eco.Gameplay.Items.ItemRepresentation.RepresentsItemType(System.Type)" /> instead.
  /// </remarks>
  public abstract bool RepresentsItem(Item item);

  /// <summary>If two items have the same hash they're identical. Note that this doesnt use 'quality groups', only exact identical.</summary>
  public virtual int RepresentativeHash();
}
