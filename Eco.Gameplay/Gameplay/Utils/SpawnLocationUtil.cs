// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.SpawnLocationUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using Eco.Simulation.Time;

#nullable disable
namespace Eco.Gameplay.Utils;

public class SpawnLocationUtil
{
  public static PeriodicUpdateConfig NearbyFoodUpdate;

  public static bool TryGetNearestGround(Vector3i start, out Vector3i ground);

  public static void UpdateSpawnLocation();
}
