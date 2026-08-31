// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.Wealth
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("How much currency a citizen has in all the bank accounts they manage (pro-rated when there are multiple managers). Ignores Government Accounts.")]
public class Wealth : GameValue<float>, ICustomValidity, IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The currency owned by the citizen to count.")]
  public GameValue<Eco.Gameplay.Economy.Currency> Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The citizen whose wealth is being calculated.")]
  public GameValue<User> Citizen { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);

  public override LocString Description();

  public Result Valid();
}
