// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.Internal.PropertyChangedSubscription
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling;
using Eco.Shared.View;
using System.ComponentModel;

#nullable enable
namespace Eco.Core.Properties.Internal;

/// <summary>A subscription that watches a property changing triggered by fody.</summary>
internal class PropertyChangedSubscription : ISubscription
{
  /// <summary>Watch for a specific named property changing by subscribing to the event raised by fody.</summary>
  public PropertyChangedSubscription(
    INotifyPropertyChanged watch,
    string name,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Watch for ANY property changing, as raised by fody.</summary>
  public PropertyChangedSubscription(
    INotifyPropertyChanged watch,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Unsubscribe, if our weak ref is still active (object wasnt deleted already).</summary>
  public void Unsubscribe();

  /// <summary>Return true if the instance being watched is the passed in value.</summary>
  public bool IsSubject(INotifyPropertyChanged subject);
}
