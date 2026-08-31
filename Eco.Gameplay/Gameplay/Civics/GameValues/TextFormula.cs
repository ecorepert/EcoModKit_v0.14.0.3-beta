// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.TextFormula
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Math")]
[LocDescription("Calculates a formula written out in text, using variables defined below.")]
public class TextFormula : 
  GameValue<float>,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LargeUI]
  [LocDescription("The formula to compute. Can use operators +,-,*,/,%,^,(). Can use variables: add a name and you'll have the option to auto-create them from the tooltip.")]
  public string Formula { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDisplayName("Where")]
  [AllowEmpty]
  [UIListTypeName("IEnumerableHeader")]
  [AllowCopyPaste]
  public ControllerList<NamedVariable> Variables { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);

  public Result Valid();
}
