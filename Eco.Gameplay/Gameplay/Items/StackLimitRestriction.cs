// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.StackLimitRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Limits the inventory stack sizes to a different quantity than <see cref="P:Eco.Gameplay.Items.Item.MaxStackSize" /></summary>
public class StackLimitRestriction : InventoryRestriction
{
  /// <summary>The maximum stack size allowed by the restriction.</summary>
  public virtual int MaxItems { get; protected set; }

  /// <summary>If true this inventory restriction will not apply external modifiers to its settings.</summary>
  public virtual bool StaticLimit { get; protected set; }

  public override LocString Message { get; }

  public virtual bool Enabled { get; }

  public override RestrictionDescriptor Describe();

  public StackLimitRestriction(int maxItems, bool staticLimit = false);

  public override int MaxAccepted(Item item);

  protected virtual int GetMaxItemsOverrider(Item item);
}
