// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewSelectorFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.View;

[Flags]
public enum ViewSelectorFlags
{
  None = 0,
  AllowEmpty = 1,
  AllowNullInView = 2,
  AccessNotNeedded = 4,
  InJurisdiction = 8,
  GovernmentAccountsOnly = 16, // 0x00000010
  HidePermanentAccounts = 32, // 0x00000020
  HideBooleanElections = 64, // 0x00000040
  AliasContainsPlayer = 128, // 0x00000080
  DynamicFlags = 256, // 0x00000100
  HasTypeLimiter = 512, // 0x00000200
  CurrencyIsHeld = 1024, // 0x00000400
  ForceSelectType = 2048, // 0x00000800
  UseDiscoveryFilter = 4096, // 0x00001000
  OnlySettlementsAtLocation = 8192, // 0x00002000
  OnlyHigherTierSettlements = 16384, // 0x00004000
  OnlyLowerTierSettlements = 32768, // 0x00008000
  SettlementCurrentAndCandidatesParents = 65536, // 0x00010000
  SettlementCurrentAndCandidatesChildren = 131072, // 0x00020000
  SettlementParentsAndSelf = 262144, // 0x00040000
  SettlementChildrenAndSelf = 524288, // 0x00080000
  SettlementOnly = 1048576, // 0x00100000
  Unfiltered = 2097152, // 0x00200000
  ActiveOnly = 4194304, // 0x00400000
}
