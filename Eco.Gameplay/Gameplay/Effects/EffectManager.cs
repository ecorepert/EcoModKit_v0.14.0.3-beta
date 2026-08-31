// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Effects.EffectManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Effects;

public class EffectManager : Singleton<EffectManager>, INetObject
{
  public static void SpawnEffect(string effectName, Vector3 pos, Vector3 faceDir);

  public static void XPEffect(
    User receivingUser,
    Type skillType,
    float amount,
    float mult,
    LocString desc);

  public static void LevelUpEffect(
    User receivingUser,
    Type skillType,
    SkillTree skillTree,
    bool isLearned = false);

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public int ID { get; }

  public void Destroy();

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public void ReceiveInitialState(BSONObject bsonObj);

  public void ReceiveUpdate(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);
}
