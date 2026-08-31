// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ColorSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Utils;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

internal class ColorSerializer : ValueSerializer<Color>
{
  public override void EncodeValue(BinaryWriter writer, Color color, SerializeFlags flags);

  public override Color DecodeValue(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
