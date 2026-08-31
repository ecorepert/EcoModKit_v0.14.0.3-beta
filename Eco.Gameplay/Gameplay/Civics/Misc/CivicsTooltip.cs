// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.CivicsTooltip
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Civics.Misc;

/// <summary>
/// Tooltip handler for Civics tooltips.
/// <para> TypeTooltip hands over the tooltip generation logic to this class for type properties that are being hovered. </para>
/// </summary>
public static class CivicsTooltip
{
  /// <summary> Tries to get the tooltip text for a specific type from cache -- if it isn't cached, generates, caches, then returns it. <para> Cached tooltips are localized. </para> </summary>
  public static LocString GetOrAddCachedTooltip(
  #nullable disable
  Type type);
}
