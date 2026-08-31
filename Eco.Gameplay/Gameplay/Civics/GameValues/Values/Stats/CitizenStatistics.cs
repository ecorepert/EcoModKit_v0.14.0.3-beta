// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.Stats.CitizenStatistics
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values.Stats;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Statistics")]
[LocDescription("Returns statistical values regarding players.")]
public class CitizenStatistics : StatSum
{
  [Eco.Shared.Networking.Eco(true)]
  [Derives(typeof (GameAction))]
  [LocDescription("The game action we're evaluating.")]
  public Type Action { get; set; }

  protected override Eval<string> GetActionName(IContextObject context);

  protected override string ValueDescription { get; }

  protected override Type StatType { get; }
}
