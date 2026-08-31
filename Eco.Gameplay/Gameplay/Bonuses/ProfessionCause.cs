// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.ProfessionCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Triggers when the recipe requires any specialty belonging to a dynamically resolved profession.
/// The profession is resolved at trigger time via <see cref="P:Eco.Gameplay.Bonuses.ProfessionCause.GetProfession" /> so player-driven selections
/// (e.g. the profession picked on an area benefit building) apply immediately without rebuilding bonuses.
/// No profession selected means the bonus stays dormant. </summary>
public class ProfessionCause : BonusCause
{
  /// <summary> Returns the profession root skill type, or null when none is selected. </summary>
  public Func<Type> GetProfession { get; init; }

  public override bool IsTriggered(BonusContext context);

  public override LocString Description();
}
