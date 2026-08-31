// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.RoomCategory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

/// <summary>Types of rooms that we can support. </summary>
[Ecopedia("Housing", "Rooms", false, true, null)]
public sealed class RoomCategory : 
  IController,
  IViewController,
  IHasUniversalID,
  ILinkableParameterized<LinkConfig>,
  ILinkable
{
  public LocString DisplayName;
  /// <summary>Color associated with this category.</summary>
  public Color Color;
  /// <summary>A list of other room category names which this category can contribute its points to.</summary>
  public string[] SupportingRoomCategoryNames;
  /// <summary>Which property types can furniture of this category support?</summary>
  public PropertyType[] AffectsPropertyTypes;
  /// <summary>For support furnishings (that is, furnishings that dont match the primary room category, like a chair in the kitchen), the total value of the support category cannot exceed this percent of the primary categroy's.</summary>
  public float MaxSupportPercentOfPrimary;
  /// <summary>If assigned (can be null), then it will see if the primary category is in this list, and use this as the max support percent. Otherwise uses default MaxSupportPercentPrimary.  This is used so Outdoor room can get 100% of its value from culture.</summary>
  public Dictionary<string, float> MaxSupportPercentOfPrimaryPerCategory;
  /// <summary>When set, the value of rooms of this type is capped to the value of the rest of the house (the uncapped rooms).  For example, bathrooms are capped at X% of the rest of the house (because its not the main purpose of the dwelling, just a supporting role).</summary>
  public float CapToPercentOfRestOfProperty;
  /// <summary>When set, this cannot determine the type of a room, its a supporting category only (ex, 'Decoration' is a category of furniture but cannot be a category of room).</summary>
  public bool CanBeRoomCategory;
  /// <summary>When set, room category can be a support category for any type of room, even if it's doesn't list it in its support category list (ie, 'Decorations' are useful in any type of room).</summary>
  public bool SupportForAnyRoomType;
  /// <summary>Room value is capped by default based on tier of materials. Categories like Outdoor disable this.</summary>
  public bool ShouldCapFromRoomMaterials;
  public bool CanAutoChooseCategory;
  /// <summary>Set this to true if the category nulls out housing points when in a room.</summary>
  public bool NegatesValue;

  public string Name { get; }

  public LocString DisplayNameColored { get; }

  public IEnumerable<RoomCategory> SupportingRoomCategories { get; }

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  LocString ILinkable.UILinkContent();

  LocString ILinkableParameterized<LinkConfig>.UILinkContent(LinkConfig config);

  /// <summary>Gets how much this support room category can impact the given prinary, using the overrides if set otherwise default.</summary>
  public float GetMaxSupportPercentOfPrimary(RoomCategory primary);

  /// <summary> Can other room give support value to this one? </summary>
  public bool IsSupportedBy(RoomCategory other);

  public static RoomCategory LivingRoom { get; }

  public static RoomCategory General { get; }

  public static RoomCategory Industrial { get; }

  public static RoomCategory Kitchen { get; }

  public static RoomCategory Bathroom { get; }

  public static RoomCategory Bedroom { get; }

  public static RoomCategory Cultural { get; }

  public static RoomCategory Outdoor { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }
}
