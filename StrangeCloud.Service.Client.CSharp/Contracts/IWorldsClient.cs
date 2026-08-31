// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.IWorldsClient
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
public interface IWorldsClient
{
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeWorldCloudData> GetWorldAsync(Guid? id, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeWorldCloudData> GetWorldAsync(
    Guid? id,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Returns the user account of the given user, stripping sensitive data.  Caches every 60 seconds, and returns a compressed list of StrangeCloudWorldData.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> GetActiveWorldsAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Returns the user account of the given user, stripping sensitive data.  Caches every 60 seconds, and returns a compressed list of StrangeCloudWorldData.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> GetActiveWorldsAsync(string api_version, CancellationToken cancellationToken);

  /// <summary>Register or update a server.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<ServerHeartbeatResult> ServerHeartbeatAsync(ServerHeartbeatData data, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Register or update a server.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<ServerHeartbeatResult> ServerHeartbeatAsync(
    ServerHeartbeatData data,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>Returns any mods in the db matching the given names.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<StrangeMod>> GetModsAsync(IEnumerable<string> modNames, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Returns any mods in the db matching the given names.</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<StrangeMod>> GetModsAsync(
    IEnumerable<string> modNames,
    string api_version,
    CancellationToken cancellationToken);
}
