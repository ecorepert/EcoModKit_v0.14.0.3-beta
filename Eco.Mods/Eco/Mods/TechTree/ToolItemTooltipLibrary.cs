// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ToolItemTooltipLibrary
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[TooltipLibrary]
public static class ToolItemTooltipLibrary
{
  public static void Initialize();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 200, TTCat.Default, TTFlags.None, typeof (PickaxeItem), new Type[] {})]
  public static LocString MinablesTooltip(Type type, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 200, TTCat.Default, TTFlags.None, typeof (AxeItem), new Type[] {})]
  public static LocString ChoppablesTooltip(Type type, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 200, TTCat.Default, TTFlags.None, typeof (ToolItem), new Type[] {})]
  public static LocString SubtypesTooltip(Type toolType, TooltipOrigin origin);
}
