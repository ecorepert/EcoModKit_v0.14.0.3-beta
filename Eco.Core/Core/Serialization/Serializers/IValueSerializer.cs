// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.IValueSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary>This interface helps to identify serializes which inherits from <see cref="T:Eco.Core.Serialization.Serializers.ValueSerializer`1" /> and get their <see cref="P:Eco.Core.Serialization.Serializers.IValueSerializer.ValueType" />.</summary>
public interface IValueSerializer
{
  Type ValueType { get; }
}
