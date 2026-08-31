// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Debt
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Economy;

[Serialized]
public class Debt : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  [Serialized]
  [SyncToView(null, true)]
  public BankAccount PayIntoAccount { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Lender { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Borrower { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Currency Currency { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public double DueDate { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float Amount { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float InterestPercent { get; set; }

  public User BorrowerUser { get; }

  public User LenderUser { get; }

  [SyncToView(null, true)]
  public LocString Text(Player player);

  public LocString DueText();

  public Result Pay(User user, BankAccount account, float toPay);

  public ref int ControllerID { get; }

  public bool Concerns(string name);

  public void NotifyPlayers();
}
