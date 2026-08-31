// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.Catchers.Internal.SpeciesLayeredCatchConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Animals.Catchers.Internal;

/// <summary>
/// Config for <see cref="T:Eco.Gameplay.Animals.Catchers.SpeciesLayeredCatchPlugin" /> to allow custom user settings to target species from <see cref="T:Eco.Gameplay.Animals.Catchers.Internal.LayeredCatchEntry" />
/// e.g.: add/remove target species from fishing pole catcher
/// </summary>
public class SpeciesLayeredCatchConfig
{
  [LocDisplayName("Catchers")]
  public ThreadSafeList<LayeredCatchEntryConfig> CatchersData { get; set; }

  [LocDescription("Display to client layered catch data.")]
  public bool DisplayLayeredCatchInfo { get; set; }

  public void Initialize();

  /// <summary> Gets list of species for the catcher type </summary>
  public IEnumerable<string> GetSpecies(Type catcherType);
}
