// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.CivicAction_EnterElection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[LocDisplayName("Enter Election")]
[LocDescription("Join an election as a candidate.")]
[LocCategory("Elections")]
[Ecopedia(null, "Elections", false, true, null)]
[DoesNotNeedCivicArticle]
public class CivicAction_EnterElection : CivicAction, ICustomValidity, IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [HideBooleanElections]
  [SettlementOnly]
  public Election Election { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LargeUI]
  public string Speech { get; set; }

  public override Result CanEdit(User user);

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public Result Valid();

  public override LocString Description();
}
