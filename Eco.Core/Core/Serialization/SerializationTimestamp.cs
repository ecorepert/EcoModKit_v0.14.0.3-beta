// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.SerializationTimestamp
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary>
/// This struct should be used for auto-generated serialization timestamps which then may be used to check if serialized version is up to date.
/// When loaded it always contains last timestamp when it was serialized which may be used to ensure serialized versions contains actual copy and invalidate it if required (i.e. for height caches).
/// Can be just added to serialized class which aware about serialization timestamp.
/// IMPORTANT: It should be non-readonly field! If copied (i.e. when assigned by value) then it will contain snapshot value for <see cref="P:Eco.Core.Serialization.SerializationTimestamp.LastSerializedValue" />.
/// </summary>
[Serialized]
public struct SerializationTimestamp
{
  /// <summary>Contains last serialized <see cref="P:Eco.Core.Serialization.SerializationTimestamp.Value" /> (actually timestamp when it was last time serialized and persisted). The value is comparable with <see cref="P:Eco.Shared.Time.TimeUtil.Seconds" />.</summary>
  public readonly double LastSerializedValue { get; }

  public SerializationTimestamp(double lastSerializedValue);

  /// <summary>May be implicitly converted to <see cref="T:System.Double" /> (will use <see cref="P:Eco.Core.Serialization.SerializationTimestamp.LastSerializedValue" />).</summary>
  public static implicit operator double(SerializationTimestamp timestamp);
}
