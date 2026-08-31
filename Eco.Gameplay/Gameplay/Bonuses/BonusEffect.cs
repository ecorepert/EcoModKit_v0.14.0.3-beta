// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffect
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Abstract base class for bonus effects. Defines how a value is transformed. Subclasses implement specific transformation logic. </summary>
public abstract class BonusEffect : IDescribable
{
  public bool LowerIsBetter { get; init; }

  /// <summary> Transform the input value according to this effect's logic. </summary>
  public abstract float TransformValue(BonusContext context, float value);

  /// <summary> Order in which this effect is applied. Lower values are applied first. Default: 0. Multiplicative effects typically use -1, overrides use 1. </summary>
  public virtual float OrderOfOperations { get; }

  /// <summary> Describe the effect. Context may be null (generic description) or set (context-aware, showing current-level values). </summary>
  public abstract LocString Description(BonusContext context = null);

  /// <summary> Whether this effect scales with <see cref="P:Eco.Gameplay.Bonuses.BonusContext.SourceLevel" /> (talent level). Used to determine if a talent is upgradeable. </summary>
  public virtual bool ScalesWithTalentLevel { get; }

  /// <summary> Satisfies <see cref="T:Eco.Gameplay.Systems.Controllers.IDescribable" /> — delegates to <see cref="M:Eco.Gameplay.Bonuses.BonusEffect.Description(Eco.Gameplay.Bonuses.BonusContext)" /> with null context. </summary>
  LocString IDescribable.Description();
}
