// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.DeedFactory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Shared.Items;

#nullable disable
namespace Eco.Gameplay.Property;

public static class DeedFactory
{
  /// <summary>Creates a new deed with the specified User as the owner and creator.</summary>
  public static Deed CreateDeed(User ownerAndCreator, string deedName = null, PropertyType propertyType = PropertyType.Residence);

  /// <summary>Creates a new deed with the specified IAlias as owner and User as creator.
  /// The owner should never be null, in case the owner is null, the deed will remain unowned and also the name of the deed will be default (e.g.: Deed 1), unless the deedName is set.
  /// If the owner is setted then it would be forced to be the owner of the deed and it would take its name as reference to create a deed name (e.g.: Playertropolis).
  /// The creator is the first user that made the deed, also in case of changing the owner, the creator does not retain any rights in the deed, only the title as the creator.</summary>
  public static Deed CreateDeed(
    IAlias owner,
    User creator,
    string deedName = null,
    PropertyType propertyType = PropertyType.Residence);
}
