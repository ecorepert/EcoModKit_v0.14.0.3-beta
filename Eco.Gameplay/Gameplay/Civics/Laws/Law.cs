// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.Law
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Reflection;

#nullable enable
namespace Eco.Gameplay.Civics.Laws;

[Serialized]
[Ecopedia(null, "Laws", false, true, null)]
[LocDescription("Laws determine rules and processes that all citizens are compelled to follow.")]
[Tag("CanBeInConstitution")]
public class Law : 
  SimpleProposable,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyRecursiveChanged,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [AllowEmpty]
  [AllowCopyPaste]
  public 
  #nullable disable
  ControllerList<LawSection> Sections { get; set; }

  public override bool DescribedWithTable { get; }

  public override void InitializeDraftProposable();

  public override string IconName { get; }

  public override void Initialize();

  [DependsOnMember("UserDescription")]
  [DependsOnMember("Sections")]
  [DependsOnMember("State")]
  [DependsOnSubMember("Sections", "Title")]
  [DependsOnSubMember("Sections", "UserDescription")]
  [SyncToView(null, true, Flags = SyncFlags.ClientCached)]
  public override LocString Description();

  public PostResult TryPerform(GameAction action, AccountChangeSet acc);

  public void OnRecursiveChange(PropertyInfo prop, object objParent);

  public override void ApplyUpdatedProposable(IProposable old);
}
