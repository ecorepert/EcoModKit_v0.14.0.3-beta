// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ActionUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary>
/// Utility class to help with keeping track of IGameActionAware listeners, and notifying them when actions are performed.
/// <para> Used by systems like Contracts, WorkParties, Item Distributions, etc., to keep track of progress. </para>
/// </summary>
public static class ActionUtil
{
  /// <summary>
  /// Holds listeners that want to be notified whenever a GameAction is being performed.
  /// <para> Also used by AuthManager to check if auth should be overriden for a specific action because it's allowed by one (e.g. a Contract that allows usage of someone's Oven). </para>
  /// </summary>
  public static readonly ThreadSafeList<IGameActionAware> Listeners;

  public static void AddListener(IGameActionAware listener);

  public static void RemoveListener(IGameActionAware listener);

  /// <summary>Returns the first failed listener result, or success if all listeners allow the action.</summary>
  /// <exception cref="T:System.ArgumentNullException">Throws if action is null.</exception>
  public static Result CanPerformAction(GameAction action);

  /// <summary> Notifies all listeners that an action was performed. </summary>
  public static void ActionPerformed(GameAction action);
}
