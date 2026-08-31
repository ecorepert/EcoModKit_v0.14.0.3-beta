// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.IGivesReputation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation;

[Serialized]
public interface IGivesReputation : 
  IReputationAssociated,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IHasUniversalID
{
  LocString MarkedUpName { get; }

  float GivableReputationPerDay { get; }

  float GivableReputationPerDayPerTarget { get; }

  Range GivableReputationToSingleTargetTotal { get; }

  int DisplayPriority { get; }

  LocString DescribeGivableRep();
}
