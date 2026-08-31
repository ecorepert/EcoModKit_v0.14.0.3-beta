// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.DisplayTab
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Core.Plugins;

/// <summary>Simple implementation of <see cref="T:Eco.Core.Plugins.Interfaces.IDisplayTab" /> interface which may be used as POCO for <see cref="P:Eco.Core.Plugins.Interfaces.IHasDisplayTabs.DisplayTabs" />.</summary>
public class DisplayTab : IDisplayTab
{
  public DisplayTab(
    LocString displayTitle,
    Func<string> displayTextGenerator,
    Action<bool>? onDisplayTabVisibilityChange = null);

  /// <inheritdoc cref="M:Eco.Core.Plugins.Interfaces.IDisplayTab.OnDisplayTabVisibilityChange(System.Boolean)" />
  public void OnDisplayTabVisibilityChange(bool show);

  /// <inheritdoc cref="M:Eco.Core.Plugins.Interfaces.IDisplayTab.GetDisplayTitle" />
  public string GetDisplayTitle();

  /// <inheritdoc cref="M:Eco.Core.Plugins.Interfaces.IDisplayTab.GetDisplayText" />
  public string GetDisplayText();
}
