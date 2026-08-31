// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SampleOverIntegrityTalent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Skills;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary> Sample talent: 15% over-integrity tools when crafting with Logging skill recipes.
/// Crafted tools start at 115% integrity (115/100 = more repair cycles). </summary>
public class SampleOverIntegrityTalent : Talent
{
  public override bool Base { get; }

  public override Type TalentType { get; }
}
