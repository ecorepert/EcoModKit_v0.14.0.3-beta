// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.PickupBountyDirection
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
public enum PickupBountyDirection
{
  [LocDescription("You pay whoever empties this container. The usual setup for garbage: someone else hauls it away and you foot the bill.")] OwnerPaysCollector,
  [LocDescription("Whoever empties this container pays you, as if buying its contents.")] CollectorPaysOwner,
}
