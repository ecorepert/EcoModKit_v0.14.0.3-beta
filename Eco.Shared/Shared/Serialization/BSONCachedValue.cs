// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONCachedValue
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Serialization;

/// <summary>
/// <see cref="T:Eco.Shared.Serialization.BSONCachedValue" /> may be used to cache any other <see cref="T:Eco.Shared.Serialization.BSONValue" /> and to be used in place of it. Cached <see cref="T:Eco.Shared.Serialization.BSONValue" /> will be pre-serialized to byte array and helps to save serialization time.
/// When decoded it will be deserialized as a cached BSONValue. There no need for additional handling on receiving side.
/// </summary>
public class BSONCachedValue : BSONValue
{
  /// <summary>Encodes <paramref name="value" /> to binary form and saves it to <see cref="F:Eco.Shared.Serialization.BSONCachedValue.CachedBytes" />. Returned <see cref="T:Eco.Shared.Serialization.BSONCachedValue" /> can't be modified. Cached value will be recycled!</summary>
  public static BSONCachedValue Cache(BSONValue? value);

  /// <summary>Recycle does nothing, because usually cached value shared between multiple BSON objects.</summary>
  public override void Recycle();
}
