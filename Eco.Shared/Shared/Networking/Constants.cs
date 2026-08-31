// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Constants
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Net;

#nullable disable
namespace Eco.Shared.Networking;

public static class Constants
{
  public const double PingTimeoutSeconds = 30.0;
  public const int PingMaxAttempts = 10;
  public const double PingAttemptIntervalSeconds = 1.0;
  public const int ConnectionRetryInterval = 3;
  public const int MaxConnectionAttempts = 5;
  public const string MasterServerAddress = "masterserver.eco.strangeloopgames.com";
  public const string MasterServerAddressForClient = "masterserver-eco.strangeloopgames.com";
  public const int MasterServerPort = 3000;
  public const int MasterServerTimeoutSeconds = 105;
  public const byte MasterServerProtocolVersion = 3;
  public static readonly Constants.AuthBranch AuthType;
  public static string AuthServerAddress;
  public static string AccountsServerAddress;
  public static string TwitchEbsAddress;
  public const int StrangeCloudServerHeartbeatTime = 90;
  public const int StrangeCloudUserHeartbeatTime = 180;
  /// <summary>REST API url of Master Server for server listing.</summary>
  public static readonly string MasterServerRestApiUrl;
  public const byte ClientServerProtocolVersion = 2;
  public static readonly string MetaFileName;

  public static int ConnectionTimeoutSeconds { get; }

  public static bool UseLocalStrangeCloud { get; }

  public static string StrangeCloudAddress { get; }

  public static IPEndPoint MasterServerEndPoint { get; }

  /// <summary>Enum to determine current auth environment.</summary>
  /// <remarks>See <see cref="F:Eco.Shared.Networking.Constants.AuthServerAddress" /> for reference.</remarks>
  public enum AuthBranch
  {
    Develop,
    Production,
  }
}
