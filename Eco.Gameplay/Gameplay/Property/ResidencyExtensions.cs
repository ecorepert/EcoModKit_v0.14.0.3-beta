// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.ResidencyExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Property;

public static class ResidencyExtensions
{
  public static bool IsResident(this User user, Deed deed);

  public static Deed GetResidencyDeed(this User user);

  /// <summary>
  /// Check if a user belongs to a resident type (resident, renter, landlord, owner or invited)
  /// owner: someone who owns the property
  /// landlord: an owner + has non-owning residents
  /// resident: a person who is a resident on  the property
  /// renter: a person who is a resident and not an owner
  /// Owner or Landlord can't be renter or invitee
  /// </summary>
  public static bool IsResidentType(
    this User user,
    SpecialResidents residentType,
    IEnumerable<Deed> deedScope);
}
