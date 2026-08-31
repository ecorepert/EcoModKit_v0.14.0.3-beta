// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IServerPlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

/// <summary>Base interface for all server plugins.</summary>
public interface IServerPlugin
{
  /// <summary>Returns the current status string for displaying in the Server's console.</summary>
  string GetStatus();

  /// <summary>Returns the category string associated with this plugin. Used in Server UI sorting.</summary>
  string GetCategory();
}
