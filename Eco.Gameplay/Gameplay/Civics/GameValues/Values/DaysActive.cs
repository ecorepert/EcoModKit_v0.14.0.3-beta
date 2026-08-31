// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.DaysActive
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
[LocDescription("'Active' days count of a citizen. (A day is considered 'Active' if citizen was online for more than the required amount of time per day)")]
public class DaysActive : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen whose 'Active' days we are counting.")]
  [CanAutoAssign]
  [Advanced]
  public GameValue<User> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Minimum required amount of hours a citizen must be online for a day to be considered active.")]
  public GameValue<float> HoursRequired { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject context);

  public static DaysActive Make(Type type, string propertyName);
}
