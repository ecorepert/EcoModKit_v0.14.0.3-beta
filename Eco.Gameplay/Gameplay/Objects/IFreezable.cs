// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.IFreezable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary> Physics objects that can be freezed, so unity physics wont affect them anymore. Sample: rubble, which after some time of physic simulation gonna to be attach to something and no longer move.
/// This is used mainly for optimizations reasons, so it wont simulate all rubble objects all the time, but there are also another case for that: by example, prevent shop truck from be moved away by physic simulation. </summary>
public interface IFreezable : INetObject, IEcoObject
{
  NetPhysicsEntity NetEntity { get; }

  float GroundDistance { get; set; }

  [RPC]
  void Freeze(Vector3 position, Eco.Shared.Math.Quaternion rotation, float groundDistance);

  [RPC]
  void Unfreeze(Player player, bool forceChangeOwner);
}
