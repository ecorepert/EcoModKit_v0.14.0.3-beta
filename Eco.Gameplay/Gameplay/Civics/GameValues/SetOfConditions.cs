// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.SetOfConditions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Logic")]
[LocDescription("Test a subset of conditions.")]
public class SetOfConditions : 
  GameValue<bool>,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDisplayName("If")]
  [AllowEmpty]
  [UIListTypeName("IEnumerableHeader")]
  [AllowCopyPaste]
  public ControllerList<GameValue<bool>> List { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public RequiredTrue Comparison { get; set; }

  public override LocString Description();

  public void Clear();

  protected override Eval<bool> Evaluate(IContextObject action);
}
