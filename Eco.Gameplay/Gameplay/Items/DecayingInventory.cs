// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.DecayingInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using C5;
using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Simulation.Agents;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class DecayingInventory : 
  LimitedInventory,
  ITickable,
  IComparable,
  IPlayerUseTracking,
  IContributesMoveGameAction
{
  public const int DecayTime = 43200;
  [Serialized]
  public Vector3i Position;

  public ThreadSafeList<WeakReference> UsingPlayers { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int[] StartTimers { get; }

  [Serialized]
  [SyncToView(null, true)]
  public int[] EndTimers { get; }

  [Serialized]
  [ThreadSafe]
  public Dictionary<Type, int> PendingGarbageMils { get; set; }

  [Serialized]
  public bool Finalized { get; set; }

  [Serialized]
  public double NextTick { get; set; }

  public ItemStack FirstStack { get; }

  public IPriorityQueueHandle<ITickable> QueueHandle { get; set; }

  public void UpdateNextTickTime();

  public bool IsReady();

  public int CompareTo(object other);

  public float AverageDecay { get; }

  public double ClosestPercent { get; }

  public int NextUpdateWorldTime();

  protected DecayingInventory();

  public DecayingInventory(int numStacks, Vector3i pos);

  public DecayingInventory.GarbageBagMilsComponent MilsComponent { get; }

  protected override void Initialize();

  public GameAction MakeMoveGameAction(Type itemType, int delta, User user);

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();

  public void UpdateVisuals(User user = null);

  public void Tick();

  public void SetDecayTimer(int index, int start, int end);

  public void SetDecay(User user);

  public bool CheckFinalized(User user = null);

  public override void Destroy();

  public void OnUsingPlayersChange();

  public class GarbageBagMilsComponent : InventoryComponent
  {
    public int TotalMils { get; }

    public override void Initialize(Inventory inventory);

    public override void ApplyChange(Item item, int quantityDelta);

    public override void EndChangeSetModification(bool successful);
  }

  public class GarbageBagCapacityRestriction : InventoryRestriction
  {
    public override LocString Message { get; }

    public override int Priority { get; }

    public override RestrictionType Type { get; }

    public override RestrictionDescriptor Describe();

    public GarbageBagCapacityRestriction(DecayingInventory.GarbageBagMilsComponent mils);

    public override int MaxAccepted(RestrictionCheckData checkData, Item item, int currentQuantity);

    public override int MaxAccepted(Item item, int currentQuantity);
  }
}
