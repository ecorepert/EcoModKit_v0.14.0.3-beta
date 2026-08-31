// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Culture.CultureConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Economy.Reputation;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Culture;

/// <summary>Values related to the culture system, set via mods.</summary>
public static class CultureConfig
{
  /// <summary>Accepts a placed world object, the settlement it's displayed in, and a usertexture, and calculates the culture value.</summary>
  public static Func<CultureConfig.CultureInputs, ValResult<float>> CultureValueCalculation;
  /// <summary>The ArtworCalculation function by default uses this value to reduce domestic reputation.</summary>
  public static float SameSettlementReputationMutliplier;

  public struct CultureInputs
  {
    public WorldObject WorldObject;
    public Settlement Settlement;
    public IHasReputation ReputationTarget;
    public LocString TypeOfWork;
    public LocString TypeOfWorkPossessive;
  }
}
