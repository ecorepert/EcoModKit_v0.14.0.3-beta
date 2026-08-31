// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.PropertySubscriptionBase
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Reflection;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Base class for all property subscriptions.</summary>
public abstract class PropertySubscriptionBase : IPropertySubscription, ISubscription
{
  public IObservable Subject { get; protected set; }

  public string PropertyName { get; protected set; }

  public abstract object? Target { get; }

  public abstract MethodInfo Method { get; }

  public bool IsAlive { get; }

  public abstract void Invoke();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public virtual void Unsubscribe();
}
