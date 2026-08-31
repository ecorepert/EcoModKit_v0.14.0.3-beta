// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.BasicSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

public abstract class BasicSerializer : ISerializer
{
  public Type? Type { get; }

  public string SchemaType { get; }

  public ref int ID { get; }

  protected BasicSerializer(Type? type, string schemaType);

  public abstract void Encode(BinaryWriter writer, object? instance, SerializeFlags flags);

  public abstract object? Decode(BinaryReader reader);

  public void DecodeToArray(BinaryReader reader, Array array, int index);

  public void DecodeToMember(BinaryReader reader, object instance, MemberInfo member);

  public virtual void Skip(BinaryReader reader);
}
