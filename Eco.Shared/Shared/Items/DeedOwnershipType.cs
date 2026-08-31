// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.DeedOwnershipType
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
public enum DeedOwnershipType
{
  [LocDescription("The deed is directly owned by the specified citizen or title.")] DirectOwnership,
  [LocDescription("The deed is owned by anyone who is a member of the specified title (includes nested titles).")] MemberOwnership,
  [LocDescription("Either directly owned or owned by a member of the specified title.")] DirectOrMemberOwnership,
}
