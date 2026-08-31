// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.StrangeCloudInterface
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using StrangeCloud.Service.Client.Contracts;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

#nullable enable
namespace StrangeCloud.Service.Client;

/// <summary>Interface for interacting with Strange Cloud services.</summary>
public static class StrangeCloudInterface
{
  public static HttpClient HttpClient = new HttpClient();
  public static bool Authenticated = false;
  public static IAuthenticationClient? AuthenticationClient;
  public static IUserAccountClient? UserAccountClient;
  public static IMarketplaceClient? MarketplaceClient;
  public static IWorldsClient? WorldsClient;
  public static IPasswordResetClient? PasswordResetClient;
  public static IFlagsClient? FlagsClient;
  public static IVoiceClient? VoiceClient;
  public static Action? StrangeUserUpdated;
  public static Action? AuthenticatedEvent;

  public static string AuthToken { get; private set; } = string.Empty;

  /// <summary>The user account stored in the cloud. If null, we're playing in offline mode. Can also be offline but filled with cached user.</summary>
  public static StrangeUser? StrangeUser { get; private set; }

  public static void Initialize(string strangeCloudUrl, HttpClient? client = null)
  {
    if (client != null)
      StrangeCloudInterface.HttpClient = client;
    StrangeCloudInterface.AuthenticationClient = (IAuthenticationClient) new StrangeCloud.Service.Client.AuthenticationClient(strangeCloudUrl, StrangeCloudInterface.HttpClient);
    StrangeCloudInterface.UserAccountClient = (IUserAccountClient) new StrangeCloud.Service.Client.UserAccountClient(strangeCloudUrl, StrangeCloudInterface.HttpClient);
    StrangeCloudInterface.MarketplaceClient = (IMarketplaceClient) new StrangeCloud.Service.Client.MarketplaceClient(strangeCloudUrl, StrangeCloudInterface.HttpClient);
    StrangeCloudInterface.WorldsClient = (IWorldsClient) new StrangeCloud.Service.Client.WorldsClient(strangeCloudUrl, StrangeCloudInterface.HttpClient);
    StrangeCloudInterface.PasswordResetClient = (IPasswordResetClient) new StrangeCloud.Service.Client.PasswordResetClient(strangeCloudUrl, StrangeCloudInterface.HttpClient);
    StrangeCloudInterface.FlagsClient = (IFlagsClient) new StrangeCloud.Service.Client.FlagsClient(strangeCloudUrl, StrangeCloudInterface.HttpClient);
    StrangeCloudInterface.VoiceClient = (IVoiceClient) new StrangeCloud.Service.Client.VoiceClient(strangeCloudUrl, StrangeCloudInterface.HttpClient);
  }

  public static void Logout()
  {
    StrangeCloudInterface.StrangeUser = (StrangeUser) null;
    StrangeCloudInterface.AuthToken = string.Empty;
    StrangeCloudInterface.HttpClient.DefaultRequestHeaders.Authorization = (AuthenticationHeaderValue) null;
    StrangeCloudInterface.Authenticated = false;
  }

  /// <summary>Update the calling user and return it.</summary>
  public static async Task<StrangeUser> UpdateUser()
  {
    StrangeCloudInterface.StrangeUser = await StrangeCloudInterface.UserAccountClient.GetAccountAsync("1");
    Action strangeUserUpdated = StrangeCloudInterface.StrangeUserUpdated;
    if (strangeUserUpdated != null)
      strangeUserUpdated();
    return StrangeCloudInterface.StrangeUser;
  }

  public static void SetDummyUser(StrangeUser user) => StrangeCloudInterface.StrangeUser = user;

  /// <summary>Authenticate with a username and password and store the bearer token and user data</summary>
  public static async Task Authenticate(string username, string password)
  {
    AuthenticationResult authenticationResult = await StrangeCloudInterface.AuthenticationClient.AuthenticateSLGUserAsync(new AuthenticateSlgUser()
    {
      Username = username,
      Password = password
    }, "1");
    StrangeCloudInterface.SetAuthenticated(authenticationResult.StrangeUser, authenticationResult.Token);
  }

  /// <summary>Authenticate with steam and store the bearer token and user data.</summary>
  /// <returns>Error on failure and empty string on success.</returns>
  public static async Task AuthenticateSteam(string steamTicket)
  {
    AuthenticationResult authenticationResult = await StrangeCloudInterface.AuthenticationClient.AuthenticateSteamUserAsync(steamTicket, "1");
    StrangeCloudInterface.SetAuthenticated(authenticationResult.StrangeUser, authenticationResult.Token);
  }

  /// <summary>Try to authenticate using a user login token.</summary>
  /// <returns>False if token is not valid.</returns>
  public static async Task<bool> TryAuthenticateWithToken(string userLoginToken)
  {
    StrangeCloudInterface.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userLoginToken);
    StrangeUser accountAsync = await StrangeCloudInterface.UserAccountClient.GetAccountAsync("1");
    if (accountAsync != null)
      StrangeCloudInterface.SetAuthenticated(accountAsync, userLoginToken);
    return accountAsync != null;
  }

  private static void SetAuthenticated(StrangeUser user, string authToken)
  {
    StrangeCloudInterface.AuthToken = authToken;
    StrangeCloudInterface.StrangeUser = user;
    StrangeCloudInterface.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
    StrangeCloudInterface.Authenticated = true;
    Action authenticatedEvent = StrangeCloudInterface.AuthenticatedEvent;
    if (authenticatedEvent == null)
      return;
    authenticatedEvent();
  }
}
