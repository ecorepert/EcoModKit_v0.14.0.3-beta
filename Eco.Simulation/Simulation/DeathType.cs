// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.DeathType
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Simulation;

[Serialized]
[Eco.Shared.Networking.Eco(true)]
public enum DeathType
{
  [LocDescription("")] None,
  [LocDescription("It Starved to death.")] Starvation,
  [LocDescription("It was Harvested.")] Harvesting,
  [LocDescription("Pollution levels were too high.")] Pollution,
  [LocDescription("An animal ate it.")] EatenByAnimal,
  [LocDescription("The Meteor killed it.")] Meteor,
  [LocDescription("It was too crowded by other plants.")] TooCrowded,
  [LocDescription("Rising Sea levels killed it.")] RisingSeaLevel,
  [LocDescription("Construction activities killed it.")] Construction,
  [LocDescription("Farming activities killed it.")] Farming,
  [LocDescription("Divine Intervention killed it.")] DivineIntervention,
  [LocDescription("Logging activities killed it.")] Logging,
  [LocDescription("The Ecosystem could not support it.")] Ecosystem,
  [LocDescription("Explosion killed it")] Explosion,
}
