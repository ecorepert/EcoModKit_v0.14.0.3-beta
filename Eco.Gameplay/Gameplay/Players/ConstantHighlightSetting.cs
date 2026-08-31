// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.ConstantHighlightSetting
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Networking;
using Eco.Shared.View;
using Priority_Queue;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>Syncs which Objects need to be highlighted. Every <see cref="T:Eco.Gameplay.Players.User" /> now has this. So any
/// object that must be constantly highlighted on the user's client, must be added through <see cref="M:Eco.Gameplay.Players.ConstantHighlightSetting.TryAddOrUpdate(Eco.Shared.Networking.INetObjectPosition,Eco.Gameplay.Players.HighlightPurpose,System.Double)" /> giving the objects that implements
/// <see cref="T:Eco.Shared.Networking.INetObjectPosition" />, purpose <see cref="T:Eco.Gameplay.Players.HighlightPurpose" /> for the objects to be differed what for they are added, and time for highlighting
/// (this could be set to infinite). There is <see cref="M:Eco.Gameplay.Players.ConstantHighlightSetting.TryRemove(Eco.Shared.Networking.INetObjectPosition,Eco.Gameplay.Players.HighlightPurpose)" /> if you know what you need to remove and <see cref="M:Eco.Gameplay.Players.ConstantHighlightSetting.TryRemoveByFunc(System.Func{Priority_Queue.SimplePriorityQueue{Eco.Gameplay.Players.ConstantHighlightInfo,System.Double},Eco.Gameplay.Players.User,System.Collections.Generic.IEnumerable{Eco.Gameplay.Players.ConstantHighlightInfo}})" /> if you need to remove objects
/// from highlight by some rules or checks, gives ability to remove a collection of objects.
/// 
/// Now used only for MasterTracker talent. This by event gets user and through the user adds(TryAddOrUpdate) here an object(animal) with time limit -
/// this will trigger an update for client. And would be immediately highlighted. After this due to limitations for this talent it checks objects for deletion
/// through TryRemoveByFunc, this would also trigger an update for client to immediately remove highlight for client. All removals passed to private TryRemove method
/// to make a proper deletion. Do not change objsToHighlight collection by hand.</summary>
public class ConstantHighlightSetting : IController, IViewController, IHasUniversalID
{
  /// <summary>Raised for every object that removed from highlight both by time or removed by hand. </summary>
  public readonly ThreadSafeAction<ConstantHighlightSetting, ConstantHighlightInfo> ObjectRemoved;

  /// <summary> This dictionary sends to client ids of objects to highlight as key</summary>
  [SyncToView(null, true)]
  public List<int> IDsObjectToHighLight { get; }

  public ConstantHighlightSetting(User owner);

  /// <summary> Adding Object to <see cref="T:Priority_Queue.SimplePriorityQueue`2" />. Use zero or less as infinite time to highlight. And populates to client</summary>
  public bool TryAddOrUpdate(
    INetObjectPosition obj,
    HighlightPurpose highlightPurpose,
    double timeToHighlight);

  /// <summary>Removes Object from highlight and from dict with timers.</summary>
  public bool TryRemove(INetObjectPosition obj, HighlightPurpose highlightPurpose);

  public bool TryRemoveByFunc(
    Func<SimplePriorityQueue<ConstantHighlightInfo, double>, User, IEnumerable<ConstantHighlightInfo>> removeCall);

  /// <summary>Removes all entities expired by time. If time set to 0 or lower are not removed by this method. </summary>
  public void ClearExpired();

  public ref int ControllerID { get; }
}
