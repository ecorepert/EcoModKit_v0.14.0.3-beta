// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.Cod
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Animals;
using Eco.Shared.Localization;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using System.Numerics;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side animal entity definition for "Cod".</para>
/// <para>More information about AnimalEntity objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Animals.AnimalEntity.html</para>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
/// </summary>
public class Cod : AnimalEntity
{
  public Cod(Animal parent, Vector3 pos, bool corpse, bool sick, int herdId);

  /// <summary>
  /// <para>Server side species definition for "Cod".</para>
  /// <para>More information about AnimalSpecies objects can be found at https://docs.play.eco/api/server/eco.simulation/Eco.Simulation.Types.AnimalSpecies.html</para>
  /// </summary>
  /// <inheritdoc />
  [Ecopedia("Animals", "Fish", true, true, null)]
  [Localized(false, true, "", false)]
  public class CodSpecies : AnimalSpecies
  {
  }
}
