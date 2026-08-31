// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.PropertyPlotHandle
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using Eco.Shared.Voxel;

#nullable disable
namespace Eco.Gameplay.Property;

[Serialized]
public struct PropertyPlotHandle : IOwnableHandle
{
  /// <summary>NOTE: This is the position in WORLD SPACE, not plot grid</summary>
  [Serialized]
  public readonly PlotPos PlotPos { get; }

  public PropertyPlot Plot { get; }

  public PropertyPlotHandle(PlotPos plotPos);

  IDeedOwned IOwnableHandle.OwnedObject { get; }
}
