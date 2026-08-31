// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.SpeciesCatchers.TrapCatcher
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Animals.Catchers.Internal;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using System;

#nullable disable
namespace Eco.Mods.Organisms.SpeciesCatchers;

/// <summary> Catcher to use with traps </summary>
public abstract class TrapCatcher : WorldObjectLayeredCatchEntry
{
  public override Inventory TargetInventory { get; }

  public override bool OnValidationCheck();

  protected override Range CatchRange { get; }

  public TrapCatcher(User user, WorldObject obj);

  public TrapCatcher();
}
