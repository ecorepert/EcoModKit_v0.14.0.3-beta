// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.InitialSpawn.SpawnPoint
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Systems.InitialSpawn;

[Serialized]
public struct SpawnPoint
{
  public SpawnPoint();

  public bool Enabled { get; set; }

  public Vector3i Position { get; set; }

  public string Name { get; set; }

  public string Description { get; set; }

  public string Color { get; set; }

  public float Priority { get; set; }
}
