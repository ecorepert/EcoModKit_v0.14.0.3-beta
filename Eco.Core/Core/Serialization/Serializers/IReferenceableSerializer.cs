// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.IReferenceableSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Internal;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

public interface IReferenceableSerializer : ISerializer
{
  /// <summary>When not null then object may be encoded as reference (preferred if not SerializeFlags.ForceSerializeFullObject).</summary>
  IObjectReferenceService? ReferenceService { get; }

  DecodedObject DecodeReferenceable(BinaryReader reader);
}
