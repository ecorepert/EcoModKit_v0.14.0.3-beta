// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.TrackedListPropSubscription
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Shared.View;

#nullable enable
namespace Eco.Core.Properties;

/// <summary>Used to subscribe and track a specific property of different entries saved inside an enumerable that implement the <see cref="T:Eco.Core.Utils.ITrackedEnumerable" /> interface.</summary>
public class TrackedListPropSubscription : ISubscription
{
  public TrackedListPropSubscription(
    #nullable disable
    ITrackedEnumerable targetList,
    PropertyChangedBeforeAfterEventHandler callback,
    string propertyName = null);

  public void Unsubscribe();
}
