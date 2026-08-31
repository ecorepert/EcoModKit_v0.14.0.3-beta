// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserPermissionManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[TypeConverter(typeof (ExpandableObjectConverter))]
public class UserPermissionManager
{
  [LocDescription("Users on the whitelist do not need to enter a password to connect to a passworded server.  Use either SLG ID or STEAMID64")]
  public UserIDList WhiteList { get; set; }

  [LocDescription("Blacklisted users are denied connection to the server.  Use either SLG ID or STEAMID64")]
  public TimeUserIDList BlackList { get; set; }

  [LocDescription("Muted users are not allowed to use chat on the server.  Use either SLG ID or STEAMID64")]
  public TimeUserIDList MuteList { get; set; }

  [LocDescription("Admins are allowed to use the chat commands. (/ban, /give, etc.)  Use either SLG ID or STEAMID64")]
  public UserIDList Admins { get; set; }

  [LocDescription("Users assigned to a queue priority will advance to the front of the line of players with a lower number priority when trying to connect while the server is full.  Use either SLG ID or STEAMID64")]
  public SerializedSynchronizedCollection<QueuePriority> QueuePriorities { get; set; }

  [LocDescription("Users who have reserved slots at login queue.")]
  public UserIDList UsersWithReservedSlotsAtQueue { get; set; }

  public IEnumerable<TimeUserIDList> TimedLists { get; }

  internal bool IsIgnored(User user, User ignoredUser);
}
