// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ISubscribableEvent
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Interface for subscribable events (i.e. <see cref="T:Eco.Shared.View.SubscribableEvent`1" />). Declared as interface so all classes may work with common interface no matter which type of wrapped event.</summary>
public interface ISubscribableEvent
{
  void Add(Delegate handler);

  void Remove(Delegate handler);
}
