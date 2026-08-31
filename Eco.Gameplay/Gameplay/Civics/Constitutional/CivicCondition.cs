// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitutional.CivicCondition
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Misc;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Constitutional;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Specific Civic Abilities")]
[LocDescription("Covers civic action but is limited to selected civic objects.")]
public class CivicCondition : CivicConditionBase, ICustomValidity, IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [AllowEmpty]
  [RequiredTag("CanBeInConstitution")]
  public GamePickerList<CivicAction> PerformingCivicActions { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowEmpty]
  [RequiredTag("CanBeInConstitution")]
  [ForceSelectType]
  public GamePickerList<IProposable> ChangingCivicObjects { get; set; }

  public override IEnumerable<Type> AllTypes { get; }

  public Result Valid();

  public override LocString Description();

  /// <summary>Returns true if this civic condition matches the given action (either because it applies to the type of civic action, or its acting on a container of the given type of civic types.)</summary>
  public override bool AppliesTo(CivicAction action);

  /// <summary>Returns true if this civic condition matches the given action (either because it applies to the type of civic action, or its acting on a container of the given type of civic types.)</summary>
  public override bool AppliesTo(Type type);
}
