// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.PropertyData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.Voxel;
using System;

#nullable disable
namespace Eco.Gameplay.Property;

[Serialized]
public class PropertyData : IStorage, ISerializable
{
  [Serialized]
  public Registrar<Deed> DeedRegistrar;

  [Serialized]
  public ThreadSafeDictionary<PlotPos, PropertyPlot> PlotPosToProperty { get; }

  public IPersistent StorageHandle { get; set; }

  public double LastUpdatedTime { get; }

  public static event Action OnDirty;

  public void MarkDirty();

  public void Initialize();
}
