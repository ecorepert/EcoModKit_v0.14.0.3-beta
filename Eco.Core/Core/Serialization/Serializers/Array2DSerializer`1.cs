// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.Array2DSerializer`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Can serialize to a compressed Array2d or a regular Array2d.</summary>
internal class Array2DSerializer<TElementType> : BasicSerializer, IArray2DSerializer
{
  public Array2DSerializer(Type arrayType, ISerializer elementSerializer);

  public override void Encode(BinaryWriter writer, object? instance, SerializeFlags flags);

  public override object? Decode(BinaryReader reader);

  public override void Skip(BinaryReader reader);

  public ISerializer ElementSerializer { get; }

  public Type ArrayType { get; }

  public Type ElementType { get; }
}
