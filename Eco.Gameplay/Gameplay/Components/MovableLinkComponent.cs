// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.MovableLinkComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[CreateComponentTabLoc("Storage", false)]
[HasIcon("StorageComponent")]
public class MovableLinkComponent : LinkComponent, IPersistentData
{
  /// <summary>Persists the parent's object id through pickup so link settings other storages keep about this object (keyed by
  /// <see cref="T:Eco.Gameplay.Objects.WorldObjectHandle" />) survive picking up and replacing the vehicle. The placed object keeps its freshly assigned id
  /// (changing a live object's id would race syncs and events already sent with it) and the stored settings are re-keyed to it instead.
  /// Parent is null while the component itself is deserialized on world load (assigned later), so both accessors no-op then —
  /// the id transfer only matters on the item pickup/placement path where Parent is always set.</summary>
  public object PersistentData { get; set; }

  public override void Tick();

  protected override void Relink();

  protected override LinkComponent.LinkSettings NewDefaultLinkSettings(
    IAlias user,
    WorldObject linkedObj,
    Type compType);
}
