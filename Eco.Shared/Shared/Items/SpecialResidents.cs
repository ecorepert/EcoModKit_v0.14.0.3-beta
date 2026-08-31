// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.SpecialResidents
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Items;

[Serialized]
[Eco.Shared.Networking.Eco(true)]
[Localized(true, false, "", false)]
public enum SpecialResidents
{
  [LocDescription("A person who is a resident on the property.")] Resident,
  [LocDescription("A person who is a resident and not an owner.")] Renter,
  [LocDescription("A person who is an owner on a property where there are non-owning renters.")] Landlord,
  [LocDescription("A person who has been invited to become a resident, but is not yet one (and not an owner).")] Invitee,
  [LocDescription("A person who owns the property.")] Owner,
}
