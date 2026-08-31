// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.IHasReferenceableSerializableID
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Systems;

/// <summary>Marker interface for objects with serializable universal ID which may be serialized by reference (like <see cref="T:Eco.Core.Systems.IHasID" />). These objects by default serialized by reference and need to use <see cref="T:Eco.Shared.Serialization.ForceSerializeFullObjectAttribute" /> for full object serialization.</summary>
public interface IHasReferenceableSerializableID : IHasSerializableID, IHasUniversalID
{
}
