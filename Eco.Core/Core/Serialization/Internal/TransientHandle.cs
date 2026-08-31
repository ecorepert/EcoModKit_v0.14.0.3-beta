// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Internal.TransientHandle
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Serialization.Internal;

/// <summary><see cref="T:Eco.Core.Serialization.IPersistent" /> implementation for transient (non-serialized) objects. <see cref="P:Eco.Core.Serialization.IStorage.StorageHandle" /> may be used for modification locks and instead of null handling it is better to have such a transient handle which will prevent concurrent modifications, but won't serialize the object.</summary>
internal class TransientHandle : IPersistent
{
  public string? Name { get; }

  public string? GetAndEraseName();
}
