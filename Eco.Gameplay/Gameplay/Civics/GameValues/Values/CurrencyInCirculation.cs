// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.CurrencyInCirculation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("Total amount of a currency that exists in all bank accounts.")]
public class CurrencyInCirculation : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The currency owned by the citizen to count.")]
  public GameValue<Eco.Gameplay.Economy.Currency> Currency { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);

  public override LocString Description();
}
