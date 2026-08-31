// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.Internal.SpeaksWellOfOthersReputationGiver
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation.Internal;

[Serialized]
public class SpeaksWellOfOthersReputationGiver : 
  IGivesReputation,
  IReputationAssociated,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IHasUniversalID
{
  public LocString MarkedUpName { get; }

  [Serialized]
  public int Id { get; set; }

  float IGivesReputation.GivableReputationPerDay { get; }

  public float GivableReputationPerDayPerTarget { get; }

  public Range GivableReputationToSingleTargetTotal { get; }

  int IGivesReputation.DisplayPriority { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
