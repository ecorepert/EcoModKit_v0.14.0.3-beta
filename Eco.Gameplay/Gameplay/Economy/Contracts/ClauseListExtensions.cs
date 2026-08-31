// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ClauseListExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

public static class ClauseListExtensions
{
  [RPC]
  public static void AddClause(this 
  #nullable disable
  IClauseList list, Player player);

  [RPC]
  public static void ChangeClause(this IClauseList list, int index, string newClauseType);

  public static LocString ClauseDesc(this IClauseList list);

  public static LocString SimpleClauseDesc(this IClauseList list);

  /// <summary>Gets simple version of contract clause description in the format: X Contract Clauses</summary>
  public static IEnumerable<ContractClause> ClausesRecursive(this IClauseList list);
}
