// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.VehicleTreeHarvestComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Components;

[Category("Hidden")]
[Serialized]
[ForceCreateView]
[NoIcon]
public class VehicleTreeHarvestComponent : WorldObjectComponent, INetObject
{
  public List<ScorpionTrunkSyncData> CurrentSyncedTrunks;
  public bool DisableBasicToolSync;

  public override WorldObjectComponentClientAvailability Availability { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  [Serialized]
  public Vector3[] RotationPartSync { get; }

  [Serialized]
  public float[] ToolAngles { get; }

  [SyncToView(null, true)]
  public List<string> AllowedSpecies { get; set; }

  [RPC]
  public void StartMainRollers();

  [RPC]
  public void BranchCut();

  [RPC]
  public void SawCut();

  [RPC]
  public void TreeLeavesEffect(float density);

  [RPC]
  public void DoClawLogRotators(int dir, float speed, float duration, bool isFirstRoll);

  [RPC]
  public void ClawsState(bool state);

  public void ProcessTree();

  public void TreeCutFail(LocString resultMessage);

  public void Initialize(string[] disallowedSpecies);

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  public void ReceiveInitialState(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);
}
