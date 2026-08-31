// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONValueFactory`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Serialization;

/// <summary>Reusable <see cref="T:Eco.Shared.Serialization.BSONValue" /> values factory.</summary>
internal class BSONValueFactory<T> : BSONValueFactory where T : BSONValue
{
  public BSONValueFactory(Func<T> newInstance);

  /// <summary>Recycles <paramref name="value" /> making it available for re-usage.</summary>
  public void Recycle(T value);

  internal override void ClearPool();
}
