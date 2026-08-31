// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.EnumSerializer`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

internal class EnumSerializer<T> : ValueSerializer<T>, IEnumSerializer, ISerializer where T : struct, Enum
{
  public override void EncodeValue(BinaryWriter writer, T instance, SerializeFlags flags);

  public override T DecodeValue(BinaryReader reader);
}
