// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.PluginModulesComponentTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Components;
using Eco.Gameplay.Modules;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class PluginModulesComponentTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy("Inventory", null, null)]
  [TooltipAffectedBy("ModulesActive", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PluginModules(this 
  #nullable disable
  PluginModulesComponent pluginModulesComponent);

  public static TooltipSection GetModuleBenefitsTooltipSection(
    this PluginModulesComponent pluginModulesComponent,
    LocString title,
    Func<EfficiencyModule, bool> moduleFilter);
}
