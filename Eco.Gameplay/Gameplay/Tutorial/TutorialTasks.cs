// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.TutorialTasks
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Tutorial;

public static class TutorialTasks
{
  public const string DiscordTitle = "Discord";
  public const string ControlsTitle = "Controls";
  public const string MiningTitle = "Mining";
  public const string FindFoodTaskTitle = "Food";
  public const string EatFoodTaskTitle = "Forage For Food";
  public const string BuildHouseTaskTitle = "Build a House";
  public const string MaterialProcessingTitle = "Material Processing";
  public const string ChooseRolesTitle = "Choose a Specialty";
  public const string SettingUpCampTitle = "Setting Up Camp";
  public const string WorkOrdersTitle = "Work Orders";
  public const string MacheteTitle = "Machete";
  public const string DiggingTitle = "Digging";
  public const string ClaimingLandTitle = "Claiming Land";
  public const string FurnishHouseTitle = "Furnish House";
  public const string DinnerPartyTitle = "Dinner Party";
  public static readonly Dictionary<string, UserTaskTemplate> TaskTemplates;
  public static TutorialTaskPopup[] ExtraPopups;

  public static UserTaskTemplate AddTutorialTask(
    UserTaskTemplate taskTemplate,
    params string[] chainTo);

  public static void AddInitialTutorialTasks(User user, bool clearPopups = false);

  public static void SkipAllTutorials(User user);

  public static void EnsureUIStates(User user);

  /// <summary>Setup tutorials to trigger activation on specific events.</summary>
  /// <param name="user"></param>
  public static void TrySubscribeTutorials(User user);
}
