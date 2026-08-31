// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.EcoSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Serialization;

/// <summary>Read more about serialization and migrations in README.md.</summary>
public static class EcoSerializer
{
  public const double CurrentSerializerVersion = 11.01071;
  public static readonly (float Number, string Name) LastCompatibleVersion;

  public static bool MigratedTo10 { get; }

  public static MigrationManager? MigrationManager { get; }

  /// <summary> Serializes <paramref name="obj" /> to <paramref name="stream" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SerializeTo(Stream stream, object obj);

  public static MemoryStream Serialize(object obj);

  /// <summary> Serializes <paramref name="obj" /> to <paramref name="stream" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SerializeTo<T>(Stream stream, T obj);

  public static MemoryStream Serialize<T>(T obj);

  public static T DeserializeObject<T>(Stream stream);

  public static object Deserialize(Stream stream);

  public static T Deserialize<T>(Stream stream);

  /// <summary>Loads objects with serialized universal ids.</summary>
  public static void LoadUniversalIDs();

  public static void FinishDeserialization();

  public static bool NewVersion { get; }

  public static double LastVersion { get; }

  public static bool IsOlderVersion(double version);

  public static ValueTask InitializeAsync(DataStore dataStore);

  public static void AddDataStoreMigration<T, TMigration>(float sinceVersion) where TMigration : class, IDataStoreMigration, new();

  public static void WithSerializer(IVersionSerializer versionSerializer, Action action);

  private class MigrationSinceVersionComparer : IComparer<(Type Type, double SinceVersion)>
  {
    public static EcoSerializer.MigrationSinceVersionComparer Instance;

    public int Compare((Type Type, double SinceVersion) x, (Type Type, double SinceVersion) y);
  }
}
