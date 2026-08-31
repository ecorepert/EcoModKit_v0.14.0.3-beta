// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.INetworkInterceptor
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>
/// <para>Allows an object to intercept <seealso cref="T:Eco.Shared.Serialization.BSONObject" />s being sent.</para>
/// <para>
/// See <seealso cref="M:Eco.Shared.Networking.NetObject.AddNetworkInteceptor(Eco.Shared.Networking.INetworkInterceptor)" /> and <seealso cref="M:Eco.Shared.Networking.NetObject.RemoveNetworkInterceptor(Eco.Shared.Networking.INetworkInterceptor)" />
/// for adding/removing <seealso cref="T:Eco.Shared.Networking.INetworkInterceptor" /> instances.
/// </para>
/// </summary>
public interface INetworkInterceptor
{
  bool InterceptSendEvent(
    NetworkEvent netEvent,
    BSONObject bsonObj,
    INetClient target,
    INetObject netObj);
}
