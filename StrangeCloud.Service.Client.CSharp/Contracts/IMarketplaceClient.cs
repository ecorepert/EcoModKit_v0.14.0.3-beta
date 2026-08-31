// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.IMarketplaceClient
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
public interface IMarketplaceClient
{
  /// <summary>Returns all marketplace items in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<MarketplaceItem>> GetMarketplaceItemsAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Returns all marketplace items in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<Collection<MarketplaceItem>> GetMarketplaceItemsAsync(
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>Returns the global data stored in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeCloudGlobalData> GetGlobalDataAsync(string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Returns the global data stored in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<StrangeCloudGlobalData> GetGlobalDataAsync(
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Assign the store data from a csv copy-pasted in, sent as text/plain content type. Must include first row of header names.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task PutStoreItemsAdminAsync(string storecsv, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Assign the store data from a csv copy-pasted in, sent as text/plain content type. Must include first row of header names.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task PutStoreItemsAdminAsync(
    string storecsv,
    string api_version,
    CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task BuyAsAdminAsync(string marketplaceItemName, int? quantityMultiplier, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task BuyAsAdminAsync(
    string marketplaceItemName,
    int? quantityMultiplier,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Perform a direct transfer between parties, splitting X% along standard division pattern.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<MarketplaceTransaction> TransferCreditsAsync(
    Guid? userTargetId,
    float? amount,
    string memo,
    string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Perform a direct transfer between parties, splitting X% along standard division pattern.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<MarketplaceTransaction> TransferCreditsAsync(
    Guid? userTargetId,
    float? amount,
    string memo,
    string api_version,
    CancellationToken cancellationToken);

  /// <summary>
  /// Purchases the given marketplace item, with a multiplier if they want to by multiple of that pack (since marketplaceitem contains a quantity).
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<MarketplaceTransaction> StartStorePurchaseAsync(
    string marketplaceItemName,
    int? quantityMultiplier,
    string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Purchases the given marketplace item, with a multiplier if they want to by multiple of that pack (since marketplaceitem contains a quantity).
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<MarketplaceTransaction> StartStorePurchaseAsync(
    string marketplaceItemName,
    int? quantityMultiplier,
    string api_version,
    CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<bool> CompleteStorePurchaseAsync(string transactionId, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<bool> CompleteStorePurchaseAsync(
    string transactionId,
    string api_version,
    CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<bool> RegisterItemsAsync(IEnumerable<MarketplaceItemRegistration> items, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<bool> RegisterItemsAsync(
    IEnumerable<MarketplaceItemRegistration> items,
    string api_version,
    CancellationToken cancellationToken);

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> BuyThirdPartyHostingAsync(int? amount, string api_version);

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  Task<FileResponse> BuyThirdPartyHostingAsync(
    int? amount,
    string api_version,
    CancellationToken cancellationToken);
}
