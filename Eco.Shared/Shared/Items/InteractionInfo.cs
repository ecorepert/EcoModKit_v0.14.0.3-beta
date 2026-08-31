// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.InteractionInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Items;

/// <summary> Information about an interaction, calculated on the client. </summary>
[BsonAutoSerialize]
public class InteractionInfo : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  /// <summary> ID used to rewind bad predictions. </summary>
  public int ID { get; set; }

  /// <summary> Method used to start the interaction. </summary>
  public InteractionMethod Method { get; set; }

  /// <summary> Any modifier key held down while triggering the interaction. </summary>
  public InteractionModifier Modifier { get; set; }

  /// <summary> The object being interacted with, if set. If this is set BlockPosition will be null. </summary>
  public INetObject TargetObject { get; set; }

  /// <summary> The targeted block, if set. Will not be set at the same time as TargetObject. </summary>
  public Vector3i? BlockPosition { get; set; }

  /// <summary> Custom interaction parameters. </summary>
  public BSONObject Parameters { get; set; }

  /// <summary> Distance to the interaction target. </summary>
  public float Distance { get; set; }

  /// <summary>Interact without a target is considered air interaction aka dropping block off a cliff. When true, Block Position is the position down the cliff.</summary>
  public bool IsAirInteraction { get; set; }

  /// <summary> When TargetObject is not null, the position the interaction ray intersected with the target object. </summary>
  public Vector3? Position { get; set; }

  /// <summary> The facing direction of the side of the selected block. This is the side any placed block will be. </summary>
  public Vector3i? Normal { get; set; }

  /// <summary> The facing direction of the player when performing the action. </summary>
  public DirectionAxisHorizontal FacingDirection { get; set; }

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
