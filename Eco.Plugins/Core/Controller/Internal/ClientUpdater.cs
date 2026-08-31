// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.Internal.ClientUpdater
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Networking;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Controller.Internal;

/// <summary>Helper class for background processing of changed properties and notifying bounded clients.</summary>
internal static class ClientUpdater
{
  public static void Initialize();

  public static void AddTaskCompletionAwaiter(TaskCompletionSource task);

  private readonly struct NotificationKey : IEquatable<ClientUpdater.NotificationKey>
  {
    public readonly IMvcNetClient? RelatedClient;
    public readonly NetworkChannel Channel;
    public readonly int[]? SortedClientIds;

    public NotificationKey(in ClientNotification notification);

    public bool Equals(ClientUpdater.NotificationKey other);

    public override bool Equals(object? obj);

    public override int GetHashCode();
  }
}
