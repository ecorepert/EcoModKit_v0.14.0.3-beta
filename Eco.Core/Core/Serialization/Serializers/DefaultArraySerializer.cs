// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.DefaultArraySerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Default implementation of <see cref="T:Eco.Core.Serialization.Serializers.ArraySerializer" /> which uses straightforward unoptimized algorithm for encoding and decoding when optimized version not possible.</summary>
internal class DefaultArraySerializer : ArraySerializer
{
  internal override ISerializer ElementSerializer { get; }

  public DefaultArraySerializer(Type arrayType, ISerializer elementSerializer);

  public override void Encode(BinaryWriter writer, object instance, SerializeFlags flags);

  public override object Decode(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
