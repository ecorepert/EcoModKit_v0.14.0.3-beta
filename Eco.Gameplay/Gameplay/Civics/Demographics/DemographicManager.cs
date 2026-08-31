// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Demographics.DemographicManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Demographics;

[Serialized]
[ChatCommandHandler]
public class DemographicManager : 
  Singleton<DemographicManager>,
  IRegistrarManager<Demographic, SpecialDemographics>,
  IRegistrarManager,
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers
{
  /// <summary>First initialized and all demographics have their usersets cached.</summary>
  public static Initializer Init;
  [Serialized]
  public ThreadSafeDictionary<int, DemographicRecord> UserIdToRecord;

  public static event Action DemographicsUpdated;

  public static Demographic Everyone { get; }

  public static Demographic Active { get; }

  public static Demographic LongTerm { get; }

  public static Demographic Abandoned { get; }

  public IEnumerable<Demographic> AssignedDemographics(User user);

  public IEnumerable<Demographic> ActiveDraftAndProposedDemographics(Settlement settlement);

  public Eco.Core.Systems.Registrar<Demographic> Registrar { get; }

  public Demographic[] SpecialEntries { get; set; }

  public ref int ControllerID { get; }

  public void Initialize();

  public void InitSpecialEntry(Demographic demo);

  public void UpdateActiveDemographic();

  public void UpdateLongTermDemographic();

  public void UpdateAbandonedDemographic();

  internal void SlowTick();

  public Result DoDemographicUpdate(Demographic limitToDemographic = null, bool suppressChangeNotice = false);

  public Result UpdateDemographicList(
    IEnumerable<Demographic> demographicsList,
    bool suppressChangeNotice = false);

  public Demographic Get(SpecialDemographics specialType);
}
