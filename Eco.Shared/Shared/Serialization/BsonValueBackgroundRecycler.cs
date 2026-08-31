// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BsonValueBackgroundRecycler
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Serialization;

/// <summary>BSON Values background recycler. <see cref="M:Eco.Shared.Serialization.BsonValueBackgroundRecycler.RecycleInBackground(Eco.Shared.Serialization.BSONValue)" /> may be used to move <see cref="T:Eco.Shared.Serialization.BSONValue" /> recycling out of executing thread to save CPU resources where it is critical.</summary>
public static class BsonValueBackgroundRecycler
{
  /// <summary>Recycles <paramref name="bsonValue" /> in background. Not guaranteed when it will be recycled. May be used in performance critical code to save CPU time on recycling, but usually it is better to use <see cref="M:Eco.Shared.Serialization.BSONValue.Recycle" /> for faster returning resources back to pool.</summary>
  public static void RecycleInBackground(this BSONValue bsonValue);
}
