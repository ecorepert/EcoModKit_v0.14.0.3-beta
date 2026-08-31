// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.TimerTriggerConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Serialized]
[NonSelectable]
public class TimerTriggerConfig : TriggerConfig
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Number of hours between executions of this action.  It's run immediately when installed, then at this interval.")]
  public float HoursBetweenExecutions { get; set; }

  [SyncToView(null, true)]
  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);

  [Serialized]
  public double NextTrigger { get; internal set; }

  [Serialized]
  public double LastTrigger { get; internal set; }

  protected virtual Type TimerActionType { get; }

  public void OnTimer(double currentTime);

  public override LocString GetTriggerTooltip(LawSection section);

  internal void SetTimerFromOldTrigger(CitizenTimerTriggerConfig oldTrigger);
}
