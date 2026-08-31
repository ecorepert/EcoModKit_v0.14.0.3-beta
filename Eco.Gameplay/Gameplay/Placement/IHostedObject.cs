// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.IHostedObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Math;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Placement;

/// <summary>Add this interface when an object can't exist without a host object. IE. for a more detailed example see <see cref="T:Eco.Gameplay.Civics.Misc.IProposable" /> and <see cref="T:Eco.Gameplay.Civics.Misc.SimpleProposable" />.</summary>
public interface IHostedObject : 
  ILinkable,
  INamed,
  IController,
  IViewController,
  IHasUniversalID,
  IHasTeleportOption,
  IHasSerializableID
{
  WorldObjectHandle HostObject { get; }

  bool ScanPeriodically { get; set; }

  bool IsActive { get; }

  bool WasRemoved { get; }

  bool RequiresHost { get; }

  double LastValidTime { get; set; }

  User Creator { get; set; }

  Settlement HostingSettlement { get; }

  int ExpirationWarningsIssued { get; set; }

  void DisableHostedObject();

  void ReenableHostedObject();

  /// <summary>We assign the hosted object to its new host while at the same time updating what's needed.</summary>
  void AssignHostObject(WorldObject newHost);

  /// <summary>We check whether this hosted object can be assigned to the new container or not.</summary>
  bool CanBeAssignedTo(IOrphanAssignment newContainer);

  bool CanBeEdited { get; set; }

  bool IHasTeleportOption.CanTeleport { get; }

  Vector3i IHasTeleportOption.Pos { get; }
}
