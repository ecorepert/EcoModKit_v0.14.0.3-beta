// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.WorldMarker.WorldMarker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Items;
using Eco.Gameplay.Minimap;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.UI;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.ComponentModel;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.UI.WorldMarker;

[Serialized]
public class WorldMarker : 
  IMinimapObject,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IMinimapCategorizedOption,
  IMinimapOption,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IHasTeleportOption
{
  [Serialized]
  public bool Temp;
  [Serialized]
  public bool GroupComposedWorldMarker;

  [SyncToView(null, true)]
  public string Name { get; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string DisplayName { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string DisplayObjectCategory { get; set; }

  [SyncToView(null, true)]
  public string DisplayObjectCategoryId { get; }

  /// <summary>Sets the category's localized label and its untranslated key together.</summary>
  public void SetCategory(LocString category);

  [Serialized]
  [SyncToView(null, true)]
  public string SubTitle { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public bool IsTutorialMarker { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Text { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Vector3i Pos { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Color Color { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool DisplayOffScreen { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool DisplayText { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool DisplayDistance { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float MaxDistanceToShow { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Settlement? Settlement { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string? FolderStructure { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string? UserDefinedFolderStructure { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public WorkOrder? WorkOrder { get; }

  [SyncToView(null, true)]
  public int TargetViewID { get; }

  [SyncToView(null, true)]
  public int TargetNetworkID { get; }

  [SyncToView(null, true)]
  public Type Type { get; }

  [SyncToView(null, true)]
  public string DependantOverlayName { get; }

  [SyncToView(null, true)]
  public string IconNameOverride { get; }

  [SyncToView(null, true)]
  public Vector3 Position { get; }

  [SyncToView(null, true)]
  public Vector3 Scale { get; }

  [SyncToView(null, true)]
  public float Rotation { get; }

  [SyncToView(null, true)]
  public bool IsOverlayObject { get; }

  [SyncToView(null, true)]
  public IAlias? Owner { get; }

  [SyncToView(null, true)]
  public User? Creator { get; }

  [SyncToView(null, true)]
  public bool CanMove { get; }

  [SyncToView(null, true)]
  public bool CanChangeText { get; }

  [SyncToView(null, true)]
  public IMinimapObject OverrideTarget { get; }

  [SyncToView(null, true)]
  public bool IsVisibleOnMinimap { get; set; }

  [SyncToView(null, true)]
  public float Priority { get; }

  [SyncToView(null, true)]
  public bool IsOnByDefault { get; }

  [SyncToView(null, true)]
  public ControllerHashSet<IAlias>? HasAccess { get; }

  public LocString TooltipTile { get; }

  protected WorldMarker();

  public WorldMarker(Vector3i pos, string text);

  /// <summary> Use the given <see cref="T:Eco.Gameplay.UI.WorldMarker.WorldMarkerVisibility" /> value to determine if the <see cref="T:Eco.Gameplay.UI.WorldMarker.WorldMarker" /> should be shown on the minimap or not, can be extended to provide options to show in World or not too.</summary>
  public void SetVisiblity(WorldMarkerVisibility visibility);

  public void SetTextNoParse(string text);

  [RPC]
  public void SetPos(Player player, Vector3i pos);

  [RPC]
  public void SetColor(Player player, Color color);

  [RPC]
  public void SetDisplayOffScreen(Player? player, bool b);

  [RPC]
  public void SetDisplayText(Player player, bool b);

  [RPC]
  public void SetDisplayDistance(Player? player, bool b);

  [RPC]
  public void SetMaxDistanceToShow(Player player, float v);

  [RPC]
  public void SetDisplayName(Player player, string text);

  [RPC]
  public void SetUserDefinedFolderStructure(Player player, string folder);

  public bool CheckPermissions(Player? player);

  /// <summary>Set the new settlement and return true if it succeeded and was changed.</summary>
  [RPC]
  public bool SetSettlement(User user, Settlement? newSettlement);

  [RPC]
  public void CopyToClipboard(Player player);

  [RPC]
  public void Remove(Player player);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler? PropertyChanged;

  public void SetWorkOrder(Player player, WorkOrder order);

  public ref ThreadSafeSubscriptions? Subscriptions { get; }
}
