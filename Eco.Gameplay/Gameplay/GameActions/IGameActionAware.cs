// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.IGameActionAware
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;

#nullable enable
namespace Eco.Gameplay.GameActions;

/// <summary>Allows implementing classes to react to game actions. You must register this as a listener with ActionUtil.</summary>
/// <see cref="M:Eco.Gameplay.GameActions.ActionUtil.AddListener(Eco.Gameplay.GameActions.IGameActionAware)" />
public interface IGameActionAware : ICanOverrideAuth
{
  /// <summary>Called before an action runs so listeners can allow or block it.</summary>
  Result CanPerformAction(GameAction action);

  /// <summary>Called after an action has ran.</summary>
  void ActionPerformed(GameAction action);
}
