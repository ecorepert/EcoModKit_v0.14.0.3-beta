// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.PluginPriorities
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Plugins;

/// <summary>This determines the initialization order of plugins.</summary>
public static class PluginPriorities
{
  public const int WorldGenerator = -3;
  public const int WorldLayerManager = -2;
  public const int Settlement = -1;
  public const int WorldObjectManager = 0;
  public const int Rooms = 1;
  public const int Spoilage = 2;
}
