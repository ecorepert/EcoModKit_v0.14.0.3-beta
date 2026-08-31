// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ISubscriptions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.View;

/// <summary>Untyped version of <see cref="T:Eco.Shared.View.ISubscriptions`1" /> with <see cref="M:Eco.Shared.View.ISubscriptions.UnsubscribeAll" /> and <see cref="M:Eco.Shared.View.ISubscriptions.ReleaseSubscriptionsList" /> methods which may be useful for destroy/dispose methods which unaware of subscriptions list type.</summary>
public interface ISubscriptions
{
  /// <summary>Unsubscribe all subscriptions in the subscriptions list.</summary>
  void UnsubscribeAll();

  /// <summary><see cref="M:Eco.Shared.View.ISubscriptions.UnsubscribeAll" /> and release subscriptions list.</summary>
  void ReleaseSubscriptionsList();
}
