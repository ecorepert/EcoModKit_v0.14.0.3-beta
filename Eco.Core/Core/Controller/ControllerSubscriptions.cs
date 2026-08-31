// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerSubscriptions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;
using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>Holds controller subscriptions for <see cref="T:Eco.Core.Controller.ControllerManager" />. Compatible with <see cref="T:Eco.Shared.View.IObservable" /> interface for Subscriptions System.</summary>
internal class ControllerSubscriptions : IObservable
{
  public ConcurrentDictionary<string, ImmutableList<IPropertySubscription>> ChangedCallbacks { get; }

  /// <summary> Name used for debug purposes. </summary>
  public string DebugName { get; }

  public ControllerSubscriptions(Type controllerType);

  bool IObservable.IsAvailable(string propName);

  /// <summary>Adds <paramref name="newSubscription" /> if it wasn't already added. Returns <c>false</c> if existed.</summary>
  public bool SubscribeUnique(IPropertySubscription newSubscription);

  /// <summary>Same as <see cref="M:Eco.Core.Controller.ControllerSubscriptions.SubscribeUnique(Eco.Shared.View.IPropertySubscription)" />, but will report fail in Debug mode if subscription isn't unique. It won't add new subscription though!</summary>
  public void Subscribe(IPropertySubscription subscription);

  /// <summary>Removes previously added with <see cref="M:Eco.Core.Controller.ControllerSubscriptions.Subscribe(Eco.Shared.View.IPropertySubscription)" /> or <see cref="M:Eco.Core.Controller.ControllerSubscriptions.SubscribeUnique(Eco.Shared.View.IPropertySubscription)" /> subscription.</summary>
  public void Unsubscribe(IPropertySubscription subscription);

  /// <summary>Removes all subscriptions with <paramref name="callback" /> for <paramref name="propertyName" />.</summary>
  public bool Unsubscribe(string propertyName, Action callback);

  /// <summary>Notifies all subscriptions about property change.</summary>
  public void NotifyChanged(string propertyName);

  /// <summary>Checks if <see cref="F:Eco.Core.Controller.ControllerSubscriptions.controllerType" /> has property with specified name.</summary>
  public bool HasProperty(string propertyName);

  /// <summary>Removes all "dead" subscriptions. Skipped when no dead refs were observed since the last scan and the time fallback has not elapsed — avoids re-running ImmutableList.RemoveAll under CAS contention every cleanup cycle.</summary>
  public void Cleanup();
}
