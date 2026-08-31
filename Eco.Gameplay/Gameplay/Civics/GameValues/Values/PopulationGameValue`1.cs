// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.PopulationGameValue`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.GameValues.Values;

public abstract class PopulationGameValue<T> : GameValue<
#nullable disable
T>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Defines what kind of population will be queried.")]
  public SpecialResidents PopulationType { get; set; }

  protected int CountPopulation(IEnumerable<Deed> deeds);

  protected LocString Description(string placeName, string relationDescription = null);
}
