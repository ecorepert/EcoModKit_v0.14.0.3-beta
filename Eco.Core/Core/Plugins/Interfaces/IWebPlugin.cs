// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IWebPlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;

#nullable enable
namespace Eco.Core.Plugins.Interfaces;

/// <summary>Interface for a plugin to allow web based content serving on the elections Website.</summary>
/// <remarks>It is not recommended to write IWebPlugin implementations that are not compiled to a DLL assembly prior to server start.</remarks>
public interface IWebPlugin
{
  /// <summary>Returns the name that this plugin should represent on the websites side navigation.</summary>
  LocString GetMenuTitle();

  /// <summary>Returns the index url to load into the website when this plugin is selected. If not provided it will load the index.html out of the the plugin's file providers.</summary>
  string? GetPluginIndexUrl();

  /// <summary>Returns the optional font awesome class to use for the menu link. More information about FontAwesome and the list of available icons can be found here https://fontawesome.com/</summary>
  string? GetFontAwesomeIcon();

  /// <summary>
  /// Returns the optional path to the local static files that should be served by the web plugin's url resource path.
  /// This folder should be relative to the mod's DLL location.
  /// </summary>
  string? GetStaticFilesPath();

  /// <summary>Returns the optional namespace of the embedded DLL resources that should be served by the web plugin's url resource path.</summary>
  string? GetEmbeddedResourceNamespace();
}
