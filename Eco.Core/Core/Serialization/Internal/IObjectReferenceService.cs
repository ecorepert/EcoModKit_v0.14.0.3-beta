// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Internal.IObjectReferenceService
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Serialization.Internal;

/// <summary>Service used by serializers for different reference types (like <see cref="T:Eco.Core.Systems.IHasID" /> or <see cref="T:Eco.Core.Systems.IHasReferenceableSerializableID" />).</summary>
public interface IObjectReferenceService
{
  /// <summary>Returns identifier for <paramref name="instance" />.</summary>
  int GetId(object instance);

  /// <summary>Makes <see cref="T:Eco.Core.Serialization.Internal.IObjectReference" /> for <paramref name="type" /> and <paramref name="id" />.</summary>
  DecodedObject MakeReference(Type type, int id);
}
