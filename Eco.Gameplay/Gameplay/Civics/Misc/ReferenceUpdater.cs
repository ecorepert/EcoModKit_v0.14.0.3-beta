// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.ReferenceUpdater
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using ConcurrentCollections;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

public static class ReferenceUpdater
{
  public static ConcurrentHashSet<IExternalReferencer> ExternalReferencers { get; }

  public static void RegisterExternalReferencer(IExternalReferencer holder);

  public static void DeRegisterExternalReferencer(IExternalReferencer holder);

  /// <summary>Special case for just changing references in all possible reference places for a set of object pairs.
  /// Can also take an additional thing that is referenced and ensure all the references are updated there.
  /// Returns a description of results.</summary>
  public static LocString UpdateReferences(
    Dictionary<IHasID, IHasID> refsToSwap,
    IHasID scanThingsReferencedBy);
}
