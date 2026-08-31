// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.ILinkableTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Economy;
using Eco.Gameplay.EcopediaRoot;
using Eco.Gameplay.Items;
using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.Messaging.Chat.Channels;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class ILinkableTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (District), "ContainingMap", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString DistrictLinkClicked(this District district);

  [TooltipAffectedBy(typeof (Election), "Finished", null, null)]
  [TooltipAffectedBy(typeof (Election), "State", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString ElectionLinkClicked(this Election election);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {typeof (Election)})]
  public static LocString SimpleProposableLinkClicked(this SimpleProposable simpleProposable);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString BankAccountLinkClicked(this BankAccount bankAccount);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString ReputationLinkClicked(this Eco.Gameplay.Economy.Reputation.Internal.Reputation reputation);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString EcopediaPageLinkClicked(this EcopediaPage ecopediaPage);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString ContractTrackerLinkClicked(this ContractTracker contractTracker);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString ItemLinkClicked(this Item item, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString WorldObjectLinkClicked(this WorldObject worldObject, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString UserLinkClicked(this User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString DeedLinkClicked(this Deed deed);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 201, TTCat.LinkControls, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString SkillLinkClicked(this Skill skill, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 201, TTCat.LinkControls, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString AdminSkillMenu(this Skill skill, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString ChannelLinkClicked(this Channel channel);

  [TooltipAffectedBy(typeof (TextLinkButton), "HoveredHint", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString TextLinkButtonLinkClicked(this TextLinkButton textLinkButton);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString Vector2TooltipLinkClicked(this Vector2Tooltip vector2Tooltip);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 201, TTCat.LinkControls, TTFlags.None, null, new Type[] {})]
  public static LocString Vector3TooltipLinkClicked(this Vector3Tooltip vector3Tooltip);
}
