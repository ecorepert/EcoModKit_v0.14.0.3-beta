// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TailoringCustomMadeTalentGroup
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side talent group definition for "CustomMade".</para>
/// <para>More information about TalentGroup objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.TalentGroup.html</para>
/// </summary>
[Serialized]
[LocDisplayName("Custom Made: Tailoring")]
[LocDescription("Reduces resource cost for Clothing and Furniture but increases labor costs.")]
public class TailoringCustomMadeTalentGroup : TalentGroup
{
}
