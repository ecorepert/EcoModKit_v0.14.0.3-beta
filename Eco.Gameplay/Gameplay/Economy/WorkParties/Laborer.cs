// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.Laborer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
public class Laborer : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IValidity,
  IHasWorkParty,
  IRootDescriber,
  IProvidesContext
{
  public virtual event PropertyChangedEventHandler PropertyChanged;

  [Serialized]
  [SyncToView(null, true)]
  [AllowNullInView]
  public User Citizen { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float PercentContribution { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  public string Role { get; set; }

  [Serialized]
  public float LaborContribution { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  public WorkParty WorkParty { get; set; }

  public IDescribable RootDescriber { get; }

  [SyncToView(null, true)]
  [DependsOn("RequirementsToTakeRole")]
  public string Requirements { get; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  public GameValue<bool> RequirementsToTakeRole { get; set; }

  public string Describe { get; }

  public ref int ControllerID { get; }

  public virtual void Initialize(WorkParty workParty);

  [RPC]
  public void SetRequirements(Player player);
}
