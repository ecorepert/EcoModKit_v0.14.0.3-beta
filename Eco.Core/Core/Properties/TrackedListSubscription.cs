// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.TrackedListSubscription
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Utils;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Core.Properties;

/// <summary>Used to subscribe and track enumerables that implement the ITrackedList interface.</summary>
public class TrackedListSubscription : ISubscription
{
  public TrackedListSubscription(ITrackedEnumerable target, Action callback);

  public void Unsubscribe();
}
