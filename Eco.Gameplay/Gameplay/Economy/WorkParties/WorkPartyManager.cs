// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.WorkPartyManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Items;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.WorkParties;

[ChatCommandHandler]
public class WorkPartyManager : 
  AutoSingleton<
  #nullable disable
  WorkPartyManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IGameActionAware,
  ICanOverrideAuth
{
  [SyncToView(null, true)]
  public IEnumerable<Eco.Gameplay.Economy.WorkParties.WorkParty> RelevantWorkParties(Player player);

  public Eco.Gameplay.Economy.WorkParties.WorkParty SetupWorkPartyForUser(
    User user,
    WorldObject board,
    WorkPartyType workPartyType);

  public void RelevantPartiesChanged();

  public void ActionPerformed(GameAction action);

  public LazyResult ShouldOverrideAuth(IAlias alias, IOwned property, GameAction action);

  public ref int ControllerID { get; }

  [ChatCommand("Shows commands related to work parties.", ChatAuthorizationLevel.DevTier)]
  public static void WorkParty(User user);

  [ChatSubCommand("WorkParty", "Spawn a work party for testing.", ChatAuthorizationLevel.DevTier)]
  public static void Spawn(User user);
}
