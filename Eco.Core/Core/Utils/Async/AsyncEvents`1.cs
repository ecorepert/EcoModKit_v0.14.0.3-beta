// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Async.AsyncEvents`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Utils.Async;

/// <summary>
/// Helper class for working with C# events as async stream of event values. It works as a bridge between event-based APIs and async/await based APIs.
/// 
/// For example we have NAT device discovery library with <c>StartDiscovery</c>, <c>StopDiscovery</c> methods and a <c>DeviceDiscovered</c> event and then
/// we need to discover an appropriate NAT device in async method. NAT Device itself has async methods which we need to use to check if the device is an appropriate.
/// An application may be adapted to event based API, but in case if your existing code is already uses async/await pattern or you just prefer to use async/await code
/// for better readability and less errors then you can use <see cref="T:Eco.Core.Utils.Async.AsyncEvents`1" />.
/// 
/// Classic approach with events may look like:
/// <example><code><![CDATA[
/// class NATDeviceDiscoverer
/// {
///     Task<bool> discoveryInProgress;
/// 
///     public event Action<NATDevice> AppropriateDeviceDiscovered;
/// 
///     void DiscoverAppropriateDevice()
///     {
///         NATLib.DeviceDiscovered += OnDeviceDiscovered;
///         NATLib.StartDiscovery();
///     }
/// 
///     void OnDeviceDiscovered(object subject, NATDeviceDiscoveredArgs args)
///     {
///         var device = args.Device;
///         if (discoveryInProgress != null)
///            discoveryInProgress.ContinueWith(t => t.IsCompleted && !t.Result ? CheckDevice(device) : Task.CompletedTask); // don't need to check if already found appropriate device
///         else
///            discoveryInProgress = CheckDevice(device);
///     }
/// 
///     async Task<bool> CheckDevice(NATDevice device)
///     {
///         var isAppropriate = await device.Check();
///         if (!isAppropriate) return false;
///         NATLib.DeviceDiscovered -= OnDeviceDiscovered;
///         NATLib.StopDiscovery();
///         AppropriateDeviceDiscovered.Invoke(device);
///         return isAppropriate;
///     }
/// }
/// ]]></code></example>
/// and if you need to add a timeout it become even more complex.
/// 
/// With <see cref="T:Eco.Core.Utils.Async.AsyncEvents`1" /> you can rewrite it much simpler:
/// <example><code><![CDATA[
/// class NATDeviceDiscoverer
/// {
///     async Task<NATDevice> DiscoverAppropriateDevice()
///     {
///         using var discoveredDevices = AsyncEvents<NATDevice>.Subscribe<Action<NATDevice>>(discoverNext => (_, args) => discoverNext(args.Device), handler => NATLib.DeviceDiscovered += handler, handler => NATLib.DeviceDiscovered -= handler);
///         NATLib.StartDiscovery();
///         try
///         {
///             await foreach (var device in discoveredDevices)
///             {
///                 if (await device.Check())
///                    return device;
///             }
///         }
///         finally
///         {
///            NATLib.StopDiscovery();
///         }
///     }
/// }
/// ]]></code></example>
/// </summary>
public sealed class AsyncEvents<T> : IAsyncEnumerable<T>, IDisposable, IAsyncDisposable
{
  /// <summary>Subscribes to events of type <typeparamref name="TEventHandler" />. <paramref name="handlerFactory" /> should create an event handler which invokes callback with an item received from event.</summary>
  public static AsyncEvents<T> Subscribe<TEventHandler>(
    Func<Func<T, bool>, TEventHandler> handlerFactory,
    Action<TEventHandler> subscribe,
    Action<TEventHandler> unsubscribe)
    where TEventHandler : Delegate;

  /// <summary>Returns <see cref="T:System.Collections.Generic.IAsyncEnumerator`1" /> which returns all items received from events as infinite async stream.</summary>
  public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default (CancellationToken));

  public void Dispose();

  public ValueTask DisposeAsync();
}
