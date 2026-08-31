// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Disasters.MeteorObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Disasters;

public class MeteorObject : INetObject, IController, IViewController, IHasUniversalID
{
  public static ThreadSafeAction<bool> MeteorStateChangedEvent { get; }

  public static ThreadSafeAction MeteorShotDownEvent { get; }

  public static ThreadSafeAction MeteorImpactedEvent { get; }

  public static ThreadSafeAction MeteorTimeUpdatedEvent { get; }

  [SyncToView(null, true)]
  public bool Targetable { get; set; }

  [SyncToView(null, true)]
  public double TimeOffset { get; set; }

  [SyncToView(null, true)]
  public float OffsetDegrees { get; set; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public Vector3 Position { get; }

  public void Tick();

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ShootMeteor();

  public void Impact();

  public void BeginFalling();

  public void Reset();

  public void ResetRotation(float offset = 300f);

  public void ReceiveInitialState(BSONObject bsonObj);

  public void ReceiveUpdate(BSONObject bsonObj);

  public ref int ControllerID { get; }

  /// <summary>Updates the currently set impact time for the meteor.</summary>
  public void UpdateImpactTime();
}
