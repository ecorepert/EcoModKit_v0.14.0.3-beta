// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.StrangeCloudGameplay.StrangeBlueprintMonitor
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.StrangeCloudGameplay;

/// <summary>Tracks protected items to make sure too many are not spawned in world.</summary>
[ChatCommandHandler]
public class StrangeBlueprintMonitor : Singleton<
#nullable disable
StrangeBlueprintMonitor>
{
  internal void RegisterMarketplaceItems(List<string> items);

  internal void UpdateAllowedAmounts();

  public bool CanPlace(User user, string name, int amount = 1);

  /// <summary>Place it, if there's not too many compared to the number of owned blueprints, and update counts.</summary>
  internal bool TryPlace(User user, string name, int amount = 1);

  /// <summary>Add without mind to current amounts.</summary>
  internal void ForcePlace(string name, int amount = 1);

  /// <summary>Remove an object/block from the world</summary>
  internal void Destroyed(string name, int amount = 1);

  public bool CanPlaceBlock(User user, Type type, int amount = 1);

  /// <summary>Place it, if there's not too many compared to the number of owned blueprints, and update counts.</summary>
  public bool TryPlaceBlock(Type type);

  /// <summary>Optimized block destruction tracking</summary>
  internal void BlockDestroyed(Type type);
}
