// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicActionFuncs
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Players;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Civics;

public static class CivicActionFuncs
{
  public static 
  #nullable disable
  Task<Result> FullExecuteAsync(
    User user,
    CivicAction action,
    bool force = false,
    bool notify = true,
    Election forceAttachToElection = null,
    bool bypassConstitution = false);

  public static Result ForceFullExecuteNow(
    User user,
    CivicAction action,
    bool notify = true,
    Election forceAttachToElection = null,
    bool bypassConstitution = false);

  public static CivicActionResult[] GetConstitutionActionResult(User user, CivicAction action);
}
