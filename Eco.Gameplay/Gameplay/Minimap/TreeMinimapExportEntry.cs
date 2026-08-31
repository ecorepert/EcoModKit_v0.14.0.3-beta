// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Minimap.TreeMinimapExportEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Minimap;

[Serialized]
public sealed class TreeMinimapExportEntry
{
  [Serialized]
  public string SpeciesType { get; set; }

  [Serialized]
  public Vector3 Position { get; set; }

  [Serialized]
  public Vector3 Scale { get; set; }

  [Serialized]
  public string DisplayName { get; set; }

  [Serialized]
  public string DisplayObjectCategory { get; set; }
}
