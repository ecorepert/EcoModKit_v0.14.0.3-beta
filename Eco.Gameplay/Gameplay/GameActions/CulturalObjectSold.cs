// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.CulturalObjectSold
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Economy")]
[LocDescription("A culturally relevant object (painting) was sold.")]
public class CulturalObjectSold : InteractAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The cultural value of the work.")]
  public float CulturalValue { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency used in the transaction.")]
  [CanAutoAssign]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Amount used in the transaction.")]
  public float CurrencyAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Owner of the painting or cultural work.")]
  public IAlias Owner { get; set; }
}
