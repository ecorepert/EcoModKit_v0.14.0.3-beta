// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Arithmetic
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Math")]
[LocDescription("Basic math operations.")]
[LocCategoryDescription("Arithmetic operations on other values from the world.")]
public class Arithmetic : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [NegativeAllowed]
  [LocDescription("The left number of the operation.")]
  public GameValue<float> LeftNumber { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [NegativeAllowed]
  [LocDescription("The operation to perform.")]
  public MathOperation Operation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [NegativeAllowed]
  [LocDescription("The right number of the operation.")]
  public GameValue<float> RightNumber { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);

  public override LocString Description();
}
