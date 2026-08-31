// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.ComponentTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class ComponentTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (TextItemData), "Text", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 150, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TextTooltip(this TextItemData data);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 150, TTCat.Details, TTFlags.None, typeof (WorldObjectComponent), new Type[] {})]
  public static LocString TooltipCompList(Type type);
}
