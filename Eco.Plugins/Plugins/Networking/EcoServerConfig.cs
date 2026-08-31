// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.EcoServerConfig
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Shared.Localization;
using Eco.Shared.States;
using Eco.Shared.Validation;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Plugins.Networking;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
public class EcoServerConfig
{
  [IgnoreHostedWorlds]
  [LocDescription("Whether or not to post this server to Strange Loop Games public server listings.")]
  public bool PublicServer { get; set; }

  [LocDescription("A string describing when this server typically has active players.  Each character represents an hour, starting from Monday 12am. 0 is 'Rarely', 1 is 'Sometimes', 2 is 'Usually'.  This is automatically set when a client starts the server directly, but can also be set manually. Time must be specified in GMT!  Easiest way to get this string is copy playtime.eco in the settings folder after creating it by running the Eco client.")]
  public string Playtime { get; set; }

  [LocDescription("The address of a Discord server used for players on this world.  Should only include the portion after 'https://discord.gg/' as that will be filled in.")]
  public string DiscordAddress { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("If not empty, require this password to connect to the server, unless the connecting user is on the whitelist.")]
  public string Password { get; set; }

  [IgnoreHostedWorlds]
  public string HashedPassword { get; }

  [LocDescription("The name of this server. Max 250 characters.")]
  public string Name { get; set; }

  [LocDescription("A long description of the server to display when selected in the server browser.  Use \\n for line endings.  Max 500 characters.")]
  public string DetailedDescription { get; set; }

  [LocDescription("Category for public server listing within the server browser.")]
  public ServerCategory ServerCategory { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Internal IP Address for the traffic. If not specified then Any (0.0.0.0) address will be used. Requires a restart to take effect.")]
  public string IPAddress { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Remote address which should be used to access the server. If not specified then will be automatically detected. Usually you should ignore it, but if you want to set exact connection address then it may be useful. Uses GameServerPort if no explicit port specified. If you want to auto-discovery remote address then you can use '*' instead of remote_host. Format: remote_host[:port] or *[:port].")]
  public string RemoteAddress { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Web Server Url. If not specified then remote IP address will be used. Usually you should ignore it, but if you want to use DNS name or hide web server behind a proxy (for SSL or friendly name) then it may be useful. Uses default port if not explicit port specified (HTTP - 80, HTTPS - 443). Format: http(s)://my.server[:port].")]
  [UrlValidation(ErrorMessage = "The value must start with http:// or https://. ")]
  public string WebServerUrl { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Port for game traffic. UDP only. Requires a restart to take effect.")]
  public int GameServerPort { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Bind port for web traffic. TCP only. Requires a restart to take effect.")]
  public int WebServerPort { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Bind port for RCON traffic. TCP only. Requires a restart to take effect. More info available here: https://wiki.play.eco/en/RCON")]
  public int RconServerPort { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Port for Steam game server traffic. Used only in offline mode on Windows and Linux. Requires a restart to take effect.")]
  public ushort SteamServerPort { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("RCON IP Address for the traffic. If not specified then Any (0.0.0.0) address will be used. Requires a restart to take effect. More info available here: https://wiki.play.eco/en/RCON")]
  public string RconIPAddress { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Password for authenticating incoming RCON traffic. A password must be provided to enable RCON support. More info available here: https://wiki.play.eco/en/RCON")]
  public string RconPassword { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Rate at which the server sends updates to clients, per second.  (1 - 60)")]
  public int Rate { get; set; }

  public int FaithResetValue { get; }

  [LocDescription("Max number of slots allowed on at one time (negative is infinite).")]
  public int DefaultSlots { get; set; }

  [LocDescription("Number of additional slots allowed beyond Max Connections for users who have been assigned queue priority permissions. Set to -1 for infinite.")]
  public int ReservedSlots { get; set; }

  [LocDescription("How many users can be in loading at same time? Set to -1 for infinite. ")]
  public int MaxUsersLoadingAtSameTime { get; set; }

  public bool CanJoin(Client client, int currentUsers, int loadingUsersCount);

  [LocDescription("Server unique identifier (generates automatically). Should be cleaned-up for new server.")]
  [IgnoreHostedWorlds]
  [ReadOnly(true)]
  [DontSerializeIntoTemplate]
  public Guid ID { get; set; }

  [LocDescription("Server passport which used to confirm it owns ID. Protects from server substitution. Should be cleaned-up for new server.")]
  [Browsable(false)]
  [DontSerializeIntoTemplate]
  public Guid Passport { get; set; }

  [LocDescription("Universal Plug and Play (UPnP) allows to auto-configure external traffic mapping for servers behind NAT")]
  [IgnoreHostedWorlds]
  [LocDisplayName("UPnP Enabled")]
  public bool UPnPEnabled { get; set; }

  [LocDescription("This server will be used as fallback to proxy traffic between server and client if no direct connection possible. Should be in following format: host_or_ip:port")]
  [LocDisplayName("Relay Server Address")]
  public string RelayServerAddress { get; set; }
}
