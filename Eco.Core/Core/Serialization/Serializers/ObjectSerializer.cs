// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ObjectSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

public class ObjectSerializer : IReferenceableSerializer, ISerializer
{
  protected SimpleSerializer parent;

  public bool IsNullableType { get; protected set; }

  public Type Type { get; protected set; }

  public string SchemaType { get; protected set; }

  public Dictionary<string, string> Schema { get; protected set; }

  public IObjectReferenceService ReferenceService { get; protected set; }

  public ref int ID { get; }

  public ObjectSerializer(SimpleSerializer parent);

  protected ObjectSerializer(
    SimpleSerializer parent,
    Type type,
    string schemaType,
    Dictionary<string, string> membersSchema);

  protected ObjectSerializer(
    SimpleSerializer parent,
    Type type,
    string schemaType,
    Dictionary<string, string> membersSchema,
    IObjectReferenceService referenceService);

  public virtual void Encode(BinaryWriter writer, object instance, SerializeFlags flags);

  /// <summary>
  /// This method may be used by inheritors and other classes from same module for more controlled serialization.
  /// </summary>
  /// <param name="serializer">Exact serializer to be used for instance encoding.</param>
  /// <param name="writer">binary writer.</param>
  /// <param name="instance">instance to be encoded.</param>
  /// <param name="flags"></param>
  protected internal void EncodeWith(
    ISerializer serializer,
    BinaryWriter writer,
    object instance,
    SerializeFlags flags);

  public DecodedObject DecodeReferenceable(BinaryReader reader);

  public object Decode(BinaryReader reader);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal static void EncodeReference(BinaryWriter writer, string typeName, int id);

  protected internal virtual DecodedObject DecodeObject(BinaryReader reader, int objTypeID);

  public void DecodeToArray(BinaryReader reader, Array array, int index);

  public void DecodeToMember(BinaryReader reader, object instance, MemberInfo memberInfo);

  protected internal virtual object DecodeInstance(BinaryReader reader);

  protected internal virtual void EncodeInstance(
    BinaryWriter writer,
    object instance,
    SerializeFlags flags);

  public void Skip(BinaryReader reader);

  protected internal virtual void SkipInstance(BinaryReader reader);

  public override string ToString();
}
