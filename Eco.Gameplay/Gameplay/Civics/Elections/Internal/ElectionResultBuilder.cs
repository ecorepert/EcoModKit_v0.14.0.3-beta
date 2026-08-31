// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.Internal.ElectionResultBuilder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable enable
namespace Eco.Gameplay.Civics.Elections.Internal;

public static class ElectionResultBuilder
{
  public static 
  #nullable disable
  ElectionResult BuildElectionResult(Election election, bool vetoed, User vetoer, bool forceEnd = false);

  public static LocString ShowAllVotesLink(Election electionLink);
}
