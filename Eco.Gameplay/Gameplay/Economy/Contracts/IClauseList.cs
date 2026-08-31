// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.IClauseList
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

/// <summary> Implement on classes that can host Clauses (e.g.: 'Contract' and 'ContractClauseNested'). </summary>
/// <remarks> Used to get all hosted clauses from the parent level (e.g.: Contract will check its clauses and clauses that are children of ContractClauseNested at any level). </remarks>
public interface IClauseList
{
  [Serialized]
  [SyncToView(null, true)]
  ControllerList<ContractClause> Clauses { get; }

  User ClientUser { get; }
}
