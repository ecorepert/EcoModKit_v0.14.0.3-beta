// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.WorldPosition3iSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Math;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

internal class WorldPosition3iSerializer : ValueSerializer<WorldPosition3i>
{
  public override void EncodeValue(BinaryWriter writer, WorldPosition3i pos, SerializeFlags flags);

  public override WorldPosition3i DecodeValue(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
