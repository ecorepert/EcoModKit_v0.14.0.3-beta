// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.IHasBonuses
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Implemented by types that provide bonuses. Leaf sources (Talent, PluginModule) back this with a <see cref="T:System.Collections.Generic.List`1" /> so setup can add bonuses.
/// Aggregate sources (User, WorldObject) compute <see cref="P:Eco.Gameplay.Bonuses.IHasBonuses.Bonuses" /> from their sub-sources.
/// All iteration, application, and level resolution is handled by <see cref="T:Eco.Gameplay.Bonuses.BonusManager" /> — implementors just define the <see cref="P:Eco.Gameplay.Bonuses.IHasBonuses.Bonuses" /> property. </summary>
public interface IHasBonuses
{
  IEnumerable<Bonus> Bonuses { get; }
}
