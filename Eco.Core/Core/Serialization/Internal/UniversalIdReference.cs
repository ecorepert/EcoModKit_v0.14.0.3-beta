// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Internal.UniversalIdReference
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Serialization.Internal;

/// <summary>Reference to <see cref="T:Eco.Core.Systems.UniversalIDs" /> object.</summary>
public class UniversalIdReference : IObjectReference
{
  public UniversalIdReference(int id);

  public object? GetReferencedObject();

  public bool TryGetReferencedObject(out object? obj);
}
