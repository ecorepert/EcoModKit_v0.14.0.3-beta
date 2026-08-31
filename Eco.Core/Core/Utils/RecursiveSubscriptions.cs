// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.RecursiveSubscriptions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Shared.View;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>Helper object for implementing proper recursive subscriptions for the complex structures. For example, it is used in Election.cs for updating Description which includes information about different civics objects.</summary>
public class RecursiveSubscriptions
{
  public RecursiveSubscriptions(
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    Action<PropertyInfo, object> callback);

  /// <summary>Subscribe for the controller recursively, so changes in the nested objects are tracked too. Remember subscriptions for this controller for the future Unsubscribe process.</summary>
  public void SubscribeRecursive(IController controller);

  /// <summary>Clear all subscriptions for the controller. We won't forget anything cause all subscriptions were properly stored.</summary>
  public void UnsubscribeRecursive(IController controller);
}
