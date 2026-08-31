// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ISubscription
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.View;

/// <summary>Interface for all subscription classes. May be either <see cref="T:Eco.Shared.View.Subscriptions" /> for subscriptions group or <see cref="T:Eco.Shared.View.IPropertySubscription" />.</summary>
public interface ISubscription
{
  void Unsubscribe();

  /// <summary>Optional ReturnToPool method (returns subscription to pool if possible).</summary>
  void ReturnToPool();
}
