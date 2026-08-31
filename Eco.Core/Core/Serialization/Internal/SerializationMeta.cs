// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Internal.SerializationMeta
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Serialization.Internal;

/// <summary>Meta data for serialization like version, schema etc.</summary>
public class SerializationMeta
{
  public double Version { get; set; }

  public double OriginalVersion { get; set; }

  public string? Schema { get; set; }

  public ImmutableHashSet<string> AppliedMigrations { get; set; }

  public bool VersionOrSchemaChanged { get; }

  /// <summary>Loads serialization meta from <paramref name="dataStore" />.</summary>
  public static Task<SerializationMeta> LoadAsync(DataStore dataStore);

  /// <summary>Saves serialization meta to <paramref name="dataStore" />.</summary>
  public Task SaveAsync(DataStore dataStore);

  /// <summary>Flushes all modified meta files as pairs of file name and content.</summary>
  internal IEnumerable<(string FileName, string Content)> FlushDirtyFiles();
}
