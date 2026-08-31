// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.SkillManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Skills;

public class SkillManager : 
  Singleton<SkillManager>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public static SkillSettings Settings;

  public static event Action OnSkillValsChanged;

  public void Initialize();

  public SkillReqs GetOrMakeReqs(float tier);

  public int GetCostOfStar(int starNumber);

  public virtual event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
