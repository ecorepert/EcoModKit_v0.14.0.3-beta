// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.EnumerableSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Serializer for enumerable collections, but not dictionaries (lists, sets etc).</summary>
public class EnumerableSerializer : BasicSerializer, IInstanceDecoder
{
  public 
  #nullable disable
  Type ElementType { get; }

  public ISerializer ElementSerializer { get; }

  public EnumerableSerializer(Type enumerableType, Type elementType, ISerializer elementSerializer);

  public override void Encode(BinaryWriter writer, object instance, SerializeFlags flags);

  public object Decode(BinaryReader reader, object instance);

  public override object Decode(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
