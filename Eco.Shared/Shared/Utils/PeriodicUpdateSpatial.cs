// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.PeriodicUpdateSpatial
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Numerics;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>Updates only when a position changes sufficiently or time has changed.</summary>
public class PeriodicUpdateSpatial : PeriodicUpdate
{
  public PeriodicUpdateSpatial(double time, float distance);

  public bool DoSpatialUpdate(Vector3 pos);
}
