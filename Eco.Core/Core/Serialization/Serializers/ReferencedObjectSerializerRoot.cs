// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ReferencedObjectSerializerRoot
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Internal;
using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary>
/// Root Referenced Object serializer for schema type lookup. When serializer ID isn't known and only schema type is available it may be resolved to <see cref="T:Eco.Core.Serialization.Serializers.ReferencedObjectSerializerRoot" /> which then delegates logic to concrete <see cref="T:Eco.Core.Serialization.Serializers.ReferencedObjectSerializer" />.
/// It saves concrete serializer ID as part of instance data, so even if just instance data is available it still possible to get concrete referenced object serializer and resolve it to valid instance.
/// </summary>
public class ReferencedObjectSerializerRoot : ObjectSerializer
{
  public const string ReferencedObjectSchemaType = "referencedobject";

  /// <summary>Constructor for root ReferencedObjectSerializer. It not intended to be used for encoding/decoding, but as abstract root delegating to real instances of <see cref="T:Eco.Core.Serialization.Serializers.ReferencedObjectSerializer" />.</summary>
  public ReferencedObjectSerializerRoot(SimpleSerializer parent);

  protected ReferencedObjectSerializerRoot(
    SimpleSerializer parent,
    Type type,
    ISerializer keySerializer,
    Func<object?, object?> referenceResolver);

  /// <summary>Encodes key from <paramref name="keyReader" /> as a reference by the key to <paramref name="writer" />. </summary>
  public void EncodeAsReference(BinaryWriter writer, BinaryReader keyReader);

  public override void Encode(BinaryWriter writer, object key, SerializeFlags flags);

  protected internal override void EncodeInstance(
    BinaryWriter writer,
    object instance,
    SerializeFlags flags);

  protected internal override DecodedObject DecodeObject(BinaryReader reader, int objTypeID);

  protected internal override void SkipInstance(BinaryReader reader);

  /// <summary>Object reference with custom <see cref="F:Eco.Core.Serialization.Serializers.ReferencedObjectSerializerRoot.referenceResolver" /> function.</summary>
  private class Reference : IObjectReference
  {
    public Reference(ReferencedObjectSerializerRoot serializer, object? key);

    public object? GetReferencedObject();

    public bool TryGetReferencedObject(out object? obj);

    public override string ToString();
  }
}
