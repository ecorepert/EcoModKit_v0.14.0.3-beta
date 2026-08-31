// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.ReferenceTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Core.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

public static class ReferenceTracker
{
  public static ThreadSafeAction<IHasID> ReferencedByUpdated;
  public static ThreadSafeDictionary<IHasID, List<IHasID>> References;
  public static ThreadSafeDictionary<IHasID, List<IHasID>> ReferencedBy;

  public static void AddReference(IHasID source, IHasID target);

  public static void ClearReferences(IHasID source);

  public static IEnumerable<IHasID> GetReferencedBy(IHasID id);

  /// <summary>Given a list of IDs, find all the things that could reference any of them which we track.</summary>
  public static HashSet<IHasID> GetAllReferencedBy(IEnumerable<IHasID> idSet);
}
