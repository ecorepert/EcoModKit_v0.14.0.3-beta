// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.EcopediaRoot.EcopediaPage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.EcopediaRoot;

[ConstantView]
public sealed class EcopediaPage : 
  UnserializedNamedEntry<EcopediaPage>,
  IEcopediaTab,
  IPrioritizedPage,
  IController,
  IViewController,
  IHasUniversalID,
  ILinkableParameterized<LocString>,
  ILinkable,
  IEcopediaDynamicPageName
{
  [SyncToView(null, true)]
  public List<EcopediaSectionBase> Sections { get; set; }

  [SyncToView(null, true)]
  public Dictionary<string, EcopediaPage> SubPages { get; set; }

  public bool CustomMerge { get; set; }

  [SyncToView(null, true)]
  public LocString DisplayName { get; set; }

  [SyncToView(null, true)]
  public string IconName { get; set; }

  [SyncToView(null, true)]
  public string Summary { get; set; }

  [SyncToView(null, true)]
  public float Priority { get; set; }

  [SyncToView(null, true)]
  public bool HasGeneratedData { get; set; }

  [SyncToView(null, true)]
  public bool HasOnPageTooltips { get; set; }

  [SyncToView(null, true)]
  public string FullName { get; set; }

  [SyncToView(null, true)]
  public string PageName { get; }

  [SyncToView(null, true)]
  public IEnumerable<Type> TypesForThisPage { get; }

  [SyncToView(null, true)]
  public List<UniversalIdDetails> RepresentativeTypes { get; set; }

  public void ParseTagsInText();

  public override LocString UILinkContent();

  public LocString UILinkContent(LocString text);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public void AddGeneratedData(IEcopediaGeneratedData generator);
}
