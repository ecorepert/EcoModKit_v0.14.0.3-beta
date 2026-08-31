// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Jobs.RecurringTransferContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Economy.Jobs;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Context for determining subscription cost at initial creation.")]
public class RecurringTransferContext : IContextObject, IController, IViewController, IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen paying/receiving the funds.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The account the charge is coming from.")]
  [CanAutoAssign]
  public BankAccount UserAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The account the charge is going to.")]
  [CanAutoAssign]
  public BankAccount ServiceAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If the recurring transfer represents rent, this will be set to the deed of the property. Otherwise it will be null.")]
  [CanAutoAssign]
  public Deed RentalDeed { get; set; }

  public ref int ControllerID { get; }
}
