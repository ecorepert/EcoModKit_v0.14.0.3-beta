// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.BoatMooragePostComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>
/// Component used by boat moorage posts.
/// Allows attaching and detaching boats.
/// Finds boats nearby player that can be attached and detached, filtering allowed boats by player authorization.
/// </summary>
[Serialized]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
public class BoatMooragePostComponent : WorldObjectComponent
{
  [SyncToView(null, true)]
  public int MaxAttachedBoats { get; set; }

  public float FindBoatRadius { get; }

  public BoatComponent.BoatSize MaxBoatSize { get; set; }

  public override void Initialize();

  /// <summary>When moorage post is destroyed, we need to detach any attached boats.</summary>
  public override void Destroy();

  /// <summary>
  /// Actually handles unlocking a boat from the moorage post.
  /// Can't be directly called from players.
  /// It's called on <see cref="M:Eco.Gameplay.Components.BoatMooragePostComponent.UnlockBoat(Eco.Gameplay.Players.Player,Eco.Gameplay.Components.BoatComponent)" /> after all safety checks are done.
  /// It's also called when the moorage post is destroyed or when a boat is destroyed.
  /// </summary>
  public void ForceUnlockBoat(BoatComponent boat);
}
