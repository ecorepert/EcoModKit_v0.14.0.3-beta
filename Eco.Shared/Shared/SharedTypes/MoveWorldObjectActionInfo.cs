// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.MoveWorldObjectActionInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> Server returns this struct as a response to a MoveWorldObject action request, when Ctrl+Clicking with the hammer. </summary>
[ForceAotHint]
public struct MoveWorldObjectActionInfo
{
  public int? RequiredSettlementID;
  public int? RequiredDeedID;
  public int CaloriesPerMovedUnit;
  public LocString DeedFailReason;
  public LocString SettlementFailReason;
}
