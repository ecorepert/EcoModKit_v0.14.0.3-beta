// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.IPropertySubscription
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Reflection;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Interface for property change subscriptions. Holds information about observable subject, invocation target and method. May be invoked to notify subscription.</summary>
public interface IPropertySubscription : ISubscription
{
  void Invoke();

  IObservable Subject { get; }

  object? Target { get; }

  MethodInfo Method { get; }

  string PropertyName { get; }

  bool IsAlive { get; }
}
