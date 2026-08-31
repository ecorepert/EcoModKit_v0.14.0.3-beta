// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.IMoveableWithRestrictions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Placement;

/// <summary> Interface for WorldObjects that have restrictions on the 'MoveWorldObject' action (e.g.: some WorldObjects should not be moved outside the influence of their settlement, or to another deed). </summary>
/// <remarks> Implement on WorldObjects directly. Automatically detected and invoked by WorldObjectManager.TryMoveWorldObject. </remarks>
public interface IMoveableWithRestrictions
{
  /// <summary> Determines whether the movement of a WorldObject can be performed or not. </summary>
  Result CanMove(WorldObject worldObject, Vector3 targetPosition);
}
