// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameActionExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.GameActions;

/// <summary>Extension for game actions.</summary>
public static class GameActionExtensions
{
  /// <summary>Check location permissions. Get all the affected plots.  Some actions may affect multiple plots.</summary>
  public static IEnumerable<Deed> AffectedDeeds(this GameAction action);

  public static IEnumerable<Item> All(this ISkillGameAction action);

  /// <summary> Tries to fill action's fields with the provided data. </summary>
  public static GameAction Fill(
    this GameAction action,
    MultiblockActionContext context,
    WrappedWorldPosition3i position,
    Item? itemUsed = null);

  public static GameAction Fill(
    this GameAction action,
    User? user,
    Item? tool,
    WrappedWorldPosition3i position,
    AccessType? access,
    Item? itemUsed = null);
}
