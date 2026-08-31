// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.NoOpPropertySubscription
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Reflection;

#nullable enable
namespace Eco.Shared.View;

/// <summary>
/// No operation <see cref="T:Eco.Shared.View.PropertySubscription" />. Will do nothing on callback.
/// May be used as replacement for removed subscription during subscription list processing. I.e. we have list [sub1, sub2] and sub2 removed in sub1 callback.
/// If we just remove it then list iteration will fail with <see cref="T:System.IndexOutOfRangeException" /> when accessing index 1 of removed sub2.
/// To avoid this we can just replace removed subscription with <see cref="T:Eco.Shared.View.NoOpPropertySubscription" /> until list processing finish and then remove all no-op subscriptions from the list.
/// </summary>
public sealed class NoOpPropertySubscription : PropertySubscriptionBase
{
  public override void Invoke();

  public override object Target { get; }

  public override MethodInfo Method { get; }
}
