// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.Box2PointFill
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Blocks;
using Eco.Shared.Localization;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side block fill definition for "Box2Point".</para>
/// <para>More information about BlockFill objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Blocks.BlockFill.html</para>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
/// </summary>
public class Box2PointFill : BlockFill
{
  public override int SortOrder { get; }

  public override string Name { get; }

  public override LocString DisplayName { get; }

  public override LocString DisplayDescription { get; }

  public override int HammerTier { get; }

  public override SelectionMode SelectionMode { get; }
}
