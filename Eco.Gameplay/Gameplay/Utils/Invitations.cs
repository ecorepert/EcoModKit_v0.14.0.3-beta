// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.Invitations
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Services;
using Eco.Shared.View;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Utils;

[Eco.Shared.Networking.Eco(true)]
public class Invitations : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A list of citizens or aliases (titles or demographics) that are invited and may accept.")]
  [ClientCanSelectAndAdd("Invite Citizens or Groups to Join", "Invite", "Invites", true)]
  public 
  #nullable disable
  ControllerAliasSet InvitationList { get; set; }

  [SyncToView(null, true)]
  public LocString Description { get; }

  public void Destroy();

  public void Clear();

  public bool IsInvited(IAlias alias);

  public void Initialize(
    LocString actionDesc,
    LocString membershipBenefit,
    ILinkable source,
    NotificationCategory tag,
    Func<User, Task<bool>> onAccept,
    Func<User, bool> isMember,
    string parentDeedLinkId);

  /// <summary>Accept incoming invitation and handle different states.</summary>
  public Task AcceptIfNotMember(User user);

  /// <summary>Remove invitation and delete mail in the process (if it's a demographics its not gonna be removed from the list so just remove the users mail).</summary>
  public void TryRemoveInvitation(INetObject caller, object obj);

  public ref int ControllerID { get; }
}
