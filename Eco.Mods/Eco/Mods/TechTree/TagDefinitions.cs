// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TagDefinitions
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Plugins.Interfaces;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary> Contains all <see cref="T:Eco.Gameplay.Items.TagDefinition" /> for Mods. </summary>
public class TagDefinitions : IModInit
{
  /// <summary> Called on Mods initialization for the marker interface <see cref="T:Eco.Core.Plugins.Interfaces.IModInit" />. Registers all <see cref="T:Eco.Gameplay.Items.TagDefinition" /> from <see cref="F:Eco.Mods.TechTree.TagDefinitions.Definitions" />. </summary>
  public static void Initialize();
}
