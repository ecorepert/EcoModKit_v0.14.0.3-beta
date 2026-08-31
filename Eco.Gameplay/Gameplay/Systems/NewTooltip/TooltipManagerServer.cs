// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipManagerServer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>
/// Handles constructing tooltips from a set of tooltip parts for controllers, using caching to prevent duplicate
/// queries, and error detection to detect non-dirted parts, etc. See Tooltip.md for a full description.
/// </summary>
/// <remarks>See 'Tooltip.md' for more info.</remarks>
[ChatCommandHandler]
[ConstantView]
public class TooltipManagerServer : 
  Singleton<
  #nullable disable
  TooltipManagerServer>,
  IController,
  IViewController,
  IHasUniversalID
{
  /// <summary>Number of seconds between applying cache updates from <see cref="F:Eco.Gameplay.Systems.NewTooltip.TooltipSubscriptions.queuedDirty" />.</summary>
  public const float CacheRefreshRate = 5f;
  /// <summary>Number of seconds between scans of tooltip cache taht remove entries that reference objects that were already garbage collected.</summary>
  public static readonly double CacheCleanupRate;

  public Dictionary<Type, List<TooltipPart>> TypeToParts { get; }

  public Dictionary<Type, List<TooltipChildrenPart>> TypeToChildrenParts { get; }

  public Dictionary<(Type Type, string FuncName), TooltipPartBase> NameToPart { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public Dictionary<Type, List<TooltipPart>> ClientTypeToParts { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public Dictionary<Type, List<TooltipChildrenPart>> ClientTypeToTooltipChildren { get; }

  /// <summary> Using reflection in default constructor to find all the members tagged with the NewTooltipAttribute and register them for the types that they apply to. </summary>
  public TooltipManagerServer();

  public static Task PrepareCache();

  /// <param name="controllerClasses">Represents collection of classes that derived from IController. This collection will be scanned for tooltip parts to register. </param>
  /// <param name="tooltipLibraries">Represents collection of tooltip libraries (classes with 'TooltipLibrary' attribute). This collection will be scanned for tooltip parts to register. </param>
  public TooltipManagerServer(
    IEnumerable<Type> controllerClasses,
    IEnumerable<Type> tooltipLibraries);

  public void Initialize();

  /// <summary>Removes all cached data in ourselves and children support classes.</summary>
  public void ClearCache();

  /// <summary>
  /// Returns tooltip parts for controller referenced by passed link. May be used for late bounded links for objects which isn't persistent or doesn't have serialized universal ID.
  /// When requested returns <see cref="T:Eco.Shared.Items.TooltipServerResponse" /> with all necessary information for tooltip rendering and caching on client side.
  /// Client then will have resolved Universal ID and type info for that link id and will use <see cref="M:Eco.Gameplay.Systems.NewTooltip.TooltipManagerServer.GetTooltipParts(Eco.Gameplay.Players.User,Eco.Shared.Items.TooltipServerRequest,Eco.Shared.Items.TooltipOrigin,Eco.Shared.Items.TTCat)" /> for further requests using link id only for initial tooltip content request.
  /// </summary>
  [RPC]
  public BSONObject GetTooltipPartsByLinkId(
    Player player,
    string linkId,
    TooltipOrigin origin,
    TTCat exclusions);

  [RPC]
  public TooltipServerResponse GetTooltipParts(
    User user,
    TooltipServerRequest request,
    TooltipOrigin origin,
    TTCat exclusions);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
