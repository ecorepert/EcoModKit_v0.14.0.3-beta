// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Achievements.AchievementInstance
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Achievements;

/// <summary>An individual achievement earned or in progress of being earned by a user.</summary>
/// <remarks>Contains details about where it was earned and the specifics of it.</remarks>
[Serialized]
[ForceCreateView]
public class AchievementInstance : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  ILinkable,
  ILinkableParameterized<bool>,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  [Serialized]
  public double TimeWhenProgressChanged;
  [Serialized]
  public double TimeWhenProgressNotified;
  [Serialized]
  public string AchievementName;
  [Serialized]
  public double TimeStamp;

  [Serialized]
  public string CustomDescription { get; set; }

  [Serialized]
  public string WorldSourceID { get; set; }

  [Serialized]
  public string WorldSourceName { get; set; }

  [Serialized]
  public float CurrentProgress { get; set; }

  [Serialized]
  public float RequiredProgress { get; set; }

  [Serialized]
  public bool Achieved { get; set; }

  [SyncToView(null, true)]
  public string IconName { get; }

  public LocString DisplayName { get; }

  public override string ToString();

  public AchievementDefinition Definition { get; }

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  public LocString UILinkContent(bool param);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
