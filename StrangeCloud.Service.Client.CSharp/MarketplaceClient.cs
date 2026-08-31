// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.MarketplaceClient
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using Newtonsoft.Json;
using StrangeCloud.Service.Client.Contracts;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace StrangeCloud.Service.Client;

[GeneratedCode("NSwag", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class MarketplaceClient : IMarketplaceClient
{
  private string _baseUrl;
  private HttpClient _httpClient;
  private static Lazy<JsonSerializerSettings> _settings = new Lazy<JsonSerializerSettings>(new Func<JsonSerializerSettings>(MarketplaceClient.CreateSerializerSettings), true);

  public MarketplaceClient(string baseUrl, HttpClient httpClient)
  {
    this.BaseUrl = baseUrl;
    this._httpClient = httpClient;
  }

  private static JsonSerializerSettings CreateSerializerSettings()
  {
    return NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings());
  }

  public string BaseUrl
  {
    get => this._baseUrl;
    set
    {
      this._baseUrl = value;
      if (string.IsNullOrEmpty(this._baseUrl) || this._baseUrl.EndsWith("/"))
        return;
      this._baseUrl += "/";
    }
  }

  protected JsonSerializerSettings JsonSerializerSettings => MarketplaceClient._settings.Value;

  /// <summary>Returns all marketplace items in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<Collection<MarketplaceItem>> GetMarketplaceItemsAsync(string api_version)
  {
    return this.GetMarketplaceItemsAsync(api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Returns all marketplace items in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<Collection<MarketplaceItem>> GetMarketplaceItemsAsync(
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    Collection<MarketplaceItem> marketplaceItemsAsync;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/GetMarketplaceItems");
        stringBuilder.Append('?');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              MarketplaceClient.ObjectResponseResult<Collection<MarketplaceItem>> objectResponseResult1 = await this.ReadObjectResponseAsync<Collection<MarketplaceItem>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              marketplaceItemsAsync = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response23> objectResponseResult2 = await this.ReadObjectResponseAsync<Response23>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response23>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return marketplaceItemsAsync;
  }

  /// <summary>Returns the global data stored in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<StrangeCloudGlobalData> GetGlobalDataAsync(string api_version)
  {
    return this.GetGlobalDataAsync(api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>Returns the global data stored in the database</summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<StrangeCloudGlobalData> GetGlobalDataAsync(
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    StrangeCloudGlobalData globalDataAsync;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/GetGlobalData");
        stringBuilder.Append('?');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              MarketplaceClient.ObjectResponseResult<StrangeCloudGlobalData> objectResponseResult1 = await this.ReadObjectResponseAsync<StrangeCloudGlobalData>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              globalDataAsync = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response24> objectResponseResult2 = await this.ReadObjectResponseAsync<Response24>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response24>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return globalDataAsync;
  }

  /// <summary>
  /// Assign the store data from a csv copy-pasted in, sent as text/plain content type. Must include first row of header names.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task PutStoreItemsAdminAsync(string storecsv, string api_version)
  {
    return this.PutStoreItemsAdminAsync(storecsv, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Assign the store data from a csv copy-pasted in, sent as text/plain content type. Must include first row of header names.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task PutStoreItemsAdminAsync(
    string storecsv,
    string api_version,
    CancellationToken cancellationToken)
  {
    if (storecsv == null)
      throw new ArgumentNullException(nameof (storecsv));
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(storecsv);
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("text/plain");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/PutStoreItemsAdmin");
        stringBuilder.Append('?');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response25> objectResponseResult = await this.ReadObjectResponseAsync<Response25>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response25>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task BuyAsAdminAsync(
    string marketplaceItemName,
    int? quantityMultiplier,
    string api_version)
  {
    return this.BuyAsAdminAsync(marketplaceItemName, quantityMultiplier, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task BuyAsAdminAsync(
    string marketplaceItemName,
    int? quantityMultiplier,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Content = (HttpContent) new StringContent(string.Empty, Encoding.UTF8, "application/json");
        request_.Method = new HttpMethod("POST");
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/BuyAsAdmin");
        stringBuilder.Append('?');
        if (marketplaceItemName != null)
          stringBuilder.Append(Uri.EscapeDataString(nameof (marketplaceItemName))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) marketplaceItemName, CultureInfo.InvariantCulture))).Append('&');
        if (quantityMultiplier.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (quantityMultiplier))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) quantityMultiplier, CultureInfo.InvariantCulture))).Append('&');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response26> objectResponseResult = await this.ReadObjectResponseAsync<Response26>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response26>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
  }

  /// <summary>
  /// Perform a direct transfer between parties, splitting X% along standard division pattern.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<MarketplaceTransaction> TransferCreditsAsync(
    Guid? userTargetId,
    float? amount,
    string memo,
    string api_version)
  {
    return this.TransferCreditsAsync(userTargetId, amount, memo, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Perform a direct transfer between parties, splitting X% along standard division pattern.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<MarketplaceTransaction> TransferCreditsAsync(
    Guid? userTargetId,
    float? amount,
    string memo,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    MarketplaceTransaction marketplaceTransaction;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Content = (HttpContent) new StringContent(string.Empty, Encoding.UTF8, "application/json");
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/TransferCredits");
        stringBuilder.Append('?');
        if (userTargetId.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (userTargetId))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) userTargetId, CultureInfo.InvariantCulture))).Append('&');
        if (amount.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (amount))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) amount, CultureInfo.InvariantCulture))).Append('&');
        if (memo != null)
          stringBuilder.Append(Uri.EscapeDataString(nameof (memo))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) memo, CultureInfo.InvariantCulture))).Append('&');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              MarketplaceClient.ObjectResponseResult<MarketplaceTransaction> objectResponseResult1 = await this.ReadObjectResponseAsync<MarketplaceTransaction>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              marketplaceTransaction = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response27> objectResponseResult2 = await this.ReadObjectResponseAsync<Response27>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response27>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return marketplaceTransaction;
  }

  /// <summary>
  /// Purchases the given marketplace item, with a multiplier if they want to by multiple of that pack (since marketplaceitem contains a quantity).
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<MarketplaceTransaction> StartStorePurchaseAsync(
    string marketplaceItemName,
    int? quantityMultiplier,
    string api_version)
  {
    return this.StartStorePurchaseAsync(marketplaceItemName, quantityMultiplier, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Purchases the given marketplace item, with a multiplier if they want to by multiple of that pack (since marketplaceitem contains a quantity).
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<MarketplaceTransaction> StartStorePurchaseAsync(
    string marketplaceItemName,
    int? quantityMultiplier,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    MarketplaceTransaction marketplaceTransaction;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Content = (HttpContent) new StringContent(string.Empty, Encoding.UTF8, "application/json");
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/StartStorePurchase");
        stringBuilder.Append('?');
        if (marketplaceItemName != null)
          stringBuilder.Append(Uri.EscapeDataString(nameof (marketplaceItemName))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) marketplaceItemName, CultureInfo.InvariantCulture))).Append('&');
        if (quantityMultiplier.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (quantityMultiplier))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) quantityMultiplier, CultureInfo.InvariantCulture))).Append('&');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              MarketplaceClient.ObjectResponseResult<MarketplaceTransaction> objectResponseResult1 = await this.ReadObjectResponseAsync<MarketplaceTransaction>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              marketplaceTransaction = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response28> objectResponseResult2 = await this.ReadObjectResponseAsync<Response28>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response28>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return marketplaceTransaction;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<bool> CompleteStorePurchaseAsync(string transactionId, string api_version)
  {
    return this.CompleteStorePurchaseAsync(transactionId, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<bool> CompleteStorePurchaseAsync(
    string transactionId,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    bool flag;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Content = (HttpContent) new StringContent(string.Empty, Encoding.UTF8, "application/json");
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/CompleteStorePurchase");
        stringBuilder.Append('?');
        if (transactionId != null)
          stringBuilder.Append(Uri.EscapeDataString(nameof (transactionId))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) transactionId, CultureInfo.InvariantCulture))).Append('&');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              MarketplaceClient.ObjectResponseResult<bool> objectResponseResult1 = await this.ReadObjectResponseAsync<bool>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              int num = objectResponseResult1.Object ? 1 : 0;
              flag = objectResponseResult1.Object;
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response29> objectResponseResult2 = await this.ReadObjectResponseAsync<Response29>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response29>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return flag;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<bool> RegisterItemsAsync(
    IEnumerable<MarketplaceItemRegistration> items,
    string api_version)
  {
    return this.RegisterItemsAsync(items, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<bool> RegisterItemsAsync(
    IEnumerable<MarketplaceItemRegistration> items,
    string api_version,
    CancellationToken cancellationToken)
  {
    if (items == null)
      throw new ArgumentNullException(nameof (items));
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    bool flag;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(JsonConvert.SerializeObject((object) items, MarketplaceClient._settings.Value));
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/RegisterItems");
        stringBuilder.Append('?');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          switch (status_)
          {
            case 200:
              MarketplaceClient.ObjectResponseResult<bool> objectResponseResult1 = await this.ReadObjectResponseAsync<bool>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              int num = objectResponseResult1.Object ? 1 : 0;
              flag = objectResponseResult1.Object;
              break;
            case 500:
              MarketplaceClient.ObjectResponseResult<Response30> objectResponseResult2 = await this.ReadObjectResponseAsync<Response30>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response30>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
            default:
              string str;
              if (response_.Content == null)
                str = (string) null;
              else
                str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
              string response = str;
              throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return flag;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<FileResponse> BuyThirdPartyHostingAsync(int? amount, string api_version)
  {
    return this.BuyThirdPartyHostingAsync(amount, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<FileResponse> BuyThirdPartyHostingAsync(
    int? amount,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    FileResponse fileResponse1;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Marketplace/BuyThirdPartyHosting");
        stringBuilder.Append('?');
        if (amount.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (amount))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) amount, CultureInfo.InvariantCulture))).Append('&');
        if (api_version != null)
          stringBuilder.Append(Uri.EscapeDataString("api-version")).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) api_version, CultureInfo.InvariantCulture))).Append('&');
        --stringBuilder.Length;
        request_.RequestUri = new Uri(stringBuilder.ToString(), UriKind.RelativeOrAbsolute);
        HttpResponseMessage response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        bool disposeResponse_ = true;
        try
        {
          Dictionary<string, IEnumerable<string>> headers_ = new Dictionary<string, IEnumerable<string>>();
          foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Headers)
            headers_[header.Key] = header.Value;
          if (response_.Content != null && response_.Content.Headers != null)
          {
            foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders) response_.Content.Headers)
              headers_[header.Key] = header.Value;
          }
          int status_ = (int) response_.StatusCode;
          if (status_ == 200 || status_ == 206)
          {
            Stream stream;
            if (response_.Content == null)
              stream = Stream.Null;
            else
              stream = await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
            FileResponse fileResponse2 = new FileResponse(status_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, stream, (IDisposable) null, (IDisposable) response_);
            disposeClient_ = false;
            disposeResponse_ = false;
            fileResponse1 = fileResponse2;
          }
          else
          {
            if (status_ == 500)
            {
              MarketplaceClient.ObjectResponseResult<Response31> objectResponseResult = await this.ReadObjectResponseAsync<Response31>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response31>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
            }
            string str;
            if (response_.Content == null)
              str = (string) null;
            else
              str = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
            string response = str;
            throw new StrangeApiException($"The HTTP status code of the response was not expected ({status_.ToString()}).", status_, response, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
          }
        }
        finally
        {
          if (disposeResponse_)
            response_.Dispose();
        }
      }
    }
    finally
    {
      if (disposeClient_)
        client_.Dispose();
    }
    client_ = (HttpClient) null;
    return fileResponse1;
  }

  public bool ReadResponseAsString { get; set; }

  protected virtual async Task<MarketplaceClient.ObjectResponseResult<T>> ReadObjectResponseAsync<T>(
    HttpResponseMessage response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    CancellationToken cancellationToken)
  {
    if (response == null || response.Content == null)
      return new MarketplaceClient.ObjectResponseResult<T>(default (T), string.Empty);
    if (this.ReadResponseAsString)
    {
      string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
      try
      {
        return new MarketplaceClient.ObjectResponseResult<T>(JsonConvert.DeserializeObject<T>(str, this.JsonSerializerSettings), str);
      }
      catch (JsonException ex)
      {
        throw new StrangeApiException($"Could not deserialize the response body string as {typeof (T).FullName}.", (int) response.StatusCode, str, headers, (Exception) ex);
      }
    }
    else
    {
      try
      {
        using (Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
        {
          using (StreamReader streamReader = new StreamReader(stream))
          {
            using (JsonTextReader jsonTextReader = new JsonTextReader((TextReader) streamReader))
              return new MarketplaceClient.ObjectResponseResult<T>(JsonSerializer.Create(this.JsonSerializerSettings).Deserialize<T>((JsonReader) jsonTextReader), string.Empty);
          }
        }
      }
      catch (JsonException ex)
      {
        throw new StrangeApiException($"Could not deserialize the response body stream as {typeof (T).FullName}.", (int) response.StatusCode, string.Empty, headers, (Exception) ex);
      }
    }
  }

  private string ConvertToString(object value, CultureInfo cultureInfo)
  {
    switch (value)
    {
      case null:
        return "";
      case Enum _:
        string name = Enum.GetName(value.GetType(), value);
        if (name != null)
        {
          FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
          if (!(declaredField != (FieldInfo) null) || !(declaredField.GetCustomAttribute(typeof (EnumMemberAttribute)) is EnumMemberAttribute customAttribute))
            return Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), (IFormatProvider) cultureInfo)) ?? string.Empty;
          return customAttribute.Value == null ? name : customAttribute.Value;
        }
        break;
      case bool flag:
        return Convert.ToString(flag, (IFormatProvider) cultureInfo).ToLowerInvariant();
      case byte[] _:
        return Convert.ToBase64String((byte[]) value);
      case string[] _:
        return string.Join(",", (string[]) value);
      default:
        if (value.GetType().IsArray)
        {
          Array array = (Array) value;
          string[] strArray = new string[array.Length];
          for (int index = 0; index < array.Length; ++index)
            strArray[index] = this.ConvertToString(array.GetValue(index), cultureInfo);
          return string.Join(",", strArray);
        }
        break;
    }
    return Convert.ToString(value, (IFormatProvider) cultureInfo) ?? "";
  }

  protected struct ObjectResponseResult<T>(T responseObject, string responseText)
  {
    public T Object { get; } = responseObject;

    public string Text { get; } = responseText;
  }
}
