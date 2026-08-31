// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.CivicAction_ResignFromOffice
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
[LocDisplayName("Resign from Office")]
[LocDescription("Resign from an elected title you hold.")]
[LocCategory("Titles")]
[Ecopedia(null, "Elections", false, true, null)]
[DoesNotNeedCivicArticle]
public class CivicAction_ResignFromOffice : CivicAction
{
  [Eco.Shared.Networking.Eco(true)]
  [AliasContainsPlayer]
  [SettlementOnly]
  public ElectedTitle ElectedTitle { get; set; }

  public override LocString Description();

  public override Result CanEdit(User user);

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);
}
