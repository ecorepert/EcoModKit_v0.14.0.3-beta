// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONValue`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Serialization;

public abstract class BSONValue<T> : BSONValue where T : BSONValue<T>
{
  public sealed override void Recycle();

  protected abstract bool TryPerformRecycle();

  protected void ThrowMultipleRecycleError();
}
