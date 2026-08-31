// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Minimap.IMinimapObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Shared.View;
using System;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Minimap;

/// <summary>Represents an object that can be displayed on the minimap.</summary>
[ForceCreateView]
public interface IMinimapObject : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [SyncToView(null, true)]
  int TargetViewID { get; }

  [SyncToView(null, true)]
  int TargetNetworkID { get; }

  [SyncToView(null, true)]
  string DependantOverlayName { get; }

  [SyncToView(null, true)]
  string IconNameOverride { get; }

  [SyncToView(null, true)]
  Type Type { get; }

  [SyncToView(null, true)]
  Vector3 Position { get; }

  [SyncToView(null, true)]
  Vector3 Scale { get; }

  [SyncToView(null, true)]
  float Rotation { get; }

  [SyncToView(null, true)]
  string DisplayName { get; }

  [SyncToView(null, true)]
  string DisplayObjectCategory { get; }

  [SyncToView(null, true)]
  string DisplayObjectCategoryId { get; }

  [SyncToView(null, true)]
  string SubTitle { get; }

  [SyncToView(null, true)]
  bool IsOverlayObject { get; }

  [SyncToView(null, true)]
  User Creator { get; }

  [SyncToView(null, true)]
  bool CanMove { get; }

  [SyncToView(null, true)]
  bool CanChangeText { get; }

  [SyncToView(null, true)]
  bool IsVisibleOnMinimap { get; }

  [SyncToView(null, true)]
  IMinimapObject OverrideTarget { get; }

  [SyncToView(null, true)]
  ControllerHashSet<IAlias> HasAccess { get; }

  [SyncToView(null, true)]
  IAlias Owner { get; }
}
