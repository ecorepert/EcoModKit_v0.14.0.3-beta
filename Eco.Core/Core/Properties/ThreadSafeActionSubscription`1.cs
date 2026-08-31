// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.ThreadSafeActionSubscription`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Utils;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Core.Properties;

/// <summary> A threadsafe action subscription. Stores the target and callback so it can be found be those too</summary>
public class ThreadSafeActionSubscription<T> : ISubscription
{
  public WeakReference<ThreadSafeAction<T>> Target;
  public Action<T> Callback;

  public ThreadSafeActionSubscription(ThreadSafeAction<T> target, Action<T> callback);

  public void Unsubscribe();
}
