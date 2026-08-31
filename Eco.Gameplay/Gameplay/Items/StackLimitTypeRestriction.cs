// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.StackLimitTypeRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Limit the inventory stack sizes to a different quantity than <see cref="P:Eco.Gameplay.Items.Item.MaxStackSize" /> depending on item type table</summary>
public class StackLimitTypeRestriction : StackLimitRestriction
{
  public Dictionary<System.Type, int> StackSizeMap;

  public StackLimitTypeRestriction(bool overrideOther = false, int defaultSize = 30, bool staticLimit = false);

  public override int MaxAccepted(Item item);

  public override bool Enabled { get; }

  public void AddListRestriction(IEnumerable<System.Type> items, int stackSize);
}
