// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.IAuthenticationClient
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using System;
using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NSwag", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IAuthenticationClient
{
  /// <summary>
  /// Authenticates a strange user using their username and password. Username case insensitive, password case sensitive.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> AuthenticateUserFromAdminAsync(
    AuthenticateSlgUser request,
    Guid? userToAuthenticate,
    string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Authenticates a strange user using their username and password. Username case insensitive, password case sensitive.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> AuthenticateUserFromAdminAsync(
    AuthenticateSlgUser request,
    Guid? userToAuthenticate,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Authenticates a strange user using their username and password. Username case insensitive, password case sensitive.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> AuthenticateSLGUserAsync(
    AuthenticateSlgUser request,
    string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Authenticates a strange user using their username and password. Username case insensitive, password case sensitive.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> AuthenticateSLGUserAsync(
    AuthenticateSlgUser request,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Authenticates a Steam user using their steam ticket and returning the linked user, creating a new user if required.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> AuthenticateSteamUserAsync(string steamTicket, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Authenticates a Steam user using their steam ticket and returning the linked user, creating a new user if required.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> AuthenticateSteamUserAsync(
    string steamTicket,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Deprecated. Used for backward compatibility.
  /// <br />Try to re-authenticate a user using their refresh token. Returns 403 if invalid.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> RefreshTokenAsync(string refreshToken, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Deprecated. Used for backward compatibility.
  /// <br />Try to re-authenticate a user using their refresh token. Returns 403 if invalid.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> RefreshTokenAsync(
    string refreshToken,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Get user login token which can be used to login as that user.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> GenerateAuthTokenAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Get user login token which can be used to login as that user.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> GenerateAuthTokenAsync(string api_version, CancellationToken cancellationToken);

  /// <summary>Invalidate all given auth tokens.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> RevokeAllTokensAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Invalidate all given auth tokens.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> RevokeAllTokensAsync(string api_version, CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> GetWorldTicketAsync(Guid? serverId, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<string> GetWorldTicketAsync(
    Guid? serverId,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>Verifies a privately signed JWT token instance.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeUser> VerifyWorldTicketAsync(
    string worldTicket,
    Guid? expectedWorldId,
    string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Verifies a privately signed JWT token instance.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeUser> VerifyWorldTicketAsync(
    string worldTicket,
    Guid? expectedWorldId,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Allows an admin to retrieve a login token for a given user for testing purposes..
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> GetUserAuthTokenAsync(Guid? userId, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Allows an admin to retrieve a login token for a given user for testing purposes..
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> GetUserAuthTokenAsync(
    Guid? userId,
    string api_version,
    CancellationToken cancellationToken);
}
