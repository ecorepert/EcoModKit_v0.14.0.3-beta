// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WallsFormGroup
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Blocks;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>
/// Server side definition for the "Walls" block form group.
/// This object inherits the FormGroup base class.
/// </para>
/// <para>More information about FormGroup objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Blocks.FormGroup.html</para>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
/// </summary>
public class WallsFormGroup : FormGroup
{
  /// <summary>Defines the name of the form group.</summary>
  public override string Name { get; }

  /// <summary>The pural localization name for block form group.</summary>
  public override LocString DisplayName { get; }

  /// <summary>The tooltip description for the food item.</summary>
  public override LocString DisplayDescription { get; }

  /// <summary>Defines the sort order used by this block forum group</summary>
  public override int SortOrder { get; }
}
