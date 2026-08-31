// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.IUserAccountClient
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NSwag", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IUserAccountClient
{
  /// <summary>Set an existing or new user as the passed value.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task SetAccountAsync(StrangeUser user, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Set an existing or new user as the passed value.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task SetAccountAsync(StrangeUser user, string api_version, CancellationToken cancellationToken);

  /// <summary>
  /// Returns the user account of the given user, stripping sensitive data.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeUser> GetAccountAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Returns the user account of the given user, stripping sensitive data.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeUser> GetAccountAsync(string api_version, CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task SetAvatarDataAsync(string avatarDna, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task SetAvatarDataAsync(
    string avatarDna,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Returns the current authed user's status in steam (trusted, locked or normal). Value can be any in SteamUserStatus enum.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> GetUserSteamStatusAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Returns the current authed user's status in steam (trusted, locked or normal). Value can be any in SteamUserStatus enum.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> GetUserSteamStatusAsync(string api_version, CancellationToken cancellationToken);

  /// <summary>Clear the user notifications.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task ClearNotificationsAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Clear the user notifications.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task ClearNotificationsAsync(string api_version, CancellationToken cancellationToken);

  /// <summary>DEPRECATED. Returns transaction summarys.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<DailySummary>> GetTransactionSummariesAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>DEPRECATED. Returns transaction summarys.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<DailySummary>> GetTransactionSummariesAsync(
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// DEPRECATED. Admin-only endpoint for querying a sum of all transactions for a given date range.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<DailySummary>> GetAllTransactionSummariesAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// DEPRECATED. Admin-only endpoint for querying a sum of all transactions for a given date range.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<DailySummary>> GetAllTransactionSummariesAsync(
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>Grant a list of achievements to a given user.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task GrantAchievementsAsync(
    Guid? userId,
    IEnumerable<StrangeAchievement> achievements,
    string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Grant a list of achievements to a given user.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task GrantAchievementsAsync(
    Guid? userId,
    IEnumerable<StrangeAchievement> achievements,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Grants an achievement to the user with the given name and description.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task GrantAchievementAsync(Guid? userId, StrangeAchievement achievement, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Grants an achievement to the user with the given name and description.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task GrantAchievementAsync(
    Guid? userId,
    StrangeAchievement achievement,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Twitch callback endpoint to handle fetching twitch information.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task TwitchCallbackAsync(string code, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Twitch callback endpoint to handle fetching twitch information.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task TwitchCallbackAsync(string code, string api_version, CancellationToken cancellationToken);

  /// <summary>
  /// Called during gameplay to say they are online at the given server, every 10 minutes.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<HearbeatResult> HeartbeatAsync(Guid? worldId, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Called during gameplay to say they are online at the given server, every 10 minutes.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<HearbeatResult> HeartbeatAsync(
    Guid? worldId,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Adds a steam account to the user. If the user owns Eco, it will attempt to grant them a key on steam.
  /// </summary>
  /// <param name="token">The Access token provided by steam after redirect to be used to redeem a key and check steam information</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> AddSteamToSlgUserAsync(string token, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Adds a steam account to the user. If the user owns Eco, it will attempt to grant them a key on steam.
  /// </summary>
  /// <param name="token">The Access token provided by steam after redirect to be used to redeem a key and check steam information</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> AddSteamToSlgUserAsync(
    string token,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Set the users icon. While checking that they are allowed to have it
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> SelectIconAsync(IconRequest request, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Set the users icon. While checking that they are allowed to have it
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> SelectIconAsync(
    IconRequest request,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Allows the user to change their email address. Requires current email, new email, and password.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> ChangeEmailAsync(ChangeEmailRequest request, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Allows the user to change their email address. Requires current email, new email, and password.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> ChangeEmailAsync(
    ChangeEmailRequest request,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Accept the developer tier terms and set the user's GitHub username.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> AcceptDevTermsAsync(AcceptDevTermsRequest request, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Accept the developer tier terms and set the user's GitHub username.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> AcceptDevTermsAsync(
    AcceptDevTermsRequest request,
    string api_version,
    CancellationToken cancellationToken);
}
