// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicsTests
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Civics;

[ChatCommandHandler]
public static class CivicsTests
{
  public static Result ConfigureFoundationObject(
    User user,
    WorldObject capitolObject,
    CivicsTests.GovernmentType govType);

  public static Result ConfigureAmendmentsObject(
    User mainUser,
    WorldObject amendments,
    WorldObject capitol);

  public static Result ConfigureBoardOfElectionsObject(User mainUser, WorldObject boardOfElections);

  public static Result ConfigureLargeCourtObject(User mainUser, WorldObject largecourtObject);

  public static Result ConfigureZoningOfficeObject(
    User mainUser,
    WorldObject zoningOffice,
    int maps = 1,
    int districtCount = 4,
    bool setActive = true,
    Settlement settlement = null);

  public static Result ConfigureCensusBureauObject(User mainUser, WorldObject censusBureau);

  public static Result ConfigureGovernmentOfficeObject(User mainUser, WorldObject governmentOffice);

  public static Election CreateTestElectionForPosition(
    User user,
    Settlement settlement,
    ElectedTitle title);

  public static Election CreateTestElectionForChoice(
    User user,
    Settlement settlement,
    WorldObject governmentOffice);

  public enum GovernmentType
  {
    ElectionsRequired,
    EveryoneCanExecute,
  }
}
