// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.Stats.EnvironmentStatistic
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Stats;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values.Stats;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Statistics")]
[LocDescription("One of a variety of values related to the environment.")]
public class EnvironmentStatistic : StatGameValue
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The environment value to take.")]
  [RequiredTag("Climate")]
  public StatEntry Statistic { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
