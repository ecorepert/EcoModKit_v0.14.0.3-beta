// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.Catchers.Internal.WorldObjectLayeredCatchEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Animals.Catchers.Internal;

/// <summary> Base class for world object targeted catchers. Preferably targeting their storage inventory and checks by object position </summary>
public abstract class WorldObjectLayeredCatchEntry : LayeredCatchEntry
{
  protected readonly WorldObject targetObject;

  public override Inventory TargetInventory { get; }

  protected WorldObjectLayeredCatchEntry();

  protected WorldObjectLayeredCatchEntry(User user, WorldObject obj);

  public override Vector3i OnPositionCheck();

  public override bool OnValidationCheck();
}
