// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.WeakPropertySubscription
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Reflection;

#nullable enable
namespace Eco.Shared.View;

/// <summary>// Weak reference wrapper class for delegate storage without user defined removal.</summary>
public class WeakPropertySubscription : IPropertySubscription, ISubscription
{
  public string PropertyName { get; }

  public IObservable Subject { get; }

  public bool IsAlive { get; }

  public object? Target { get; }

  public MethodInfo Method { get; }

  public WeakPropertySubscription(IObservable subject, string propertyName, Action callback);

  public void Invoke();

  public void Unsubscribe();
}
