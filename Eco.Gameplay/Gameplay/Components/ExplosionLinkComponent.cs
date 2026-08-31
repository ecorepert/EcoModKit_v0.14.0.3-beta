// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ExplosionLinkComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[NoIcon]
public class ExplosionLinkComponent : WorldObjectComponent, INotifyPropertyChanged
{
  [Serialized]
  public float FuseTimeDetonator { get; set; }

  public ExplosionLinkComponent();

  public ExplosionLinkComponent(float fuseTimeDetonatorSeconds);

  public void Initialize(float fuseTimeDetonatorSeconds);

  public bool IsLinked { get; }

  /// <summary> Links this fuse to player detonator </summary>
  [RPC]
  public bool Link(Player player);

  /// <summary> Unlinks this fuse from player detonator </summary>
  [RPC]
  public bool UnLink(Player player);

  /// <summary> Triggers this fuse from client, should be called for all such components at once </summary>
  [RPC]
  public void LinkedDetonation(Player player);
}
