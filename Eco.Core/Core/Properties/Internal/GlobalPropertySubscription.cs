// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.Internal.GlobalPropertySubscription
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling;
using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Core.Properties.Internal;

/// <summary>Subscription tracking for wathing all instances.</summary>
internal class GlobalPropertySubscription : ISubscription
{
  /// <summary>Create a subscription to a given member on ALL instances of a given type.</summary>
  public GlobalPropertySubscription(
    Type type,
    string memberName,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Create a subscription to ALL members on ALL instances of a given type.</summary>
  public GlobalPropertySubscription(Type type, PropertyChangedBeforeAfterEventHandler callback);

  public void Unsubscribe();
}
