// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerInstanceInfo
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller.Internal;
using Eco.Shared.Concurrent;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>Class containing additional information about controller bounded to one or more clients.</summary>
internal readonly struct ControllerInstanceInfo : IEquatable<ControllerInstanceInfo>
{
  private readonly ControllerInstanceInfo.BoundedClients boundClients;

  public int ControllerID { get; }

  public bool Unbounded { get; }

  public object SyncRoot { get; }

  public ControllerInstanceInfo(int controllerID);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal ControllerBoundingLevel GetBoundingLevel(IMvcNetClient client);

  /// <summary>Checks if controller bounded to client no matter if controller's view synced or not.</summary>
  public bool IsBoundedToClient(IMvcNetClient client);

  /// <summary>Checks if controller bounded to client and view synced (or in pending views). May be used to ensure that usage of controller reference is safe.</summary>
  public bool IsSyncedToClient(IMvcNetClient client);

  /// <summary>Checks if controller bounded to client and view fully synced (or in pending views) with all <see cref="F:Eco.Shared.View.SyncFlags.MustRequest" /> properties. May be used to ensure that usage of fully synced controller reference is safe.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool IsFullySyncedToClient(IMvcNetClient client);

  /// <summary>Binds controller to client.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool BindClient(IMvcNetClient client);

  /// <summary>Unbinds controller from client.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool UnbindClient(IMvcNetClient client);

  /// <summary>Sets controller as synced to client. The client should be bounded with <see cref="M:Eco.Core.Controller.ControllerInstanceInfo.BindClient(Eco.Core.Controller.IMvcNetClient)" /> before that.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void SetSyncedTo(
    IMvcNetClient client,
    ControllerBoundingLevel syncLevel,
    ControllerBoundingLevel expectedSyncLevel);

  public IMvcNetClient[] GetClientsForNotification(IController controller, string propertyName);

  /// <summary>Unbinds all disconnected clients.</summary>
  public void Cleanup();

  public bool Equals(ControllerInstanceInfo other);

  public override bool Equals(object? obj);

  public override int GetHashCode();

  public static bool operator ==(ControllerInstanceInfo left, ControllerInstanceInfo right);

  public static bool operator !=(ControllerInstanceInfo left, ControllerInstanceInfo right);

  /// <summary>
  /// We have this nested class for reason of reducing allocated objects number. <see cref="T:Eco.Core.Controller.ControllerInstanceInfo" /> survives GC and ends up in Generation 2.
  /// Every object in Generation 2 increases time of full GC scan and it's size. With inheritance from <see cref="T:System.Collections.Generic.Dictionary`2" /> and moving state fields
  /// to that inherited class we replace ControllerInstanceInfo + Dictionary allocation with just Dictionary allocation because <see cref="T:Eco.Core.Controller.ControllerInstanceInfo" />
  /// is a struct and is allocation free.
  /// A.B.: After experiments I decided to use <see cref="T:System.Collections.Generic.Dictionary`2" /> with RW lock instead of one of concurrent collection alternatives.
  /// We may review this solution in future versions. All write locks are short - like Bind/Unbind controller - so read operations shouldn't suffer from these.
  /// At same time write operations only happen from cleanup code, at binding code which already heavy enough because of encoding
  /// and even if fight for lock with controller notification code may wait without significant impact on total execution time.
  /// For cleanup code it also totally uncritical to stay in a lock.
  /// <see cref="T:Eco.Shared.Concurrent.ReadWriteSpinSemaphore" /> used instead of <see cref="T:System.Threading.ReaderWriterLockSlim" /> or <see cref="T:System.Threading.ReaderWriterLock" /> because
  /// of big overhead per single lock object which we want to avoid because we may have hundred of thousands or even millions of bounded controllers.
  /// </summary>
  private sealed class BoundedClients : Dictionary<IMvcNetClient, ControllerBoundingLevel>
  {
    public readonly int ControllerID;
    public ReadWriteSpinSemaphore Semaphore;

    public BoundedClients(int controllerID);
  }
}
