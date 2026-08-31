// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.ElectionPowerFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Items;

[Serialized]
[Eco.Shared.Networking.Eco(true)]
public enum ElectionPowerFlags
{
  Execute = 1,
  ProposeElection = 2,
  VetoElectionsFor = 4,
  RunForOffice = 8,
  RemoveFromOffice = 16, // 0x00000010
  VoteInElectionsFor = 32, // 0x00000020
  OfficeSuccessor = 64, // 0x00000040
}
