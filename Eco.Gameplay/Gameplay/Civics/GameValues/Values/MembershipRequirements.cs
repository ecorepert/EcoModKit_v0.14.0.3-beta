// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.MembershipRequirements
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

public abstract class MembershipRequirements : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen to test.")]
  [Advanced]
  [CanAutoAssign]
  [AccessNotNeeded]
  public GameValue<IAlias> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Must the user have only one, or all of the listed memberships?")]
  public CategoryContainment Requirements { get; set; }

  protected abstract GamePickerList Memberships { get; }

  protected abstract LocString AliasNameSingular { get; }

  protected abstract LocString AliasNamePlural { get; }

  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);
}
