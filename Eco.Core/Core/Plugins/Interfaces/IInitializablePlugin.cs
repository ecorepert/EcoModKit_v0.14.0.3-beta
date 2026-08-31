// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IInitializablePlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Utils;

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

public interface IInitializablePlugin : IServerPlugin
{
  /// <summary>Called by the <seealso cref="T:Eco.Core.PluginManager" /> to initialize the <seealso cref="T:Eco.Core.Plugins.Interfaces.IServerPlugin" /> instance.</summary>
  /// &gt;
  void Initialize(TimedTask timer);
}
