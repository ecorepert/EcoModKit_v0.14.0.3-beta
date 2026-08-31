// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.Conditional_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.LegalActions;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Conditional")]
[LocDescription("Perform different actions depending on a test.")]
[LocCategory("Structural")]
public class Conditional_LegalAction : 
  LegalAction,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [HideRoot]
  public IfThenBlock IfThenBlock { get; set; }

  public override LocString Description();

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);

  public override bool ContainsAction(Type type);
}
