// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.SettlementTimerTriggerConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics.GameValues;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Serialized]
[NonSelectable]
public class SettlementTimerTriggerConfig : TimerTriggerConfig
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If set, the timer also runs on sub-settlements recursively (children of children), not just the direct child settlements.")]
  public bool IncludeSubSettlements { get; set; }

  protected override Type TimerActionType { get; }

  [SyncToView(null, true)]
  public override LocString Description();
}
