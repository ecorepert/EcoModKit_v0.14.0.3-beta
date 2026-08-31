// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TiedElectionOptions
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
public enum TiedElectionOptions
{
  [LocDescription("Pick a random candidate(s) between tied candidates.")] RandomCandidate,
  [LocDescription("No action is taken, no winner is chosen.")] NoWinner,
  [LocDescription("Choose the candidate(s) currently holding the title first, then those with the highest reputation.")] IncumbentPriority,
  [LocDescription("Choose the candidate(s) not currently holding the title, then those with the highest reputation.")] NonIncumbentPriority,
}
