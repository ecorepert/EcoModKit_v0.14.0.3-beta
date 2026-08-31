// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.INetObjectManager
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>Interface for <see cref="T:Eco.Shared.Networking.INetObject" /> manager.</summary>
public interface INetObjectManager
{
  /// <summary>Allocates and returns next <see cref="T:Eco.Shared.Networking.INetObject" /> identifier.</summary>
  int GetNextID();

  /// <summary>Adds <paramref name="netObject" /> with associated <paramref name="id" /> to <see cref="T:Eco.Shared.Networking.INetObjectManager" />.</summary>
  void Add(INetObject netObject, int id);

  /// <summary>Removes <paramref name="netObject" /> from <see cref="T:Eco.Shared.Networking.INetObjectManager" />.</summary>
  void Remove(INetObject netObject);
}
