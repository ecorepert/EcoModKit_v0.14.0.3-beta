// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.ICustomUIPlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

/// <summary>Interface for a plugin to show a custom UI tab.</summary>
public interface ICustomUIPlugin : IGUIPlugin, IServerPlugin
{
  /// <summary>
  /// Return a Control that will be displayed in the tab. If the plugin is also a ITabPage it will get tab page enter/leave events.
  /// </summary>
  /// <returns>A Control</returns>
  object GetCustomUIControl();

  /// <summary>The name of the tab.</summary>
  string GetCustomUIName();
}
