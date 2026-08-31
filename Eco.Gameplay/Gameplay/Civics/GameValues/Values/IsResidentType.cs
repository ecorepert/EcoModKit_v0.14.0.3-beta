// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.IsResidentType
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using NLog.Config;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Residency")]
[LocDescription("Check if a citizen is a resident, renter, owner, or invited on a given property")]
public class IsResidentType : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The citizen being checked.")]
  public GameValue<User> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Defines the resident type to check for.")]
  public SpecialResidents ResidentType { get; set; }

  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);
}
