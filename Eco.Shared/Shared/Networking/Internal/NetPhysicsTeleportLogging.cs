// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Internal.NetPhysicsTeleportLogging
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Networking.Internal;

public static class NetPhysicsTeleportLogging
{
  /// <summary> Logs Physics data failure, tries to print needed data for debugging purposes. </summary>
  /// <param name="message"> The message to show before pushing the physics data details.</param>
  public static void LogPhysicsFailData(
    string message,
    NetPhysicsEntity netPhyEnt,
    NetObject netObj);
}
