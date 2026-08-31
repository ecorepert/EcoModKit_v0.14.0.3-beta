// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.Internal.TypeSubscriptions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.PropertyHandling.Internal;

/// <summary>Internal class used by <see cref="T:Eco.Core.PropertyHandling.PropertyChanges" /> for global subscriptions (per-property and all-properties).</summary>
internal class TypeSubscriptions
{
  /// <summary>Invokes all type subscriptions (both per property and for all properties).</summary>
  public virtual void Invoke(object sender, MemberChangedBeforeAfterEventArgs args);

  /// <summary>Adds <paramref name="handler" /> as callback for changes of <paramref name="propertyName" />.</summary>
  public void Add(string propertyName, PropertyChangedBeforeAfterEventHandler handler);

  /// <summary>Removes <paramref name="handler" /> from callbacks for changes of <paramref name="propertyName" />.</summary>
  public void Remove(string propertyName, PropertyChangedBeforeAfterEventHandler handler);

  /// <summary>Adds <paramref name="handler" /> as callback for any property changes.</summary>
  public void Add(PropertyChangedBeforeAfterEventHandler handler);

  /// <summary>Removes <paramref name="handler" /> from any property changes handlers.</summary>
  public void Remove(PropertyChangedBeforeAfterEventHandler handler);
}
