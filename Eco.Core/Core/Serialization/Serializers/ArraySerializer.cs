// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ArraySerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Base class for array serializers. Based on provided parameters to <see cref="M:Eco.Core.Serialization.Serializers.ArraySerializer.Create(System.Type,Eco.Core.Serialization.Serializers.ISerializer)" /> factory method it either creates <see cref="T:Eco.Core.Serialization.Serializers.DefaultArraySerializer" /> or <see cref="T:Eco.Core.Serialization.Serializers.ArraySerializer`1" /> (optimized version for <see cref="T:Eco.Core.Serialization.Serializers.ValueSerializer`1" />).</summary>
internal abstract class ArraySerializer : BasicSerializer
{
  internal abstract ISerializer ElementSerializer { get; }

  /// <summary>Factory method which returns best matching <see cref="T:Eco.Core.Serialization.Serializers.ArraySerializer" /> implementation.</summary>
  public static ArraySerializer Create(Type arrayType, ISerializer elementSerializer);

  protected ArraySerializer(Type arrayType);
}
