// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ISerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

public interface ISerializer
{
  Type? Type { get; }

  string SchemaType { get; }

  ref int ID { get; }

  void Encode(BinaryWriter writer, object? instance, SerializeFlags flags);

  object? Decode(BinaryReader reader);

  void DecodeToArray(BinaryReader reader, Array array, int index);

  void DecodeToMember(BinaryReader reader, object instance, MemberInfo memberInfo);

  void Skip(BinaryReader reader);
}
