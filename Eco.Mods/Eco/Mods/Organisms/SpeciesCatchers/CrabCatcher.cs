// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.SpeciesCatchers.CrabCatcher
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using System;

#nullable disable
namespace Eco.Mods.Organisms.SpeciesCatchers;

public class CrabCatcher : TrapCatcher
{
  public override ThreadSafeList<string> DefaultTargetSpecies { get; }

  public override TimeSpan NextCatchDelay { get; }

  public CrabCatcher(User user, WorldObject obj);

  public CrabCatcher();
}
