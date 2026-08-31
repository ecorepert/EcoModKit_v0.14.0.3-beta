// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.MinimapComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Minimap;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> Objects with this component will have a hoverable icon generated for displaying on client's minimap. </summary>
/// <remarks> Those icons can be either static (baked to atlas for optimization) or non-static (pos sync in real time), based on if they're Movable or not. </remarks>
[Serialized]
[NoIcon]
public class MinimapComponent : WorldObjectComponent
{
  public bool CanMove { get; }

  public override void Initialize();

  /// <summary> Marks the object as Movable. This can only be done before initialization is complete. </summary>
  public void InitAsMovable();

  public void SetCategory(LocString category);

  /// <summary> Sets the position provider for the target object. If null, the object's position will be used. </summary>
  /// <remarks> Useful for fully syncing the positions of two minimap objects (e.g.: When a Player drives a vehicle). </remarks>
  public void SetOverrideTarget(MinimapObject target);

  /// <summary> Syncs the position of the MinimapObject with that of the parent WorldObject. </summary>
  public void SyncPosition();

  public override void Destroy();
}
