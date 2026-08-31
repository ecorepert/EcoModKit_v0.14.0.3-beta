// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.BlockOccupancyType
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Occupancy;

/// <summary>Special block occupancy that is used by world object for many purpose.
/// Specify this in world object prefab for autogenerate or at static world object constructor (see WaterwheelObject)</summary>
public enum BlockOccupancyType
{
  None,
  ChimneyOut,
  WaterInputPort,
  SewageOutputPort,
  InputPort,
  OutputPort,
  CustomSurfaceAttachment,
  WaterOut,
  OilInputPort,
}
