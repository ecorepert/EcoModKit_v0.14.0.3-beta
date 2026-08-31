// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetStats
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Networking;

public struct NetStats
{
  public static NetStats Empty;
  public ulong BytesReceived;
  public ulong BytesSent;
  public ulong PacketsLost;
  public ulong PacketsSent;
  public float LastReceiveTime;
  public float LastSendTime;
  public float RoundTripTime;
}
