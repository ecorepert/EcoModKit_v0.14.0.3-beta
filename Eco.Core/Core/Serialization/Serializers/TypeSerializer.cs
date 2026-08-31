// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.TypeSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

internal class TypeSerializer : ValueSerializer<Type>
{
  protected const int Null = -1;
  protected const int FullTypeName = -2;
  protected readonly SimpleSerializer parent;

  public TypeSerializer(SimpleSerializer parent);

  public override void EncodeValue(BinaryWriter writer, Type? type, SerializeFlags flags);

  public override Type? DecodeValue(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
