// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.DesertMoss
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Plants;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Simulation;
using Eco.Simulation.Types;

#nullable disable
namespace Eco.Mods.Organisms;

/// <summary>
/// <para>Server side entity definition for the "DesertMoss" entity.</para>
/// <para>More information about Item objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Plants.PlantEntity.html</para>
/// </summary>
[Serialized]
public class DesertMoss : PlantEntity
{
  public DesertMoss(WorldPosition3i mapPos, PlantPack plantPack);

  public DesertMoss();

  [Ecopedia("Plants", "Plants", true, true, null)]
  [Tag("Plants")]
  [Localized(false, true, "", false)]
  public class DesertMossSpecies : PlantSpecies
  {
  }
}
