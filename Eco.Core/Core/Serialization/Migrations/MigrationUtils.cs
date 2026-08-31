// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.MigrationUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DataMigrations;
using Eco.Core.Serialization.Serializers;
using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

internal static class MigrationUtils
{
  /// <summary> Serializes null object value as <see cref="T:System.IO.BinaryReader" />. </summary>
  public static BinaryReader SerializeNullAsReader();

  public static BinaryReader SerializeAsReader<TValue>(ISerializer serializer, TValue? instance);

  public static BinaryReader SerializeInstanceAsReader(ObjectSerializer serializer, object instance);

  /// <summary>Serializes <paramref name="value" /> as <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput" />.</summary>
  public static ReaderDataInput SerializeAsReaderDataInput<TValue>(
    ISerializer serializer,
    string schemaType,
    TValue? value);

  public static BinaryReader EncodeAsReader(Action<BinaryWriter> encoder);

  public static BinaryReader EncodeReferenceAsReader(string typeName, int id);

  /// <summary>Copies content migrated with <paramref name="migration" /> to <paramref name="writer" />.</summary>
  public static void CopyMigratedContent(
    IMigration migration,
    MigrationContext context,
    BinaryWriter writer);

  /// <summary>
  /// Copies serializer content from reader to writer without actually deserializing it.
  /// </summary>
  /// <param name="serializer">serializer.</param>
  /// <param name="reader">reader to read from.</param>
  /// <param name="writer">writer to write content to.</param>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void CopySerializerContent(
    ISerializer serializer,
    BinaryReader reader,
    BinaryWriter writer);

  /// <summary>
  /// Copies serializer content from reader to writer without actually deserializing it.
  /// </summary>
  /// <param name="serializer">serializer.</param>
  /// <param name="reader">reader to read from.</param>
  /// <param name="outputStream">output stream to write content to.</param>
  public static void CopySerializerContent(
    ISerializer serializer,
    BinaryReader reader,
    Stream outputStream);

  /// <summary>
  /// Copies serializer instance content from reader to writer without actually deserializing it (it uses <see cref="M:Eco.Core.Serialization.Serializers.ObjectSerializer.SkipInstance(System.IO.BinaryReader)" /> internally
  /// which only copies instance content without header - object flags and polymorphic object id).
  /// </summary>
  /// <param name="serializer">object serializer.</param>
  /// <param name="reader">reader to read from.</param>
  /// <param name="writer">writer to write content to.</param>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void CopySerializerInstanceContent(
    ObjectSerializer serializer,
    BinaryReader reader,
    BinaryWriter writer);

  /// <summary>
  /// Copies serializer instance content from reader to writer without actually deserializing it (it uses <see cref="M:Eco.Core.Serialization.Serializers.ObjectSerializer.SkipInstance(System.IO.BinaryReader)" /> internally
  /// which only copies instance content without header - object flags and polymorphic object id).
  /// </summary>
  /// <param name="serializer">object serializer.</param>
  /// <param name="reader">reader to read from.</param>
  /// <param name="outputStream">output stream to write content to.</param>
  public static void CopySerializerInstanceContent(
    ObjectSerializer serializer,
    BinaryReader reader,
    Stream outputStream);
}
