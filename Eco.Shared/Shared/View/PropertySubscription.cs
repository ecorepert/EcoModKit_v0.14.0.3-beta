// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.PropertySubscription
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Reflection;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Default property subscription implementation which works with provided subject, property name and callback.</summary>
internal sealed class PropertySubscription : PropertySubscriptionBase, ISubscription
{
  public Action Callback { get; protected set; }

  public override object? Target { get; }

  public override MethodInfo Method { get; }

  public void Init(IObservable subject, string propertyName, Action callback);

  public void Recycle();

  public override void Invoke();

  void ISubscription.ReturnToPool();
}
