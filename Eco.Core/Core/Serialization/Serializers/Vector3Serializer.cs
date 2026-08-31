// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.Vector3Serializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;
using System.Numerics;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

internal class Vector3Serializer : ValueSerializer<Vector3>
{
  public override void EncodeValue(BinaryWriter writer, Vector3 vector, SerializeFlags flags);

  public override Vector3 DecodeValue(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
