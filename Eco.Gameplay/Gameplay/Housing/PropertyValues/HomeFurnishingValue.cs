// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

public class HomeFurnishingValue : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public LocString ObjectName { init; }

  [LocDescription("Which category this room evaluates to, based on the furniture it contains")]
  public RoomCategory Category { init; get; }

  [LocDescription("The computed value of the object towards skill, which gets reduced based on room state.")]
  public float BaseValue { init; get; }

  [LocDescription("Multiple furniture of the same type will provide diminishing returns.")]
  public LocString TypeForRoomLimit { init; get; }

  [LocDescription("Multiple furnishings of the same type will be reduced by this percent with each additional object.")]
  public float DiminishingReturnMultiplier { init; get; }

  [LocDescription("When there are duplicates in multiple rooms, each subsequent one will be reduced by this percent.")]
  public float DiminishingMultiplierAcrossFullProperty { get; set; }

  /// <summary>When set, defines the value which determines an object uniqueness, insted of the type (which is the default). IE, a painting can link to the painting's owner to determine uniqueness per painter.</summary>
  public Func<WorldObject, object> UniquenessObject { set; }

  public LocString UniqueObjectName { set; }

  /// <summary>Determines the housing value including any reductions</summary>
  public float CalculateValue(WorldObject obj, int uniquenessCountAcrossFullProperty);

  /// <summary>Get the object which we use to determine uniqueness across the property. This may have a special callback attached
  /// (like PicutreFrame to get the artist) or be the default of the world object's type.</summary>
  public object GetUniquenessObject(WorldObject obj);

  /// <summary>Describe the value, taking as a paramter how many of these exist across the whole property being scored.</summary>
  public LocString Describe(WorldObject obj, int uniquenessCountAcrossFullProperty);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
