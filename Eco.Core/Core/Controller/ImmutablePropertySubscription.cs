// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ImmutablePropertySubscription
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>Immutable implementation of <see cref="T:Eco.Shared.View.IPropertySubscription" /> used by controller to prevent concurrent modifications (i.e. <see cref="T:Eco.Shared.View.PropertySubscription" /> may be recycled and destroy it's state).</summary>
public class ImmutablePropertySubscription : IPropertySubscription, ISubscription
{
  public ImmutablePropertySubscription(IObservable subject, string propertyName, Action callback);

  public IObservable Subject { get; }

  public string PropertyName { get; }

  public object Target { get; }

  public MethodInfo Method { get; }

  public bool IsAlive { get; }

  public void Invoke();

  public void Unsubscribe();
}
