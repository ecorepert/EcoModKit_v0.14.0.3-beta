// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.SkillReqs
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Skills;

public class SkillReqs : IController, IViewController, IHasUniversalID, ICloneable
{
  [Eco.Shared.Networking.Eco(true)]
  public float Tier { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int StarsToSelfTeach { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int StarsToBeTaught { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int StarsToBecomeTeacher { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float CaloriesToTeach { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float CaloriesToLearn { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float TimeToLearnHours { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float ClassroomTierRequired { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool CanBeEducated { get; set; }

  public float TeachingCaloriesPerSecond { get; }

  public float LearningCaloriesPerSecond { get; }

  public float TimeToLearnSeconds { get; }

  public object Clone();

  public SkillReqs Blend(SkillReqs blendTarget, float lerp);

  public ref int ControllerID { get; }
}
