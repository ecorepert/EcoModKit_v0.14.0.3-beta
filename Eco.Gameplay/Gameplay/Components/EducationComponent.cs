// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.EducationComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[Priority(0)]
[Tag("Education")]
[CreateComponentTabLoc("Education", false)]
[HasIcon(null)]
[RelatedFeature("EducationEnabled", true)]
public class EducationComponent : 
  WorldObjectComponent,
  IProvidesContext,
  IController,
  IViewController,
  IHasUniversalID,
  IHasEditableProperties,
  INotifyPropertyChanged,
  IHasClientControlledContainers,
  RoomUpdater.IRoomUpdates
{
  [Serialized]
  public double LastTickTime;
  public static bool DebugEducation;

  [Eco.Shared.Networking.Eco(true)]
  public 
  #nullable disable
  User Teacher { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public ControllerList<UserAndCalories> Students { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [RequiredTag("Teachable")]
  public Type SubjectType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [PopupEdit(EditOptions.OwnerOnly)]
  [LocDescription("Requirements that must be satisfied throughout the course. If the student fails to maintain these requirements, they will be expelled.")]
  public GameValue<bool> StudentRequirements { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [PopupEdit(EditOptions.OwnerOnly)]
  [LocDescription("If set, students will be charged this amount upon enrollment, which will be held in Escrow until completion or unerollment, upon which it will be split with the teacher and the owner's bank account.  Students that leave class before completion will have a prorated amount refunded.  Students who have a partial education when joining will be charged a prorated tuition.")]
  public CurrencyAndAmountGameValues TuitionFee { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [PopupEdit(EditOptions.OwnerOnly)]
  [LocDescription("Requirements that must be satisfied throughout the course. If the teacher fails to maintain these requirements, they will be removed.")]
  public GameValue<bool> TeacherRequirements { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [PopupEdit(EditOptions.OwnerOnly)]
  [LocDescription("Thie percentage of tuition will be paid to the teacher when a student finishes a course or unenrolls.")]
  public GameValue<float> PercentOfTuitionEarned { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Teaching will not begin until this many students are enrolled and have met the calorie requirements for studying.  This is to limit the calorie expenditure of the teacher, which is the same regardless of the number of students being taught.")]
  public int MinStudentsBeforeTeaching { get; set; }

  [SyncToView(null, true)]
  public string EducationStatus { get; set; }

  [SyncToView(null, true)]
  public bool ActivelyTeaching { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  [DependsOnController("Teacher", true)]
  public string TeacherName { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override LocString ComponentTabName { get; }

  public override void Initialize();

  [DependsOnController("TeachingCaloriesQueued", true)]
  [DependsOnController("Teacher", true)]
  public string TeachingTimeQueued();

  [RPC]
  [VisibilityParam("CanEnroll")]
  public Task Enroll(User user);

  [RPC]
  [VisibilityParam("CanUnenroll")]
  public void Unenroll(User user);

  [RPC]
  [VisibilityParam("CanBecomeTeacher")]
  public void BecomeTeacher(User user);

  [RPC]
  [VisibilityParam("IsTeacher")]
  public Task StopBeingTeacher(User user);

  [RPC]
  [VisibilityParam("CanStudy")]
  public void AddStudyLabor(User user, InteractionModifier modifier);

  public void UpdateEducationActiveState();

  public override void Tick();

  [RPC]
  [VisibilityParam("IsTeacher")]
  [LocDescription("Teaching requires labor, paid in advance in the form of calories. When students are enrolled and have studied, their queued 'study' calories and the teachers queued 'teaching' calories will tick down together, while their education rises.")]
  public void AddTeachingLabor(User user, InteractionModifier modifier);

  [DependsOnController("Students", true)]
  public bool CanStudy(User user);

  [DependsOnController("Students", true)]
  public bool IsStudent(User user);

  [DependsOnController("Teacher", true)]
  public bool IsTeacher(User user);

  [DependsOnController("Students", true)]
  public bool CanUnenroll(User user);

  [DependsOnController(new string[] {"Students", "SubjectType", "Teacher"})]
  public bool CanEnroll(User user);

  [DependsOnController(new string[] {"Students", "SubjectType", "Teacher"})]
  public bool CanBecomeTeacher(User user);

  public void RoomUpdated(Room room);
}
