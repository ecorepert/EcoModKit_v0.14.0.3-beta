// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IContributesMoveGameAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>An inventory that contributes a game action to the move's pack when one of its stacks changes during a transfer,
/// so laws, authorization, and effects run once and atomically with the move instead of inside per-call inventory restrictions.
/// AuthorizationInventory contributes its auth action; garbage bags contribute the drop/pickup garbage law.</summary>
public interface IContributesMoveGameAction
{
  /// <summary>Builds the action for a change of <paramref name="delta" /> units of <paramref name="itemType" /> in this inventory
  /// (negative delta means items are leaving), or null to contribute nothing for this change.</summary>
  GameAction MakeMoveGameAction(Type itemType, int delta, User user);
}
