// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.Room
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Housing.PropertyValues.Internal;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Rooms;

[Serialized]
public class Room : 
  IController,
  IViewController,
  IHasUniversalID,
  ILinkable,
  IAtmosphereContainer,
  IHasSerializableID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Serialized]
  public Vector3i SerializationSeedPos;
  public const float GasConstant = 287f;
  public const float NSMToPSI = 0.000145038f;

  public static int NextId { get; }

  public event 
  #nullable disable
  PropertyChangedEventHandler PropertyChanged;

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  [Notify]
  public RoomStats RoomStats { get; }

  [Notify]
  public RoomValue RoomValue { get; }

  [Notify]
  public Deed RoomDeed { get; }

  [Notify]
  public LocString StatusBarDisplay { get; set; }

  [SyncToView(null, true)]
  public bool Contained { get; }

  [SyncToView(null, true)]
  public bool IsOutdoor { get; }

  [SyncToView(null, true)]
  public int BlocksVolume { get; }

  [SyncToView(null, true)]
  public int Id { get; }

  public WrappedWorldPosition3i SeedPos { get; }

  public Room();

  public Room(WrappedWorldPosition3i pos);

  public void SetOutdoor(Deed deed);

  public bool Valid { get; }

  public bool Removed { get; set; }

  public void ScanRoomAndUpdate(bool rescanBlocks);

  public void ReevaluateDeedAndValue();

  public void UpdateRoomValue();

  public void UpdateStatusBarDisplay(float valueAdjustedToDiminish, LocString diminishDescription);

  public bool IsWindow(WrappedWorldPosition3i pos);

  public bool TryGetStoredWindowSides(
    WrappedWorldPosition3i pos,
    out WrappedWorldPosition3i side1,
    out WrappedWorldPosition3i side2);

  public void OnDestroy();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  public ref int ControllerID { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Atmosphere Atmosphere { get; set; }

  public override string ToString();

  public void MakeBreathable();

  public void MatchAtmosphere(Room room);

  [SyncToView(null, true)]
  [DependsOn("Atmosphere", new string[] {"RoomStats"})]
  public double Pressure { get; }

  public double Volume { get; }
}
