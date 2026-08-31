// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Time.WorldTime
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Serialization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Time;
using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.Simulation.Time;

[Serialized]
public sealed class WorldTime : 
  Singleton<WorldTime>,
  INetObject,
  IStorage,
  ISerializable,
  INetObjectPriority
{
  public static readonly DateTime RealDateTimeAtLoad;
  /// <summary>Value of the sky lock meaning the sun keeps moving.</summary>
  public const float NoSkyLock = -1f;
  public bool AlwaysUpdateClientTime;

  public NetworkChannel UpdateChannel { get; }

  float INetObjectPriority.Priority { get; }

  public IPersistent StorageHandle { get; set; }

  public static double Seconds { get; }

  public static double GetSeconds(double realTime);

  public static double Day { get; }

  public static bool Paused { get; set; }

  public static float TimeOfDay { get; }

  /// <summary>Hour of the day every client draws its sky at. Offset from the world clock and optionally pinned. Persisted with the world.</summary>
  public static float SkyTimeOfDay { get; }

  public static bool IsSkyStopped { get; }

  /// <summary>Moves the sky to the given hour without touching the world clock. The sun goes on moving from there unless it is stopped.</summary>
  public static void SetSkyTimeOfDay(float hour);

  /// <summary>Stops the sun where it currently is.</summary>
  public static void StopSky();

  /// <summary>Starts the sun moving again from where it was stopped, so the sky doesn't jump.</summary>
  public static void StartSky();

  /// <summary>Drops both the offset and the pin, putting the sky back on the world clock.</summary>
  public static void ResetSky();

  /// <summary>Pushes a sky change to a single player, on top of the shared sky. Same ops as the shared /time, but purely visual and transient: not stored, not shared, dropped on reconnect or on any real change to the shared sky.</summary>
  public static void ApplyLocalSky(INetClient client, SkyOp op, float hour);

  public static bool IsNight();

  public int ID { get; }

  public bool Active { get; set; }

  public double NetObjectCreationRealtime { get; set; }

  public static Singleton<WorldTime>.Temp TempWorldTime();

  public static void WithTempWorldTime(Action action);

  public static void TimeChanged();

  public static double FromRealTime(double realTime);

  public static void Reset();

  public static void ResetOffset();

  public static void ForceAdvanceTime(double val);

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public static string Till(double sec);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public void ReceiveInitialState(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();
}
