// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ChunkSubscriberComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[NoIcon]
public class ChunkSubscriberComponent : WorldObjectComponent
{
  public static 
  #nullable disable
  IEnumerable<IChunkSubscriber> SubscribersToUpdate { get; }

  public static void StaticInitialize();

  public override void Initialize();

  public override void OnAfterObjectMoved();

  /// <summary> Queues a ChunksChanged evaluation for this subscriber after its usual update delay. Keeps the earlier time if one is already queued. </summary>
  public static void QueueUpdate(IChunkSubscriber subscriber);

  /// <summary> Update the chunk subscriptions for this subscriber. </summary>
  public static void UpdateSubscriptions(IChunkSubscriber subscriber);

  /// <summary> Update the subscriptions for this subscriber to specific chunks. (Note: Removes previous subscriptions.) </summary>
  public static void UpdateSubscriptionsWithChunks(
    IChunkSubscriber subscriber,
    List<Vector3i> chunks);

  public override void Destroy();
}
