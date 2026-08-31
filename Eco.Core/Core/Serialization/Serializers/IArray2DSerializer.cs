// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.IArray2DSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Interface for <see cref="T:Eco.Core.Serialization.Serializers.Array2DSerializer`1" /> which allows to access type info without known generic type.</summary>
public interface IArray2DSerializer
{
  ISerializer ElementSerializer { get; }

  Type ArrayType { get; }

  Type ElementType { get; }
}
