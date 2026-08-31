// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.BankComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Economy.Money;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[ForceCreateView]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
[RequireComponent(typeof (JurisdictionComponent), null)]
[Ecopedia(null, "Bank Component", false, true, null)]
[LocDisplayName("Bank")]
[LocDescription("Create and manage access to bank accounts.")]
public class BankComponent : 
  WorldObjectComponent,
  IDualPermissionManager,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  public LocString[] RandomTitles { get; }

  IRegistrar IDualPermissionManager.Registrar { get; }

  public override void Initialize();

  public Type TypeToAdd(Player player, string listName);

  /// <summary>Add a bank account through DualPermission logic and set a Host Object.</summary>
  [RPC]
  public void CreateBankAccount(Player player, bool isGovernmentAccount);
}
