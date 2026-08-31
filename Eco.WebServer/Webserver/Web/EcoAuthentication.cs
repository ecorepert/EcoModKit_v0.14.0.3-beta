// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.EcoAuthentication
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

#nullable enable
namespace Eco.WebServer.Web;

/// <summary>Eco authentication handler, pulls the "authtoken" and "authtokentype" parameters from the query string and validates the user.</summary>
public class EcoAuthentication : AuthenticationHandler<AuthenticationSchemeOptions>
{
  /// <summary> Name of custom authentication type. </summary>
  public static readonly string AuthenticationType;
  /// <summary> Name of custom authentication scheme, which is referenced when setting it up. </summary>
  public static readonly string SchemeName;

  public EcoAuthentication(
    IOptionsMonitor<AuthenticationSchemeOptions> options,
    ILoggerFactory logger,
    UrlEncoder encoder,
    ISystemClock clock);

  /// <summary>
  /// Handle authentication. Returns a AuthenticateResult, which is created from a claims principal and a custom Eco claims identity.
  /// See "Principal and Identity Objects" for more information about users in ASP.NET.
  /// </summary>
  protected override Task<AuthenticateResult> HandleAuthenticateAsync();
}
