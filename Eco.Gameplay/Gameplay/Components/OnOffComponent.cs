// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.OnOffComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>World object component for adding enable/disable support to a world object.</summary>
[Serialized]
[Tag("OnOff")]
[RequireComponent(typeof (StatusComponent), null)]
[NoIcon]
public sealed class OnOffComponent : 
  WorldObjectComponent,
  OnOffComponent.IOnOffMessagesContainer,
  INotifyPropertyChanged,
  IHasEnvVars
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  /// <summary>The user considered to be running this object: the placer by default, then whoever toggled it last.</summary>
  public User Operator { get; }

  [SyncToView(null, true)]
  public LocString OperatorName { get; }

  /// <summary>Represents current state of the toggle.</summary>
  [SyncToView(null, true)]
  [EnvVar]
  public bool On { get; set; }

  /// <summary>Determines whether the player has access to switch current state.</summary>
  public override bool Enabled { get; }

  /// <summary>The required auth level to enable/disable the world object instance..</summary>
  public AccessType RequiredAuth { get; set; }

  /// <summary>Enables support for this component instance to be turned on/off via the popup messages.</summary>
  public bool AllowPopupControl { get; set; }

  public override void Initialize();

  /// <summary>Overrides default behaviour of the component.</summary>
  public void Setup(
    Func<User, bool, Result> check,
    AccessType auth,
    bool allowPopups,
    OnOffComponent.IOnOffMessagesContainer container);

  [RPC]
  public void SwitchState(Player player);

  [Interaction(InteractionTrigger.RightClick, "Turn On", InteractionModifier.None, null, 0.0f, -2f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, DisallowedEnvVars = new string[] {"On"})]
  [Interaction(InteractionTrigger.RightClick, "Turn Off", InteractionModifier.None, null, 0.0f, -2f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, RequiredEnvVars = new string[] {"On"})]
  [Interaction(InteractionTrigger.RightClick, "Close", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {"LargeDoor"}, DisallowedEnvVars = new string[] {"On"})]
  [Interaction(InteractionTrigger.RightClick, "Open", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {"LargeDoor"}, RequiredEnvVars = new string[] {"On"})]
  public void Toggle(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  /// <summary>Check user's auth and tries to set the on-off state of the component. Can contain additional checks and feedbacks. See how <see cref="T:Eco.Gameplay.Components.Store.StoreComponent" /> changes behaviour of this component. Null user bypasses auth check.</summary>
  public Result SetOnOff(User user, bool onOff);

  public LocString GetStatusNote();

  /// <summary>Components with this interface can proide themselves via <see cref="M:Eco.Gameplay.Components.OnOffComponent.Setup(System.Func{Eco.Gameplay.Players.User,System.Boolean,Eco.Core.Utils.Result},Eco.Shared.Items.AccessType,System.Boolean,Eco.Gameplay.Components.OnOffComponent.IOnOffMessagesContainer)" /> to override default messages.See <see cref="T:Eco.Gameplay.Components.Store.StoreComponent" /> for a demo.</summary>
  public interface IOnOffMessagesContainer
  {
    LocString TurnOnMessage { get; }

    LocString TurnOffMessage { get; }

    LocString TurnedOnMessage { get; }

    LocString TurnedOffMessage { get; }

    LocString NotAuthedMessage { get; }

    LocString InvalidStatusMessage { get; }
  }
}
