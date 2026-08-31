// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.Interactors.ServerInteractionManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Interactions.Interactors;

/// <summary>Info about available interactions that's shared with the client.</summary>
public class ServerInteractionManager : 
  Singleton<ServerInteractionManager>,
  IController,
  IViewController,
  IHasUniversalID
{
  /// <summary>A map of interactor types to a list of the interactions they can perform.</summary>
  [SyncToView(null, true)]
  public Dictionary<Type, List<InteractionAttribute>> InteractorToInteractions { get; }

  /// <summary>Additional interactions that are defined based on the target of the interaction, like a world object or component of a world object.</summary>
  [SyncToView(null, true)]
  public Dictionary<Type, List<InteractionAttribute>> ComponentToInteractions { get; }

  /// <summary>Interactions defined on module items, surfaced on whatever world object the module is currently slotted into.</summary>
  [SyncToView(null, true)]
  public Dictionary<Type, List<InteractionAttribute>> ItemTypeToInteractions { get; }

  /// <summary>Additional interactions that are defined based on the target of the interaction, like a world object or component of a world object.</summary>
  [SyncToView(null, true)]
  public Dictionary<string, List<InteractionAttribute>> NetObjectNameToInteractions { get; }

  /// <summary>We share the same hands interactor for everyone since it has no state.</summary>
  [SyncToView(null, true)]
  public IInteractor HandsInteractor { get; }

  /// <summary>Updates an interaction with any extra data that needs to be known when its being displayed to the user.</summary>
  [RPC]
  public static InteractionLiveUpdate LiveUpdateInteraction(
    User user,
    InteractionTarget target,
    AccessType requiredAccess,
    bool forceEnvVarUpdate);

  /// <summary>Finds all the functions defining interactions, defined both on interactors and on targets.</summary>
  public void Initialize();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
