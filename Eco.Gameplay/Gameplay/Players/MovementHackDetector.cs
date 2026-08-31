// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.MovementHackDetector
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>Detects player movement cheats (teleport or speed hacks). Tuned to ignore the noise band where legitimate
/// jitter / knockback / dismount-in-air lives, and only flag the whole-world teleports cheaters actually use.</summary>
public class MovementHackDetector
{
  public Vector3 LatestValidPosition;

  public MovementHackDetector.Waypoint? PrevWaypoint { get; }

  public bool AddWaypoint(Vector3 position, float velocity, double time, out float distance);

  /// <summary>Clears waypoint info. I.e. if you get admin rights and should ignore abnormal movement until admin mode disabled.</summary>
  public void Clear();

  /// <summary>Stores waypoint info for hack detection.</summary>
  public struct Waypoint
  {
    public Vector3 Position { get; init; }

    public double Time { get; init; }

    public float Velocity { get; set; }
  }
}
