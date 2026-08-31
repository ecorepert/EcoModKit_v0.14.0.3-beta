// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Internal.UniversalIdReferenceService
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization.Internal;

/// <summary><see cref="T:Eco.Core.Serialization.Internal.IObjectReferenceService" /> for <see cref="T:Eco.Core.Systems.IHasReferenceableSerializableID" /> objects.</summary>
/// <inheritdoc cref="T:Eco.Core.Serialization.Internal.IObjectReferenceService" />
public class UniversalIdReferenceService : IObjectReferenceService
{
  public static readonly UniversalIdReferenceService Instance;

  public int GetId(object instance);

  public DecodedObject MakeReference(Type type, int id);
}
