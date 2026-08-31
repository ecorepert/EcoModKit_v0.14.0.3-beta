// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.GovernmentBankAccount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Economy;

/// <summary> Accounts of this type can be targeted by Tax/Pay legal actions. Wealth calculations for users do not include these accounts. </summary>
[Serialized]
[ForceCreateView]
[NoIcon]
public class GovernmentBankAccount : 
  BankAccount,
  ICategorizedEntry,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public LocString CategoryName { get; }

  [SyncToView(null, true)]
  public int CategoryPriority { get; }

  public override float PercentOwnership(User user);

  public override LocString DescribeWealth(User user);

  public override User GetResponsibleUser(bool excludeGovCases = true);
}
