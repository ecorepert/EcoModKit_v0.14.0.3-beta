// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SoilDecontaminantItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side item definition for the "SoilDecontaminant" item.</para>
/// <para>More information about DecontaminantItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.DecontaminantItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Soil Decontaminant")]
[Eco.Gameplay.Items.Weight(500)]
[Ecopedia("Items", "Decontaminants", true, true, null)]
[Tag("Decontaminant")]
[LocDescription("Organic remediation blend that helps soil recover from light (Trash/sewage) pollution. Apply it to any ground or built block on a claim: one unit cancels one unit of Soil Pollution source, and half of the decontaminant waiting on an area takes effect every 24 hours.")]
[System.ComponentModel.Category("Tools")]
public class SoilDecontaminantItem : DecontaminantItem
{
  public override GroundPollutionType TargetType { get; }

  public override float Potency { get; }
}
