// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SampleMasterHarvestTalent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Skills;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary> Sample "Final Talent": level-scaled diminishing returns on harvest yield.
/// Every 5 talent levels gets 50% closer to a maximum 50% yield increase. </summary>
public class SampleMasterHarvestTalent : Talent
{
  public override bool Base { get; }

  public override Type TalentType { get; }
}
