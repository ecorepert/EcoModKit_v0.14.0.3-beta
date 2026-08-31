// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.TextLinkButton
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

/// <summary> Clickable UI link that can be used in tooltips. For a demo see <see cref="M:Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.CraftingComponentTooltipLibrary.OwnershipTooltip(Eco.Gameplay.Items.WorkOrder,Eco.Gameplay.Players.User)" /> or <see cref="T:Eco.Gameplay.Items.ItemPersistentData" />.</summary>
public class TextLinkButton : UnserializedEntry
{
  public ThreadSafeAction<TooltipOrigin, TooltipClickContext, User> OnClick { get; }

  public LocString CustomUILink { get; }

  public LocString HoveredHeader { get; set; }

  [Notify]
  public LocString HoveredContent { get; set; }

  /// <summary>This string will be at the bottom of the tooltip when the button is hovered.</summary>
  [Notify]
  public LocString HoveredHint { get; set; }

  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public IEnumerable<IController> TooltipChildren { get; set; }

  public void SetCustomUILink(LocString content);

  public override LocString UILinkContent();

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public TextLinkButton();

  public TextLinkButton(
    Action<TooltipOrigin, TooltipClickContext, User> onClick,
    LocString link);

  public TextLinkButton(
    Action<TooltipOrigin, TooltipClickContext, User> onClick,
    LocString header,
    LocString hint);

  public TextLinkButton(
    Action<TooltipOrigin, TooltipClickContext, User> onClick,
    LocString header,
    LocString hint,
    LocString content);

  public TextLinkButton(
    Action<TooltipOrigin, TooltipClickContext, User> onClick,
    LocString header,
    LocString hint,
    LocString content,
    LocString link);

  public LocString DescribeLoc(string additionalString);

  public LocString Describe(LocString additionalString);
}
