// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Internal.IObjectReference
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Serialization.Internal;

/// <summary>Used during deserialization for object references for late resolving (i.e. from <see cref="T:Eco.Core.Systems.IRegistrar" />.</summary>
public interface IObjectReference
{
  /// <summary>Gets referenced object. Usually only available when all object deserialized and fixups may be applied.</summary>
  object? GetReferencedObject();

  /// <summary>Tries to get referenced object. Returns <c>false</c> if that not possible.</summary>
  bool TryGetReferencedObject(out object? obj);
}
