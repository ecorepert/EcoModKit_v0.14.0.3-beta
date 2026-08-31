// Decompiled with JetBrains decompiler
// Type: Eco.Networking.ENet.ENetDelivery
// Assembly: Eco.Networking.ENet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00C02FAA-9424-481A-B463-D4AE2C8B3EB5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Networking.ENet.dll

using ENet;

#nullable enable
namespace Eco.Networking.ENet;

public readonly struct ENetDelivery
{
  public readonly Packet Packet;
  public readonly object Target;
  public readonly byte Channel;

  public ENetDelivery(Packet packet, object target, byte channel);
}
