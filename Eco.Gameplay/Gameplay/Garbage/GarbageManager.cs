// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbageManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Threading;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>  Responsible for ticking Garbage inventories (when an item is thrown as garbage out of player inventory), once an item is spoiled it gets depleted and turned into waste. </summary>
[Serialized]
public class GarbageManager : Singleton<GarbageManager>, ISimplePluginData, IStorage, ISerializable
{
  public static AutoResetEvent Reset;
  [Serialized]
  public double PreviousWorldTime;

  public static BasicSimulation Simulation { get; }

  [Serialized]
  public ThreadSafeDictionary<Vector3i, DecayingInventory> Inventories { get; set; }

  IPersistent IStorage.StorageHandle { get; set; }

  public void OnCreate();

  public void Initialize();

  public void RegisterDecayingInventory(Vector3i pos, DecayingInventory inv);

  public void RemoveDecayingInventory(Vector3i pos);

  public int Tick();

  public string GetCategory();

  public string GetStatus();

  public string GetDisplayText();

  public override string ToString();

  public void OnLoaded();
}
