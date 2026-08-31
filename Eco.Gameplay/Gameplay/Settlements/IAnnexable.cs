// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.IAnnexable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>Something that can be annexed (settlement or homestead deed)</summary>
[ForceCreateView]
public interface IAnnexable : IController, IViewController, IHasUniversalID
{
  bool CanAnnex { get; }

  LocString TypeAndName { get; }

  LocString MarkedUpName { get; }

  Eco.Shared.Items.SettlementType? SettlementType { get; }

  LocString TypeDisplayName { get; }

  string Name { get; }

  WorldObjectHandle HostObject { get; }

  HashSet<PlotPos> PlotPosSet { get; }

  float ReductionPercentageForAnnexation { get; }

  float CultureTotal { get; }

  bool Founded { get; }

  Settlement Parent { get; }

  IEnumerable<User> Citizens();

  ThreadSafeDictionary<int, int> SettlementIDtoAnnexWarningIssued { get; set; }

  int SettlementTypeAsIndex { get; }

  /// <summary>True if the given settlement is a parent anywhere up the hierarchy</summary>
  bool HasAncestor(Settlement settlement);

  void Notify(LocString msg);

  float DistanceTo(Vector2i worldPos);
}
