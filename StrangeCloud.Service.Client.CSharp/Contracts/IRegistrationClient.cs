// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.IRegistrationClient
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NSwag", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IRegistrationClient
{
  /// <summary>
  /// Can be called by users who have only logged in via steam
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task SetUsernameAndPasswordAsync(UsernameOrEmailAndPassword request, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Can be called by users who have only logged in via steam
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task SetUsernameAndPasswordAsync(
    UsernameOrEmailAndPassword request,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>Register a new user and authenticates them.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> RegisterUserAsync(
    UsernameOrEmailAndPassword request,
    string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Register a new user and authenticates them.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<AuthenticationResult> RegisterUserAsync(
    UsernameOrEmailAndPassword request,
    string api_version,
    CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task RequestVerifyEmailAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task RequestVerifyEmailAsync(string api_version, CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> VerifyEmailAsync(string verifyToken, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> VerifyEmailAsync(
    string verifyToken,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>Authorize a user with Steam OpenID.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> RegisterWithSteamAsync(string token, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Authorize a user with Steam OpenID.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> RegisterWithSteamAsync(
    string token,
    string api_version,
    CancellationToken cancellationToken);
}
