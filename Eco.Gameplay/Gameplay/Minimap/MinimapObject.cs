// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Minimap.MinimapObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Minimap;

/// <summary>Straight implementation of the IMinimapObject interface, used to allow objects to make use of minimap icons separate from themselves (IE, when we want
/// to share a minimap object without syncing the entire object, like with trees/world objects).</summary>
public class MinimapObject : 
  IMinimapObject,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public const float OriginalPositionWeight = 0.2f;
  public const float SqDistanceForUpdate = 1f;
  public const float RotationForUpdate = 5f;

  [SyncToView(null, true)]
  public int TargetViewID { get; set; }

  [SyncToView(null, true)]
  public int TargetNetworkID { get; set; }

  [SyncToView(null, true)]
  public string DependantOverlayName { get; set; }

  [SyncToView(null, true)]
  public string IconNameOverride { get; set; }

  [SyncToView(null, true)]
  public Type Type { get; set; }

  [SyncToView(null, true)]
  public Vector3 Scale { get; set; }

  [SyncToView(null, true)]
  public string DisplayName { get; set; }

  [SyncToView(null, true)]
  public string DisplayObjectCategory { get; set; }

  [SyncToView(null, true)]
  public string DisplayObjectCategoryId { get; set; }

  /// <summary>Sets the category's localized label and its untranslated key together. Prefer this over assigning the properties by hand so the key can't drift from the label.</summary>
  public void SetCategory(LocString category);

  [SyncToView(null, true)]
  public string SubTitle { get; set; }

  [SyncToView(null, true)]
  public bool IsOverlayObject { get; set; }

  [SyncToView(null, true)]
  public User Creator { get; set; }

  [SyncToView(null, true)]
  public bool CanMove { get; set; }

  [SyncToView(null, true)]
  public bool CanChangeText { get; set; }

  [SyncToView(null, true)]
  public IMinimapObject OverrideTarget { get; set; }

  [SyncToView(null, true)]
  public bool IsVisibleOnMinimap { get; set; }

  [SyncToView(null, true)]
  public ControllerHashSet<IAlias> HasAccess { get; set; }

  [SyncToView(null, true)]
  public IAlias Owner { get; set; }

  [SyncToView(null, true, Flags = SyncFlags.UnreliableChangeNotification)]
  public Vector3 Position { get; set; }

  [SyncToView(null, true, Flags = SyncFlags.UnreliableChangeNotification)]
  public float Rotation { get; set; }

  public void CalculateTopGroundPosition(Vector3 position);

  /// <summary> Prevents excessive updates of minimap icons. Position/rotation only update after the periodic throttle when they moved beyond <see cref="F:Eco.Gameplay.Minimap.MinimapObject.SqDistanceForUpdate" />/<see cref="F:Eco.Gameplay.Minimap.MinimapObject.RotationForUpdate" />. </summary>
  public void UpdatePosition(Vector3 position, float? rotation = null);

  public MinimapObject();

  /// <summary>Seeds backing fields directly to avoid PropertyChanged fan-out during bulk world-load registration.
  /// Post-construction property writes go through the normal setters and notify clients as usual.</summary>
  public MinimapObject(
    Type type,
    Vector3 position,
    Vector3 scale,
    string displayName,
    LocString displayObjectCategory);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
