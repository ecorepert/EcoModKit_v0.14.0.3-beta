// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TollComponent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Gameplay.Wires;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.ComponentModel;

#nullable disable
namespace Eco.Mods.TechTree;

[Tag("Economy")]
[Category("Hidden")]
[NoIcon]
[Serialized]
[AutogenClass]
[LocDisplayName("Toll")]
public class TollComponent : SwitchComponent
{
  [SyncToView(null, true)]
  [Autogen]
  [AutoRPC]
  public Currency Currency { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [AutoRPC]
  [Serialized]
  public float TollAmount { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [AutoRPC]
  [Serialized]
  public float TimeBeforeSwitchOff { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public BankAccount TargetBankAccount { get; set; }

  [RPC]
  [Autogen]
  [OwnerHidden]
  [GuestEditable]
  public void PayToll(Player player);

  public override void OnCreate();

  public override void Tick();

  [EnvVar]
  public bool HasFreeToll(Player player);

  public override void Initialize();

  [Interaction(InteractionTrigger.RightClick, "Pay Toll", InteractionModifier.None, null, 0.0f, -1f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void PayTollAndSwitch(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [Interaction(InteractionTrigger.LeftClick, "Open Without Toll", InteractionModifier.None, new string[] {"HasFreeToll"}, 0.0f, -1f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void OpenWithoutToll(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);
}
