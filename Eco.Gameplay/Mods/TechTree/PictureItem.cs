// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PictureItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Systems.UserTextures;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable enable
namespace Eco.Mods.TechTree;

/// <summary>Holds the UserTexture for displaying it on PictureFrameItem, created by CameraItem</summary>
[LocDescription("A picture displaying a captured moment.")]
[ItemGroup("Pictures")]
[Serialized]
public class PictureItem : 
  Item,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  ICannotBeInStores,
  IHasSerializableID,
  IHasUniversalID
{
  /// <summary>Clickable tooltip section, triggers ClearOnRequest (see ResetDataTooltip).</summary>
  public 
  #nullable disable
  TextLinkButton ShowPictureButton;

  [NewTooltipChildren(CacheAs.Instance)]
  [Serialized]
  [SyncToView(null, true)]
  [Notify]
  public UserTexture Picture { get; set; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  /// <summary>With click opens UI with full image.</summary>
  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  /// <summary>Use UserTexture as an Icon. If there is no picture (e,g in chat tagging for a type, or picture is not approved yet) default icon should be used.</summary>
  public override LocString UILinkContent();

  public override string OnUsed(Player player, ItemStack itemStack);

  public override Item Clone();

  [RPC]
  public void ViewImageInPopup(Player player);

  public void ViewImageInPopup(Player player, bool readOnly, Settlement settlement);

  public PictureItem();

  public PictureItem(UserTexture pic);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  LocString ICannotBeInStores.MessageToDisplayWhenCantBeDisplayedInStore { get; }

  bool ICannotBeInStores.ShouldAllowInStores { get; }
}
