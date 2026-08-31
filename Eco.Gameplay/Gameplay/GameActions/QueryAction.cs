// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.QueryAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Stats;

#nullable disable
namespace Eco.Gameplay.GameActions;

[NoStats]
[NoLaws]
[DontTest]
[NoIcon]
public class QueryAction : WorldObjectInteractAction
{
  public override bool OverrideHierarchyActionsToConsumer { get; }
}
