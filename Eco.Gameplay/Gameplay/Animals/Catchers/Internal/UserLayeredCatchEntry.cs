// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.Catchers.Internal.UserLayeredCatchEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Animals.Catchers.Internal;

/// <summary> Base class for player dependent catchers. Preferably targeting user inventory and checks by user position to apply catcher </summary>
public abstract class UserLayeredCatchEntry : LayeredCatchEntry
{
  public override Inventory TargetInventory { get; }

  public override Vector3i OnPositionCheck();

  protected UserLayeredCatchEntry();

  protected UserLayeredCatchEntry(User user);
}
