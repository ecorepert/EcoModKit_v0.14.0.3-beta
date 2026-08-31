// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.InitialSpawn.ISpawnPositionOffset
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Systems.InitialSpawn;

/// <summary>Implementing this interface in a world object means that when the object is chosen for player spawning, the spawn position will be this offset + world object position.</summary>
public interface ISpawnPositionOffset
{
  /// <summary>The x axis will offset the position using the right vector and y axis will offset it using the forward vector.</summary>
  Vector2i SpawnPositionOffset { get; }
}
