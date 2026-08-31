// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.MigrationManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Core.Serialization.Migrations.DataMigrations;
using Eco.Core.Serialization.Serializers;
using Eco.Shared.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Class responsible for migration stuff. It holds migrations, migration types for different versions and can apply them.</summary>
public class MigrationManager
{
  public InfoBuilder MigrationInfo;
  public InfoBuilder MigrationLog;

  public SimpleSerializer OldVersion { get; }

  public SimpleSerializer NewVersion { get; }

  public bool HasMigrations { get; }

  public ObjectSerializer ObjectSerializer { get; }

  public CachedObjectSerializer CachedObjectsSerializer { get; }

  public void Init(SimpleSerializer oldVersion, SimpleSerializer newVersion, double schemaVersion);

  public void AddDataStoreMigration(Type type, IDataStoreMigration dataStoreMigration);

  /// <summary>Adds all migrations from enumerable with same <paramref name="sinceVersion" />.</summary>
  public void AddMigrations(double sinceVersion, IEnumerable<IClassMigration> migrations);

  public void AddMigration(double sinceVersion, IClassMigration classMigration);

  /// <summary>Adds <see cref="T:Eco.Core.Serialization.Migrations.Attributes.MigratedTypeAttribute" /> which will be used to access erased information for migrated type (i.e. if it was struct and was changed to class or vice versa).</summary>
  public void AddMigratedType(double sinceVersion, MigratedTypeAttribute migratedType);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void MigrateDataStore(
    DataStore.ExclusiveAccess dataStoreAccess,
    Type type,
    Action<object, string> createFunc);

  /// <summary>Checks if <paramref name="type" /> is a type which only used during migration. Such a type should be fully serialized instead of <see cref="P:Eco.Core.Serialization.Migrations.MigrationManager.CachedObjectsSerializer" /> usage.</summary>
  public bool IsMigrationOnlyType(Type type);

  public void SetMigrationTypes(IEnumerable<MigrationType> migrationTypes);

  internal void InitMigrations();

  internal ObjectSerializer CreateClassMigrationSerializer(Type type, SerializerSchema schema);

  /// <summary>Tries to create <see cref="T:Eco.Core.Serialization.Serializers.MigrationChainSerializer" />. Success if there any registered migrations for <paramref name="schemaType" />.</summary>
  internal bool TryCreateMigrationChainSerializer(
    string schemaType,
    SerializerSchema schema,
    [NotNullWhen(true)] out ISerializer? serializer);

  /// <summary>Add extra serializers for <see cref="T:Eco.Core.Serialization.Migrations.MigrationManager" />.</summary>
  internal void AddSerializers();

  /// <summary>Migrates <see cref="T:System.Type" /> if it was renamed.</summary>
  internal Type? MigrateType(string typeName);

  public ISerializer GetSerializerFromId(int id);

  /// <summary>Tries to find serializer for <paramref name="schemaType" />. If not exists then returns default <see cref="P:Eco.Core.Serialization.Migrations.MigrationManager.ObjectSerializer" /> for class schema types or throws exception.</summary>
  public ISerializer GetSerializerFromSchemaType(string schemaType);

  /// <summary>Tries to find serializer for <paramref name="schemaType" />. If not exists then either will try to create new serializer for container types (dictionary or collection) or returns default <see cref="P:Eco.Core.Serialization.Migrations.MigrationManager.ObjectSerializer" /> for class schema types.</summary>
  public ISerializer GetOrCreateSerializerFromSchemaType(string schemaType);

  /// <summary>Migrates <paramref name="context" /> and returns <see cref="T:Eco.Core.Serialization.DecodedObject" /> (either reference or instance).</summary>
  public DecodedObject DecodeObject(MigrationContext context);

  /// <summary>Migrates <paramref name="context" /> up to <paramref name="tillVersion" /> if specified or to latest version.</summary>
  internal void Migrate(MigrationContext context, double? tillVersion = null);

  /// <summary>Decodes object using provided schema.</summary>
  /// <param name="schema">schema.</param>
  /// <param name="reader">reader.</param>
  /// <returns>object instance.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public DecodedObject DecodeObject(ImmutableSerializerSchema schema, BinaryReader reader);

  public ISerializer GetOrCreateSerializer(ImmutableSerializerSchema schema);

  /// <summary>Shortcut for <inheritdoc cref="M:Eco.Core.Serialization.Migrations.MigrationManager.AddReferencedObjectSerializer(System.String,System.Type,System.Func{System.Object,System.Object})" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public ReferencedObjectSerializer AddReferencedObjectSerializer<TKey, TReference>(
    Func<TKey?, TReference?> referenceResolver);

  /// <summary>Adds new <see cref="T:Eco.Core.Serialization.Serializers.ReferencedObjectSerializer" /> created for provided arguments.</summary>
  public ReferencedObjectSerializer AddReferencedObjectSerializer(
    string keySchemaType,
    Type type,
    Func<object?, object?> referenceResolver);

  /// <summary>
  /// Gets or creates versioned serializer. If migration for <paramref name="schema" /> required then it will start from <paramref name="version" /> instead of current schema version.
  /// Typical use-case if you have a <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" /> which performs migration on a member which has migrations before and after that data migration.
  /// Then you fist migrate the member up-to version compatible with data migration then perform modifications for member from data modification itself and serialize it back with data migration version.
  /// When member will be decoded it will apply all migrations after the version of data migration.
  /// </summary>
  public ObjectSerializer GetOrCreateVersionedSerializer(
    ImmutableSerializerSchema schema,
    double version);

  public ObjectSerializer GetOrCreateObjectSerializer(ImmutableSerializerSchema schema);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public ImmutableSerializerSchema CreateSchema(string schemaType);

  public ImmutableSerializerSchema CreateMemberlessSchema(string schemaType);

  public ImmutableSerializerSchema CreateSchema(
    string schemaType,
    ObjectSerializer membersSerializer);

  public ImmutableSerializerSchema CreateSchema(SerializerSchema schema);

  public ImmutableSerializerSchema ChangeSchemaType(
    ImmutableSerializerSchema schema,
    string schemaType);

  public ImmutableSerializerSchema ChangeSchemaMember(
    ImmutableSerializerSchema schema,
    string oldMemberName,
    string newMemberName,
    string newMemberType);

  public ImmutableSerializerSchema RemoveSchemaMember(
    ImmutableSerializerSchema schema,
    string memberName);

  public ImmutableSerializerSchema AddSchemaMember(
    ImmutableSerializerSchema schema,
    string memberName,
    string memberType);

  /// <summary>
  /// Reads schema, returns decoded data for every requested member and returns member ranges mapping to positions in the stream.
  /// Reader positioned at the end of schema data after call to the method.
  /// </summary>
  public Dictionary<IDataInput, ReaderDataInput> ReadMembers(
    BinaryReader reader,
    IDictionary<string, MemberDataInput> members,
    ImmutableSerializerSchema schema,
    out Dictionary<string, (long Start, long End)> memberRanges);

  /// <summary>
  /// Reads schema, returns decoded data for every requested member and returns member ranges mapping to positions in the stream.
  /// Reader positioned at the end of schema data after call to the method.
  /// </summary>
  /// <param name="reader">binary reader to read data from.</param>
  /// <param name="instanceStream">stream with instance data which will advance with <paramref name="reader" />. It may be reader's base stream or tapped stream from <see cref="T:Eco.Core.Utils.Streams.ReadOnlyForkStream" />.</param>
  /// <param name="members">set of requested member names.</param>
  /// <param name="schema">schema describing data to read.</param>
  /// <param name="memberRanges">output dictionary with mapping between member names and they reader's positions.</param>
  /// <returns>dictionary with requested members data.</returns>
  public Dictionary<IDataInput, ReaderDataInput> ReadMembers(
    BinaryReader reader,
    Stream instanceStream,
    IDictionary<string, MemberDataInput> members,
    ImmutableSerializerSchema schema,
    out Dictionary<string, (long Start, long End)> memberRanges);

  /// <summary>
  /// Reads schema, saves to <c>data</c> decoded data for every requested member and returns member ranges mapping to positions in the stream.
  /// Reader positioned at the end of schema data after call to the method.
  /// </summary>
  /// <param name="reader">binary reader to read data from.</param>
  /// <param name="instanceStream">stream with instance data which will advance with <paramref name="reader" />. It may be reader's base stream or tapped stream from <see cref="T:Eco.Core.Utils.Streams.ReadOnlyForkStream" />.</param>
  /// <param name="members">set of requested member names.</param>
  /// <param name="schema">schema describing data to read.</param>
  /// <param name="data">data dictionary to store requested members data.</param>
  /// <param name="memberRanges">output dictionary with mapping between member names and they reader's positions.</param>
  public void ReadMembersTo(
    BinaryReader reader,
    Stream instanceStream,
    IDictionary<string, MemberDataInput> members,
    ImmutableSerializerSchema schema,
    Dictionary<IDataInput, ReaderDataInput> data,
    out Dictionary<string, (long Start, long End)> memberRanges);

  /// <summary></summary>
  public void EncodeWith(
    ISerializer serializer,
    BinaryWriter writer,
    object value,
    SerializeFlags flags = SerializeFlags.None);

  public Type? GetTypeBySchemaType(string schemaType);

  /// <summary>
  /// Returns if type is nullable in specific schema version.
  /// </summary>
  /// <param name="schemaType">schema type.</param>
  /// <param name="version">schema version.</param>
  /// <returns><c>true</c> - if schema type nullable in specified schema version.</returns>
  public bool IsNullableType(string schemaType, double version);

  /// <summary>
  /// Copies schema content from reader to writer without actually deserializing it.
  /// </summary>
  /// <param name="schema">schema.</param>
  /// <param name="reader">reader to read from.</param>
  /// <param name="writer">writer to write content to.</param>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void CopySchemaContent(
    ImmutableSerializerSchema schema,
    BinaryReader reader,
    BinaryWriter writer);

  /// <summary>Skips schema content from reader without actually deserializing it.</summary>
  /// <param name="schema">schema.</param>
  /// <param name="reader">reader to skip from.</param>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void SkipSchemaContent(ImmutableSerializerSchema schema, BinaryReader reader);

  public void LogMigrationInfo();

  /// <summary>Helper struct for querying versions migrations with <see cref="F:Eco.Core.Serialization.Migrations.MigrationManager.MigrationsQuery.tillVersion" /> support.</summary>
  private readonly struct MigrationsQuery
  {
    private readonly double? tillVersion;

    public MigrationsQuery(double? tillVersion);

    /// <summary>Returns versioned migrations for <paramref name="mapping" />. Optionally applying <see cref="F:Eco.Core.Serialization.Migrations.MigrationManager.MigrationsQuery.tillVersion" /> constraint.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryGetVersionedMigrations<T>(
      VersionedTypeMapping<T> mapping,
      string schemaType,
      double sinceVersion,
      [NotNullWhen(true)] out IEnumerable<VersionedObject<T>>? objects);
  }
}
