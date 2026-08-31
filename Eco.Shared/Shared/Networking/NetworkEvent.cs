// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetworkEvent
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Networking;

public enum NetworkEvent
{
  ClientUpdate = 0,
  ClientUpdateGeneral = 0,
  ClientUpdateChunks = 1,
  ClientUpdateExtra = 2,
  ClientUpdateLast = 3,
  ClientUpdateUnreliable = 3,
  ClientLogin = 4,
  RPC = 5,
  RPCResponse = 6,
  DisconnectReason = 7,
  Views = 8,
  Blobs = 9,
  BigMessageWarning = 10, // 0x0000000A
}
