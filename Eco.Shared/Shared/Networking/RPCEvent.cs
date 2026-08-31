// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RPCEvent
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>Handles BSON packaging for the RPC calls and used by <see cref="T:Eco.Shared.Networking.RPCManager" /></summary>
public struct RPCEvent
{
  public BSONObject Bson;
  public INetObject Obj;
  public INetClient Target;

  public string MethodName { get; }

  public RPCEvent(string methodName, INetObject obj, INetClient target, params object[] args);

  public void Send();

  public void SendNow();

  public Task SendNowAsync();

  public Task<T> SendNowAsync<T>();

  public Task SendAsync();

  public Task<T> SendAsync<T>();

  public RPCEvent WithCallback<T>(Action<T> callback);

  public RPCEvent WithCallback(Action callback);
}
