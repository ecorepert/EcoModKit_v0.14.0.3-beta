// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.DictionarySkipperSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Class for skipping dictionaries using inner types that were removed.</summary>
internal class DictionarySkipperSerializer : BasicSerializer
{
  internal DictionarySkipperSerializer(
    string schemaType,
    ISerializer keySerializer,
    ISerializer valueSerializer);

  public override void Encode(BinaryWriter writer, object? instance, SerializeFlags flags);

  public override object? Decode(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
