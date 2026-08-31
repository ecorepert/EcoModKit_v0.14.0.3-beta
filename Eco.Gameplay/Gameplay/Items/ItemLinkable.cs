// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemLinkable
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
using PropertyChanged;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Object that can be used to create links to items, tags and other types that use similar style and logic for linking.</summary>
public abstract class ItemLinkable : 
  IController,
  IViewController,
  IHasUniversalID,
  ILinkableParameterized<LinkConfig>,
  ILinkable
{
  public virtual LocString DisplayName { get; }

  public virtual LocString DisplayNamePlural { get; }

  [SyncToView(null, true)]
  [Cached]
  public virtual LocString MarkedUpName { get; }

  public abstract string Name { get; set; }

  public virtual void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public LocString ShowName(float count = 1f);

  public LocString ShowName(int count = 1);

  public override string ToString();

  public LocString UILinkAndNumber(float count);

  public LocString UILinkAndNumber(int count);

  public LocString UILinkAndNumber(int count, string prepend);

  public LocString UILinkAndNumberAndTier(int count, int tier);

  public LocString UILinkAndNumberAndTierPrepend(int count, int tier, string prepend);

  public LocString UILinkAndNumberNoText(int count);

  public virtual LocString UILinkContent();

  public virtual LocString UILinkContent(bool plural);

  public LocString NameAndNum(int count = 1);

  public LocString UILinkAndStyledNumber(int count);

  public LocString UILinkContent(LocString text);

  public LocString UILinkNoNumber(int count);

  public LocString UILinkContent(LinkConfig param);

  protected virtual LocString ItemIconUILink(LocString text);

  [DoNotNotify]
  public ref int ControllerID { get; }
}
