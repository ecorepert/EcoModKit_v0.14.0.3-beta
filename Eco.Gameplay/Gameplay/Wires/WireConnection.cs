// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Wires.WireConnection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Pipes;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Wires;

public class WireConnection : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public const float MinFlow = 0.001f;
  public static readonly 
  #nullable disable
  ThreadSafeAction<WireConnection> OwnerRenamedEvent;

  public event Action OnConnectionChange;

  public event Action OnFlowRateChanged;

  [WatchSubMember("Name", "RaiseOwnerRenamedEvent", SubPropWatcherFlag.None)]
  public WorldObject Owner { get; protected set; }

  public Ray Ray { get; }

  protected Flow Flow { get; }

  public Type ConnectionBlockType { get; }

  [SyncToView(null, true)]
  public string Name { get; protected set; }

  [SyncToView(null, true)]
  public bool IsDisconnected { get; }

  [SyncToView(null, true)]
  public ItemStack AverageFlow { get; }

  public float FlowPerSecond { get; }

  public float MaxFlowRate { get; set; }

  [SyncToView(null, true)]
  public string FlowDisplay { get; }

  public void UpdateFlowDisplay(string text);

  protected WireConnection(
    WorldObject owner,
    string name,
    Ray inputPosDirLocal,
    Type connectionType);

  protected IEnumerable<WireConnection> Wires { get; }

  ~WireConnection();

  public void AddWire(WireConnection wire);

  public void AddWires(IEnumerable<WireConnection> wires);

  public void RemoveWire(WireConnection wire, bool removeReverse = true);

  public void ClearWires();

  public void TrackFlow(PipePayload payload);

  public void ResetFlow();

  public virtual void UpdateStatus(double deltaTime);

  protected virtual Type IdleDisplayType { get; }

  protected virtual void RecalculateFlows(double timePassed);

  public override string ToString();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public virtual LocString WireConnectionTooltip { get; }

  public string ShortDesc { get; }

  public virtual void UpdateIfNeeded();

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public void UpdateRayPosition(Ray inputPosDirLocal);

  public void UpdateName(string name);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
