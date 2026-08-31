// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.Internal.InteractionLiveUpdaterServer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Interactions.Internal;

/// <summary>Handles adding extra information given a specific interaction target, like the authorization of that item, and any adidtional world object params
/// that need to be sent to it.</summary>
public static class InteractionLiveUpdaterServer
{
  /// <summary>Updates an interaction with any extra data that needs to be known when its being displayed to the user.</summary>
  /// 
  ///             We also pass in a 'forceEnvVarUpdate' which allows the client to tell us they want an update piggybacked here.
  public static InteractionLiveUpdate LiveUpdateInteraction(
    User user,
    InteractionTarget target,
    AccessType requiredAccess,
    bool forceEnvVarUpdate);
}
