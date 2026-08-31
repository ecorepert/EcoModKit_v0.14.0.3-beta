// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CreditComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[LocDescription("Sets the currency used to rent this workbench.")]
[HasIcon(null)]
[Priority(-200)]
[Ecopedia(null, null, false, true, null)]
public class CreditComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IPersistentData,
  ICopyPasteComponent
{
  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public CreditItemData CreditData { get; set; }

  [SyncToView(null, true)]
  public bool NullCurrencyAllowed { get; }

  [SyncToView(null, true)]
  public LocString NullSelection { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  public bool UsingCurrency { get; }

  public object PersistentData { get; set; }

  [RPC]
  public void CurrencyReport(Player player);

  public bool FeeWaived(User user);

  /// <summary>Per-viewer mirror of <see cref="M:Eco.Gameplay.Components.CreditComponent.FeeWaived(Eco.Gameplay.Players.User)" /> for fee-paying UIs. Lives here rather than on the auth view. This component is re-sent
  /// fresh on every UI open, while the always loaded auth view can hold a stale access value across ownership changes the client wasn't subscribed for.</summary>
  [SyncToView(null, true)]
  public bool FeeWaivedForViewer(Player player);

  public override void Initialize();

  public void ChangeNullSelectionValue(LocString nullSelection);

  public override void Destroy();

  public Type CopyPasteGroup { get; }

  public Result CopyFrom(WorldObjectComponent source, Player player);

  public Result VerifyBankAccount();

  public float Fee(float timePerItem, int quantity, User user);
}
