// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.StackableRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Restricts an inventory so it can only accept specific stackable items.</summary>
public class StackableRestriction : InventoryRestriction
{
  public StackableRestriction(ItemRepresentation[] allowedStackables);

  public override LocString Message { get; }

  public override int MaxAccepted(Item item);

  public override RestrictionDescriptor Describe();
}
