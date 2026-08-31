// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicAction_ChangeElement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics;

[LocDisplayName("Change Civic Element")]
[LocDescription("Change an existing civic element")]
[Eco.Shared.Networking.Eco(true)]
public class CivicAction_ChangeElement : 
  CivicAction,
  IProposableContainer,
  IController,
  IViewController,
  IHasUniversalID,
  IFullDescribable,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [AnyStateAllowed]
  [IgnoreValidity]
  public 
  #nullable disable
  IProposable PreviousElement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AnyStateAllowed]
  [ForceScanSubProp]
  public IProposable Element { get; set; }

  public IEnumerable<IProposable> AllElements { get; }

  public IEnumerable<IProposable> ElementsBecomingActive { get; }

  public IEnumerable<IProposable> ElementsBeingRemoved { get; }

  public override LocString Description();

  public override LocString Subject { get; }

  public override LocString ContainedElementName { get; }

  public override string TableHeader { get; }

  public override bool IsNull();

  public LocString FullDescribe();

  public override Result Perform(User user, Election election);

  public override LocString ElectionStarted(User user, Election election);

  public override LocString Failed(User user);
}
