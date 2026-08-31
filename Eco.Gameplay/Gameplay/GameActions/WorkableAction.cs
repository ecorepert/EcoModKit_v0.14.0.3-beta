// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.WorkableAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using LiteDB;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
public abstract class WorkableAction : 
  InteractAction,
  ICurrencyGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [BsonIgnore]
  public override AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency used.")]
  [CanAutoAssign]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Amount for payment.")]
  public float CurrencyAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who posted the work.")]
  [CanAutoAssign]
  public User Client { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Current percent completion of total work.")]
  public float PercentDone { get; set; }
}
