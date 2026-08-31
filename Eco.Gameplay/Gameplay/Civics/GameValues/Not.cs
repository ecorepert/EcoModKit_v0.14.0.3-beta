// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Not
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Logic")]
[LocDescription("Returns opposite of specified value.")]
public class Not : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The opposite of this value will be used.")]
  public GameValue<bool> NotValue { get; set; }

  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);
}
