// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.PropertyType
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
public enum PropertyType
{
  [LocDescription("A 'Residence' deed will apply housing points towards the Character XP multiplier, split among the residents.")] Residence,
  [LocDescription("A 'Cultural' deed is a type of property that can contribute to the overall Culture value of the containing settlement.")] Cultural,
  School,
}
