// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.InvitesClient
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
public class InvitesClient : IInvitesClient
{
  private string _baseUrl;
  private HttpClient _httpClient;
  private static Lazy<JsonSerializerSettings> _settings = new Lazy<JsonSerializerSettings>(new Func<JsonSerializerSettings>(InvitesClient.CreateSerializerSettings), true);

  public InvitesClient(string baseUrl, HttpClient httpClient)
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

  protected JsonSerializerSettings JsonSerializerSettings => InvitesClient._settings.Value;

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task GrantInvitesAsync(Guid? userid, int? count, string api_version)
  {
    return this.GrantInvitesAsync(userid, count, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task GrantInvitesAsync(
    Guid? userid,
    int? count,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Invites/GrantInvites");
        stringBuilder.Append('?');
        if (userid.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (userid))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) userid, CultureInfo.InvariantCulture))).Append('&');
        if (count.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (count))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) count, CultureInfo.InvariantCulture))).Append('&');
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
              InvitesClient.ObjectResponseResult<Response17> objectResponseResult = await this.ReadObjectResponseAsync<Response17>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response17>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
  public virtual Task<Collection<string>> GetInvitesAsync(string api_version)
  {
    return this.GetInvitesAsync(api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<Collection<string>> GetInvitesAsync(
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    Collection<string> invitesAsync;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Invites/GetInvites");
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
              InvitesClient.ObjectResponseResult<Collection<string>> objectResponseResult1 = await this.ReadObjectResponseAsync<Collection<string>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              invitesAsync = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 500:
              InvitesClient.ObjectResponseResult<Response18> objectResponseResult2 = await this.ReadObjectResponseAsync<Response18>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response18>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
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
    return invitesAsync;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task RedeemInviteAsync(Guid? inviteGuid, string api_version)
  {
    return this.RedeemInviteAsync(inviteGuid, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task RedeemInviteAsync(
    Guid? inviteGuid,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Invites/RedeemInvite");
        stringBuilder.Append('?');
        if (inviteGuid.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (inviteGuid))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) inviteGuid, CultureInfo.InvariantCulture))).Append('&');
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
              InvitesClient.ObjectResponseResult<Response19> objectResponseResult = await this.ReadObjectResponseAsync<Response19>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response19>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
  public virtual Task RemoveInviteAsync(Guid? inviteGuid, string api_version)
  {
    return this.RemoveInviteAsync(inviteGuid, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task RemoveInviteAsync(
    Guid? inviteGuid,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Invites/RemoveInvite");
        stringBuilder.Append('?');
        if (inviteGuid.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (inviteGuid))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) inviteGuid, CultureInfo.InvariantCulture))).Append('&');
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
              InvitesClient.ObjectResponseResult<Response20> objectResponseResult = await this.ReadObjectResponseAsync<Response20>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response20>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
  public virtual Task RemoveInvitesByCountAsync(Guid? userid, int? count, string api_version)
  {
    return this.RemoveInvitesByCountAsync(userid, count, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task RemoveInvitesByCountAsync(
    Guid? userid,
    int? count,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Invites/RemoveInvitesByCount");
        stringBuilder.Append('?');
        if (userid.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (userid))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) userid, CultureInfo.InvariantCulture))).Append('&');
        if (count.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (count))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) count, CultureInfo.InvariantCulture))).Append('&');
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
              InvitesClient.ObjectResponseResult<Response21> objectResponseResult = await this.ReadObjectResponseAsync<Response21>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response21>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
  public virtual Task BuyInvitesWithCreditsAsync(int? count, string api_version)
  {
    return this.BuyInvitesWithCreditsAsync(count, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task BuyInvitesWithCreditsAsync(
    int? count,
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Invites/BuyInvitesWithCredits");
        stringBuilder.Append('?');
        if (count.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (count))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) count, CultureInfo.InvariantCulture))).Append('&');
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
              InvitesClient.ObjectResponseResult<Response22> objectResponseResult = await this.ReadObjectResponseAsync<Response22>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response22>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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

  public bool ReadResponseAsString { get; set; }

  protected virtual async Task<InvitesClient.ObjectResponseResult<T>> ReadObjectResponseAsync<T>(
    HttpResponseMessage response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    CancellationToken cancellationToken)
  {
    if (response == null || response.Content == null)
      return new InvitesClient.ObjectResponseResult<T>(default (T), string.Empty);
    if (this.ReadResponseAsString)
    {
      string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
      try
      {
        return new InvitesClient.ObjectResponseResult<T>(JsonConvert.DeserializeObject<T>(str, this.JsonSerializerSettings), str);
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
              return new InvitesClient.ObjectResponseResult<T>(JsonSerializer.Create(this.JsonSerializerSettings).Deserialize<T>((JsonReader) jsonTextReader), string.Empty);
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
