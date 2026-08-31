// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.CivicAction_Veto
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[LocDisplayName("Veto Election")]
[LocDescription("Ends an election immediately, blocking its result.")]
[LocCategory("Elections")]
[Ecopedia(null, "Elections", false, true, null)]
[DoesNotNeedCivicArticle]
public class CivicAction_Veto : CivicAction
{
  [Eco.Shared.Networking.Eco(true)]
  [SettlementOnly]
  public Election ElectionToVeto { get; set; }

  public override Result CanEdit(User user);

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public override LocString Description();
}
