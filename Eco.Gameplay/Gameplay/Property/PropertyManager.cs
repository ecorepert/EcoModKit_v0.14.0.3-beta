// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.PropertyManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Gameplay;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.UI;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Property;

[LocDisplayName("PropertyManager")]
public class PropertyManager : 
  Singleton<
  #nullable disable
  PropertyManager>,
  IContainsRegistrars,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  ISaveablePlugin,
  IInitializablePlugin,
  IController,
  IViewController,
  IHasUniversalID,
  IMapEntryOverlay,
  IMinimapOption,
  IMinimapCategorizedOption,
  IWorkerPlugin,
  INotifyPropertyChanged,
  IThreadedPlugin,
  IShutdownablePlugin
{
  public static ThreadSafeAction<bool, Deed, User> PropertyClaimedOrUnclaimedEvent;
  public static ThreadSafeAction<Deed> PropertySettlementChanged;
  public static ThreadSafeAction<PropertyPlot> PropertyPlotCreatedEvent;
  public static ThreadSafeAction<Deed> DeedOwnerChangedEvent;
  public static ThreadSafeAction<Deed, User> DeedDestroyedEvent;
  public static Initializer Initializer;

  public event PropertyChangedEventHandler PropertyChanged;

  public PropertyValueManager PropertyValueManager { get; }

  public static PropertyData Data { get; }

  public Initializer DeedSettlementInitializer { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public List<Deed> Deeds { get; }

  [SyncToView(null, true)]
  public string FolderStructure { get; }

  [SyncToView(null, true)]
  public float Priority { get; }

  [SyncToView(null, true)]
  public bool IsOnByDefault { get; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public Dictionary<int, MapEntry> MapEntries { get; set; }

  [SyncToView(null, true)]
  public List<Deed> RentableDeeds { get; }

  [SyncToView(null, true)]
  public Array2D<int> Map { get; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  [DependsOnController("MarkedUpName", true)]
  public string OverlayName { get; }

  public ThreadSafeHashSet<Deed> OverburnedDeeds { get; }

  public static IEnumerable<Deed> GetAllDeeds();

  /// <summary>All deeds who have the specified user as part of the owners. This is a slow operation.</summary>
  public static IEnumerable<Deed> AllOwnedDeeds(User user);

  /// <summary>All deeds that are specifically owned by the specified alias. This is a slow operation.</summary>
  public static IEnumerable<Deed> AllDeedsOwnerIs(IAlias alias);

  public static Deed GetDeed(int deedId);

  public static Deed GetDeedWorldPos(Vector2i worldPos);

  public static int GetDeedID(Vector2i worldPos);

  public static Deed GetDeed(PlotPos plotPos);

  public static bool IsClaimed(PlotPos pos);

  public static PropertyPlot GetPlotFromPlotPos(PlotPos plotPos);

  public static PropertyPlot GetPlotFromWorldPos(Vector2i worldPos);

  public static PropertyPlot GetOrCreatePlotAtWorldPos(Vector2i worldPos);

  public static IEnumerable<PropertyPlot> PropertyForAlias(IAlias alias);

  public static IEnumerable<PropertyPlot> All();

  public static Result ForceRemoveDeed(Deed deed, Player performer = null);

  public static Result ForceRemoveDeed(Deed deed, User performer);

  public static Result TryRemoveDeed(Deed deed, Player performer = null);

  public static Result TryRemoveDeed(Deed deed, User performer);

  /// <summary>This removes the deed, when force parameter is true it forces the process avoiding prompts and laws.</summary>
  public static Result RemoveDeed(Deed deed, User performer, bool force);

  public override string ToString();

  public string GetCategory();

  public static IEnumerable<Deed> NearbyDeeds(User user, PlotPos plotPos, int range = 2);

  public static IEnumerable<Deed> AdjacentDeeds(User user, PlotPos plotPos);

  public static void ForceClaim(Deed deed, User actor, PlotPos plotPos, bool unclaimFirst = false);

  public static Deed DebugForceClaim(User actor, PlotPos plotPos);

  public static void SetClaimsAndUnclaims(
    Deed deed,
    User user,
    IEnumerable<PlotPos> toClaimPlotPos,
    IEnumerable<PlotPos> toUnclaimPlotPos,
    bool unclaimFirstToClaim = false);

  public static Result CreateUnclaimAction(
    User user,
    PlotPos plotPos,
    InventoryChangeSet userInventoryChanges,
    GameActionPack pack,
    bool spawnClaims = true,
    bool deleteDeedIfEmpty = true);

  public static Result TryUnclaim(
    GameActionPack pack,
    User user,
    Inventory propertyClaimInv,
    PlotPos plotPos,
    bool autoPerform = true,
    bool deleteDeedIfEmpty = true,
    bool spawnClaims = true);

  public static void ForceUnclaim(PlotPos plotPos, User user = null, bool deleteDeedIfEmpty = true);

  public static void ForceRemoveFromDeed(PropertyPlot plot);

  [RPC]
  public void TryClaimOrUnclaim(
    User user,
    List<PlotPos> unclaimPos,
    List<PlotPos> claimPos,
    Deed deed);

  public void MarkDirty();

  public void Run();

  public Task ShutdownAsync();

  public void ForceResolveOverburdened();

  public void InitializeRegistrars(TimedTask timer);

  public void Initialize(TimedTask timer);

  public void InitializeForSettlements();

  public void NotifyRentablesChanged();

  public void MarkSaveAllDirty();

  public void SetMapUpdateNeeded();

  public void SaveAll();

  public string GetDisplayText();

  public string GetStatus();

  public Task DoWork(CancellationToken token);

  public override void ClearSingleton();
}
