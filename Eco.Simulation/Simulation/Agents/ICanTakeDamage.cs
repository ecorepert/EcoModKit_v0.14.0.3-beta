// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.ICanTakeDamage
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Networking;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Simulation.Agents;

/// <summary> Interface to be implemented by objects which can take damage. It then may be used in simulation (in example for attacking animals). </summary>
public interface ICanTakeDamage
{
  /// <summary> Tries to make <paramref name="damage" />. Returns <c>false</c> if failed to make any damage. </summary>
  bool TryDamage(INetObject source, float damage, DamageSourceType sourceType);
}
