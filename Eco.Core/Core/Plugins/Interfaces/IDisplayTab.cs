// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IDisplayTab
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Plugins.Interfaces;

/// <summary>Interface for Display tabs with methods returning title and content. It also has callback handler called when tab visibility changes (i.e. if you want to avoid expensive calculation when tab is invisible).</summary>
public interface IDisplayTab
{
  /// <summary>Callback to be called when tab become visible or hidden.</summary>
  void OnDisplayTabVisibilityChange(bool show);

  /// <summary>Returns title which will be used as UI tab title.</summary>
  string GetDisplayTitle();

  /// <summary>Returns current content of UI tab.</summary>
  string GetDisplayText();
}
