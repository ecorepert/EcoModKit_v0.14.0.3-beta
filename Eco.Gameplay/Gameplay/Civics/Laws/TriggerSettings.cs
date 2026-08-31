// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.TriggerSettings
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.Laws;

[Serialized]
public class TriggerSettings : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers,
  IProvidesContext,
  INotifyPropertyChanged,
  ICopyable,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [Derives(typeof (GameAction))]
  [LocDescription("When this action happens in the game, the conditions below will be tested for this law.")]
  public Type Trigger { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Trigger")]
  public Type Icon { get; }

  [Eco.Shared.Networking.Eco(true)]
  [HideRoot]
  [AllowEmpty]
  [Locked]
  public ControllerList<TriggerConfig> Configs { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Trigger")]
  public IEnumerable<IContextValue> ContextProvided { get; }

  public CopyResult CopyFrom(object source);

  public string Describe();

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
