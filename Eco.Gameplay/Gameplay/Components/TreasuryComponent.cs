// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.TreasuryComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[Priority(0)]
[HasIcon(null)]
[Tag("Economy")]
[Ecopedia(null, null, false, true, null)]
[ChatCommandHandler]
[RequireComponent(typeof (JurisdictionComponent), null)]
public class TreasuryComponent : WorldObjectComponent, INotifyPropertyChanged
{
  [SyncToView(null, true)]
  [AutoRPC]
  [AllowNullInView]
  public Currency SettlementDefaultCurrency { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public SettlementTaxes Tax { get; }

  [SyncToView(null, true)]
  public BankAccount Account { get; }

  public override void Initialize();

  [RPC]
  public void RefreshTreasuryHoldings();

  public override bool IsRPCAuthorized(
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);
}
