// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Plants.PlantActionAware
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Property;

#nullable enable
namespace Eco.Gameplay.Plants;

/// <summary>Override authentication for tree</summary>
public class PlantActionAware : IGameActionAware, ICanOverrideAuth
{
  public void ActionPerformed(GameAction action);

  /// <summary>Override for tree. Who chopped the tree gain access to its trunks</summary>
  public LazyResult ShouldOverrideAuth(IAlias? alias, IOwned? property, GameAction? action);
}
