// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ValueSerializer`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

public abstract class ValueSerializer<T> : BasicSerializer, IValueSerializer
{
  public Type ValueType { get; }

  protected ValueSerializer(string schemaType);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public sealed override object? Decode(BinaryReader reader);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public sealed override void Encode(BinaryWriter writer, object? instance, SerializeFlags flags);

  public abstract void EncodeValue(BinaryWriter writer, T? instance, SerializeFlags flags);

  public abstract T? DecodeValue(BinaryReader reader);

  public override string ToString();
}
