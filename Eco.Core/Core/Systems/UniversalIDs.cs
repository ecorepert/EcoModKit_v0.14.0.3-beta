// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.UniversalIDs
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Systems;

/// <summary>Management of objects with a universal id. Tracks them and allows finding by ID.</summary>
public static class UniversalIDs
{
  public static 
  #nullable disable
  IEnumerable<IHasUniversalID> AllObjects { get; }

  /// <summary>Loads objects to <see cref="T:Eco.Core.Systems.UniversalIDs" /> storage.</summary>
  public static void Load(IEnumerable<IHasUniversalID> objs);

  /// <summary>Unloads objects from <see cref="T:Eco.Core.Systems.UniversalIDs" /> storage. May be used in tests.</summary>
  internal static void Unload();

  /// <summary>Remove entries whose weak-references no longer point to anything.</summary>
  public static void Clean();

  /// <summary>Get the object of the given ID. It may fail if the weak reference has expired on a deleted object,
  /// in which case false is returned.</summary>
  public static bool TryGetByID(int id, out IHasUniversalID val);

  /// <summary>Return the IHasUniversalID with the given ID, or null if it's not found.</summary>
  public static IHasUniversalID GetOrNull(int id);

  /// <summary>Return the object with the given ID, cast to expected Type T. Returns null if not found or different type than expected. </summary>
  public static T GetOrNull<T>(int id) where T : class, IHasUniversalID;

  /// <summary> Get the ID, assigning a new one if none is set yet.</summary>
  public static int GetOrCreateID(this IHasUniversalID obj);

  /// <summary>Claims <paramref name="id" /> for <paramref name="obj" />. Can only be used when serialized IDs loaded and if object doesn't yet have an ID.</summary>
  public static void ClaimID(this IHasUniversalID obj, int id);

  public static void Remove(IHasUniversalID obj);
}
