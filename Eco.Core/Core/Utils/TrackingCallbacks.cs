// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.TrackingCallbacks
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;
using System;

#nullable disable
namespace Eco.Core.Utils;

public class TrackingCallbacks
{
  public Func<INetObject, (object ObjectToAdd, bool Success)> OnTryAdd { get; set; }

  public Func<INetObject, object, Result> OnTryRemove { get; set; }

  public ThreadSafeAction<INetObject, object> OnAdd { get; set; }

  public ThreadSafeAction<INetObject, object> OnRemove { get; set; }

  public ThreadSafeAction OnChanged { get; set; }

  /// <summary>Subscribe to <see cref="P:Eco.Core.Utils.TrackingCallbacks.OnAdd" /> and <see cref="P:Eco.Core.Utils.TrackingCallbacks.OnRemove" />.</summary>
  public void SubscribeAddRemove(Action<INetObject, object> action);

  /// <summary>Unsubscribe to <see cref="P:Eco.Core.Utils.TrackingCallbacks.OnAdd" /> and <see cref="P:Eco.Core.Utils.TrackingCallbacks.OnRemove" />.</summary>
  public void UnsubscribeAddRemove(Action<INetObject, object> action);

  public void Clear();
}
