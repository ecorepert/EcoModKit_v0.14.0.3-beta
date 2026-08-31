// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CompositeCeibaTableRecipe
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side recipe definition for "CompositeCeibaTable".</para>
/// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[RequiresSkill(typeof (CompositesSkill), 3)]
[ForceCreateView]
[Ecopedia("Housing Objects", "Seating", false, true, "Composite Ceiba Table Item")]
public class CompositeCeibaTableRecipe : Recipe
{
}
