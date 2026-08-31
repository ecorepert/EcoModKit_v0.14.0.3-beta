// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.IHasSerializableID
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Core.Systems;

/// <summary>If an object needs to have its ID serialized, it must inherit from this instead.</summary>
public interface IHasSerializableID : IHasUniversalID
{
  [Serialized]
  [DontClone]
  int SerializedID { get; set; }
}
