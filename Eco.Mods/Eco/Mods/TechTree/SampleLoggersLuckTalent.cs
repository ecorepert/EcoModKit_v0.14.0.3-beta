// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SampleLoggersLuckTalent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Skills;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary> Sample Logger's Luck talent: single chance-based proc on tree fell.
/// 50% chance to auto-slice the trunk into pickup-sized pieces AND destroy the stump in one hit.
/// Uses the boolean-query pattern: <c>BonusManager.ApplyBonuses(ctx, 0f) &gt; 0f</c>.
/// Per lead designer: one proc does both actions (slice + stump), player still picks up pieces manually. </summary>
public class SampleLoggersLuckTalent : Talent
{
  public override bool Base { get; }

  public override Type TalentType { get; }
}
