// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.Internal.ControllerUpdater
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Pools.Collections;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Controller.Internal;

/// <summary>Helper class for background processing of changed properties and notifying bounded clients.</summary>
internal class ControllerUpdater : AutoSingleton<ControllerUpdater>
{
  public void CollectUpdates(
    PoolableListWrapper<ClientNotification> list,
    out List<string>? propertiesNames);

  /// <summary>Notifies clients bounded for <paramref name="propertyName" /> in background. Not guaranteed when it will be notified. Used to avoid slowdown threads by viewNotifications from callback. </summary>
  public static void NotifyClientsInBackground(
    IController controller,
    string propertyName,
    IMvcNetClient? client = null);
}
