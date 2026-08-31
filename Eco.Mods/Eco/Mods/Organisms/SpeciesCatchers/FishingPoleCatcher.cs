// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.SpeciesCatchers.FishingPoleCatcher
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Utils;
using Eco.Gameplay.Animals.Catchers.Internal;
using Eco.Gameplay.Players;
using Eco.Mods.TechTree;
using Eco.Simulation.Types;
using System;

#nullable disable
namespace Eco.Mods.Organisms.SpeciesCatchers;

/// <summary> Catcher to use with player fishing pole </summary>
/// 
///             Unpon succsefull catch will send fish to client
public class FishingPoleCatcher : UserLayeredCatchEntry
{
  public override ThreadSafeList<string> DefaultTargetSpecies { get; }

  public override bool OnValidationCheck();

  public override TimeSpan NextCatchDelay { get; }

  protected override Range CatchRange { get; }

  protected override bool ApplyCatch(Species species, int qt);

  public FishingPoleCatcher(User user, FishingPoleItem pole);

  public FishingPoleCatcher();
}
