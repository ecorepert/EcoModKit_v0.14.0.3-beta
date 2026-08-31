// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.DirtySet`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>Component class to maintain a 'dirty' set of entries of type T that will periodically process and clear.
/// It will check whenever ticked, and whenever CleanTimer is ready, which must be initialized in the implementing class.</summary>
public class DirtySet<T> where T : class
{
  /// <summary>Initialize with a value for how long to wait between cleanings.</summary>
  public DirtySet(double cleanTimer);

  /// <summary>Mark a list of entires as dirty, to be processed at intervals in bulk.</summary>
  public void MarkDirty(IEnumerable<T> dirties);

  /// <summary>Mark a an entry as dirty, to be processed at intervals in bulk.</summary>
  public void MarkDirty(T dirty);

  /// <summary>Returns a list of entries when they're ready to be processed, removing them from the list.
  /// Will only return when CleanTimer has expired, and CleanTimer continuously resets even when no entries
  /// are in the dirty list (this it to allow entries to 'queue up', so they can be processed in bulk,
  /// meant for systems where a flurry of changes will happen in quick succession, such that the processing
  /// shouldnt be done immediately after the first change).</summary>
  public IReadOnlySet<T> DirtiesReadyToProcess();

  /// <summary>Clear dirty list without processing.</summary>
  public void Clear();

  public void UpdateNextTick();
}
