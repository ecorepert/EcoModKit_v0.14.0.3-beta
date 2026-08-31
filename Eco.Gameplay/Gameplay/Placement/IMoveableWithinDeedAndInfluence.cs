// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.IMoveableWithinDeedAndInfluence
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Shared.Localization;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Placement;

/// <summary> Plug'n'Play movement restriction for WorldObjects that can not be moved outside their deed with the 'MoveWorldObject' action, or outside the influence of the associated settlement. </summary>
/// <remarks> Implement on the affected WorldObject directly. Fail message can be altered per implementing class to better suit its needs. </remarks>
public interface IMoveableWithinDeedAndInfluence : IMoveableWithRestrictions
{
  Deed OriginalDeed { get; }

  LocString MovementFailMessage { get; }

  Result IMoveableWithRestrictions.CanMove(WorldObject worldObject, Vector3 targetPosition);
}
