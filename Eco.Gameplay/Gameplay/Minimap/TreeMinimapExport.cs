// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Minimap.TreeMinimapExport
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Minimap;

[Serialized]
public sealed class TreeMinimapExport
{
  [Serialized]
  public string ExportedAtUtc { get; set; }

  [Serialized]
  public int Count { get; set; }

  [Serialized]
  public string WorldSeed { get; set; }

  [Serialized]
  [ThreadSafe]
  public List<TreeMinimapExportEntry> Items { get; set; }
}
