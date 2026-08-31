// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.HoursPlayed
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("Online time of a citizen.")]
public class HoursPlayed : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who's online time we're measuring")]
  [CanAutoAssign]
  [Advanced]
  public GameValue<User> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The range to check. '0' means count all online time.")]
  public GameValue<float> WithinLastNumberOfDays { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject context);

  public static HoursPlayed Make(Type type, string propertyName, float activeTimeRange);
}
