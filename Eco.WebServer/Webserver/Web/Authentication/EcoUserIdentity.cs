// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Authentication.EcoUserIdentity
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Players;
using System.Collections.Generic;
using System.Security.Claims;

#nullable enable
namespace Eco.WebServer.Web.Authentication;

/// <summary>
/// Custom ClaimsIdenty to pass Eco's User class through to controllers via HttpContext.User.Identity.
/// Use extension method Controller.GetUserFromContext() to retrive the User.
/// </summary>
public class EcoUserIdentity : ClaimsIdentity
{
  public User User { get; }

  public EcoUserIdentity(User user, IEnumerable<Claim>? claims, string? authenticationType);
}
