// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserXP
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class UserXP : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public static readonly ThreadSafeAction<User> UserSkillRateChangedEvent;

  [Serialized]
  [SyncToView(null, true)]
  public float XP { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int StarsAvailable { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int TotalStarsEarned { get; set; }

  [SyncToView(null, true)]
  [DependsOn("TotalStarsEarned")]
  public int NextStarCost { get; }

  [SyncToView(null, true)]
  public float SkillRate { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public void Initialize(User user);

  public void UseXP(float amount);

  public void UpdateSkillRate();

  public void AddStars(int stars);

  public void RemoveStars(int stars);

  public void AddLevel(int stars);

  public void RemoveLevel(int stars);

  public void AddExperience(float amount);

  public void UpdateXP(float timePassed);

  /// <summary>
  /// Setting the experience of a user on creation which retroactively adds the total experience the user would have accumulated since the server
  /// started by the rate set inside the config value (we set this default to off as 0).
  /// </summary>
  public void SetInitialXP();

  [DoNotNotify]
  public ref int ControllerID { get; }
}
