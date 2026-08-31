// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.Array2DSkipperSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary><see cref="T:Eco.Shared.Utils.Array2D`1" /> skipper (for 2d arrays of removed serialized types).</summary>
internal class Array2DSkipperSerializer : BasicSerializer
{
  public Array2DSkipperSerializer(string schemaType, ISerializer elementSerializer);

  public override void Encode(BinaryWriter writer, object? instance, SerializeFlags flags);

  public override object? Decode(BinaryReader reader);
}
