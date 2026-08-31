// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.EnumSkipperSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Serializer skipping no more exising enums.</summary>
internal class EnumSkipperSerializer : BasicSerializer
{
  public EnumSkipperSerializer(string schemaType);

  public override void Encode(BinaryWriter writer, object? instance, SerializeFlags flags);

  /// <summary>Return string instead of enum value. Usually this value ignored anyway, but string value may be useful for migrations.</summary>
  public override object Decode(BinaryReader reader);

  public override string ToString();
}
