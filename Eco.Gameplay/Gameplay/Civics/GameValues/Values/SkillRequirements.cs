// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.SkillRequirements
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("Detect skills players have or lack.")]
[NoAutogenCode]
public class SkillRequirements : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen to test.")]
  [Advanced]
  public GameValue<User> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Which skills to consider.")]
  public GamePickerList<Skill> Skills { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Must the user have only one, or all of the listed skills?")]
  public CategoryContainment Requirements { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("How many level-ups must the skills have?")]
  public GameValue<float> RequiredLevel { get; set; }

  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);
}
