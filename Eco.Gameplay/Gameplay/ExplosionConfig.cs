// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.ExplosionConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay;

/// <summary> Data configuration struct for explosion component </summary>
[Serialized]
public struct ExplosionConfig
{
  public BlockFallConfig BlockFallConfig;

  /// <summary> Radius of inner explosion (Blocks in this radius will be moved outside to form a hole)</summary>
  public int CraterRadius { get; set; }

  /// <summary> Radius to create block conversion and other interactions(outer range, used to determine block conversion impact, like stone to crushed) </summary>
  public int ExplosionRadius { get; set; }

  public float FuseTime { get; set; }

  public float PollutionTons { get; set; }

  public float CaloriesBurn { get; set; }

  public bool LightOtherFusesOnExplosion { get; set; }

  public bool DestroyRubbles { get; set; }

  public float GarbageEfficiency { get; set; }

  public ExplosionConfig();
}
