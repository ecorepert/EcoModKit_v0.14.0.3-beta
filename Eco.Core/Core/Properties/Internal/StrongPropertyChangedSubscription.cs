// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.Internal.StrongPropertyChangedSubscription
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling;
using Eco.Shared.View;
using System.ComponentModel;

#nullable enable
namespace Eco.Core.Properties.Internal;

/// <summary>Like <see cref="T:Eco.Core.Properties.Internal.PropertyChangedSubscription" /> but holds a strong reference to the watched object
/// instead of a <see cref="T:System.WeakReference`1" />. This allows <see cref="M:Eco.Core.Properties.Internal.StrongPropertyChangedSubscription.Unsubscribe" /> to work from a finalizer
/// context, where the GC has already cleared weak references. Used exclusively by the WatchSubMember
/// subscription guard, where cleanup on property reassignment is guaranteed by the watch machinery.</summary>
internal class StrongPropertyChangedSubscription : ISubscription
{
  /// <summary>Watch for a specific named property changing by subscribing to the event raised by fody.</summary>
  public StrongPropertyChangedSubscription(
    INotifyPropertyChanged watch,
    string name,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Watch for ANY property changing, as raised by fody.</summary>
  public StrongPropertyChangedSubscription(
    INotifyPropertyChanged watch,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Unsubscribe and release references. Safe to call from a finalizer context.</summary>
  public void Unsubscribe();

  /// <summary>Finalizes an instance of the <see cref="T:Eco.Core.Properties.Internal.StrongPropertyChangedSubscription" /> class.
  /// When the owning root object is garbage-collected, the ConditionalWeakTable releases this subscription,
  /// making it finalizable. Cleans up the event handler on the watched object.</summary>
  ~StrongPropertyChangedSubscription();

  /// <summary>Return true if the instance being watched is the passed in value.</summary>
  public bool IsSubject(INotifyPropertyChanged subject);
}
