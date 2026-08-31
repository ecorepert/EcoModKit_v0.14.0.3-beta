// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.Stats.StatSum
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values.Stats;

public abstract class StatSum : StatGameValue
{
  protected abstract Eval<string> GetActionName(IContextObject context);

  protected abstract string ValueDescription { get; }

  protected abstract Type StatType { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Determines the range of time that we count stats from. Use '0' for 'all time'.")]
  public GameValue<float> TimeRangeInHours { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The type of range we're using. If 'counting back from present', we use the past X hours.  If using 'current time block', we use the most recent block of time of that size (IE, if time range is 24 we would use only the current day, resetting at midnight).")]
  public StatTimeRange TimeRangeType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If set, only count actions by this citizen.")]
  [AllowNullInView]
  [DontReceiveAutoAssign]
  public GameValue<User> RestrictCountToCitizen { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
