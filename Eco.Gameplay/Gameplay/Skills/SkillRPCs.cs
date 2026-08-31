// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.SkillRPCs
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Skills;

public static class SkillRPCs
{
  [RPC]
  public static void SkillClick(this 
  #nullable disable
  Skill skill, Player player);

  [RPC]
  public static void OpenUI(this Skill skill, Player player);

  [RPC]
  public static Task AbandonSpecialty(this Skill skill, User user, bool isSelf = false);

  [RPC]
  public static IEnumerable<LocString> GetSkilledPlayers(this Skill skill);

  [RPC]
  public static Task Learn(this Skill skill, Player player, bool selfTeach);
}
