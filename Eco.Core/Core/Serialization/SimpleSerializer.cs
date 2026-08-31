// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.SimpleSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Internal;
using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Serialization;

public class SimpleSerializer
{
  public 
  #nullable disable
  string Schema { get; }

  public static Type GetType(string typeName);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool TryGetSerializerForType(Type type, [MaybeNullWhen(false)] out ISerializer serializer);

  public ISerializer GetSerializerForType(Type type);

  public SerializerSchema GetSerializerSchema(Type type);

  internal ISerializer GetSerializerFromID(int id);

  internal ISerializer GetSerializerFromSchemaType(string schemaType);

  internal bool TryGetSerializerFromSchemaType(string schemaType, out ISerializer serializer);

  /// <summary>Returns <see cref="T:System.ComponentModel.Design.IReferenceService" /> for <paramref name="type" /> if exits.</summary>
  internal bool TryGetReferenceService(Type type, [MaybeNullWhen(false)] out IObjectReferenceService referenceService);

  /// <summary>Tries to make <see cref="T:Eco.Core.Serialization.Internal.IObjectReference" /> for <paramref name="typeName" /> and <paramref name="id" />. Fails when id is 0 or typeName is null, non-existing type name or isn't referenceable.</summary>
  internal bool TryMakeReference(string typeName, int id, out DecodedObject reference);

  /// <summary>Decodes reference from <paramref name="typeName" /> and <paramref name="id" />. Applies migrations for reference if necessary.</summary>
  internal DecodedObject DecodeReference(string typeName, int id);

  public void LogError(string error);

  internal ISerializer AddObjectSerializerBySchemaType(ObjectSerializer serializer);

  /// <summary>Adds <paramref name="serializer" /> to type mapping.</summary>
  internal ISerializer AddObjectSerializerByType(Type type, ObjectSerializer serializer);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal ISerializer AddSerializerById(ISerializer serializer);

  internal ISerializer GetOrCreateSerializerFromSchemaType(
    string schemaType,
    ISerializer defaultClassSerializer = null);

  internal ISerializer GetOrCreateSerializerForType(Type type);

  public SimpleSerializer(
    SimpleSerializer newSerializer,
    string schema,
    MigrationManager migrationManager,
    double version = 0.0);

  public SimpleSerializer();

  public MemoryStream Serialize(object obj);

  /// <summary> Serializes <paramref name="obj" /> to <paramref name="stream" />. </summary>
  public void SerializeTo(Stream stream, object obj);

  public object Deserialize(Stream stream);

  public MemoryStream Serialize<T>(T obj);

  /// <summary> Serializes <paramref name="obj" /> to <paramref name="stream" />. </summary>
  public void SerializeTo<T>(Stream stream, T obj);

  public T Deserialize<T>(Stream stream);

  public void Skip(Stream stream);

  public void OnFinishDeserialization();

  private class SchemaTypeComparer : IComparer<string>
  {
    public static readonly SimpleSerializer.SchemaTypeComparer Instance;

    public int Compare(string x, string y);
  }
}
