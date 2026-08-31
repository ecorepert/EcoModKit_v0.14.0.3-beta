// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.SettlementType
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Items;

/// <summary>Wrapper for working with SettlementType Tier, provides easy access methods like getting children/parents and Display name</summary>
[Serialized]
public struct SettlementType : IEquatable<SettlementType>, IComparable<SettlementType>
{
  private static 
  #nullable disable
  string[] names;
  [Serialized]
  private int tier;

  /// <summary>Returns each settlement type available.</summary>
  public static SettlementType[] All { get; }

  public static SettlementType LowestSettlement { get; }

  public static SettlementType HighestSettlement { get; }

  public SettlementType(int tier);

  /// <Returns>Localized name taken from SettlementConfig.SettlementTypes based on the Tier</Returns>
  public LocString DisplayName { get; }

  public LocString DisplayNamePlural { get; }

  public bool CanHaveParent { get; }

  public bool CanHaveChildrenSettlements { get; }

  public bool ShouldAlwaysHaveDirectCitizens { get; }

  public IEnumerable<SettlementType> ChildrenTypes();

  public IEnumerable<SettlementType> ParentTypes();

  /// <Returns>SettlementType of 1 tier lower if this settlement can have a child settlement I.E is not of first tier, otherwise null</Returns>
  public SettlementType? GetChild();

  /// <Returns>SettlementType of 1 tier higher if this settlement can have parent settlement I.E is not of final tier, otherwise null</Returns>
  public SettlementType? GetParent();

  public bool Equals(SettlementType other);

  public int CompareTo(SettlementType other);

  public static explicit operator int(SettlementType v);

  public override string ToString();

  public override bool Equals(object obj);

  public override int GetHashCode();

  public static bool operator ==(SettlementType x, SettlementType y);

  public static bool operator !=(SettlementType x, SettlementType y);

  public static bool operator <(SettlementType x, SettlementType y);

  public static bool operator <=(SettlementType x, SettlementType y);

  public static bool operator >(SettlementType x, SettlementType y);

  public static bool operator >=(SettlementType x, SettlementType y);
}
