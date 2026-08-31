// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.IThreadUnsafeSubscriptions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.View;

/// <summary>Thread-unsafe implementation of <see cref="T:Eco.Shared.View.ISubscriptions`1" />. Suitable for client code where all subscriptions happens in main-thread.</summary>
/// <inheritdoc />
public interface IThreadUnsafeSubscriptions : ISubscriptions<Subscriptions>, ISubscriptions
{
  new Subscriptions? Subscriptions { get; set; }

  Subscriptions? ISubscriptions<Subscriptions>.Subscriptions { get; }

  Subscriptions ISubscriptions<Subscriptions>.GetOrCreateSubscriptionsList();

  void ISubscriptions.ReleaseSubscriptionsList();
}
