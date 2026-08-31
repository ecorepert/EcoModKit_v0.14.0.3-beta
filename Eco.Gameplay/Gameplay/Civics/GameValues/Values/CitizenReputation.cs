// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.CitizenReputation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("Reputation of a given citizen.")]
public class CitizenReputation : GameValue<float>
{
  public override LocString Description();

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen whose reputation we're checking.")]
  [CanAutoAssign]
  public GameValue<User> Citizen { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);
}
