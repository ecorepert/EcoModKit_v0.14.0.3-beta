// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.CivicAction_RemoveFromOffice
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[LocDisplayName("Remove Official From Office")]
[LocDescription("Forcibly remove an official from office.")]
[LocCategory("Titles")]
[Ecopedia(null, "Civic Action Component", false, true, null)]
[DoesNotNeedCivicArticle]
public class CivicAction_RemoveFromOffice : CivicAction
{
  public static ThreadSafeAction<CivicAction> RemovedFromOfficeByCivicActionEvent;

  [Eco.Shared.Networking.Eco(true)]
  [SettlementOnly]
  public ElectedTitle ElectedTitle { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public User CitizenToRemove { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public string Reason { get; set; }

  public override Result CanEdit(User user);

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public override LocString Description();
}
