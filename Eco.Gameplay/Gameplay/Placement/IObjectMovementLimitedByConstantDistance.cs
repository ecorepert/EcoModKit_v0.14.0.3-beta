// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.IObjectMovementLimitedByConstantDistance
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Placement;

/// <summary>We implement this interface to a world object when we don't want it to be moved very far away from a specified position (I.E settlement foundations from their founding position).</summary>
[ForceCreateView]
public interface IObjectMovementLimitedByConstantDistance : 
  IController,
  IViewController,
  IHasUniversalID
{
  [ClientInterfaceProperty]
  bool IgnoreHeightMovement { get; }

  [ClientInterfaceProperty]
  bool MovementLimiterEnabled { get; }

  [ClientInterfaceProperty]
  Vector3 ConstantPositionToTrack { get; }

  [ClientInterfaceProperty]
  int MaxDistanceFromSpecifiedPosition { get; }
}
