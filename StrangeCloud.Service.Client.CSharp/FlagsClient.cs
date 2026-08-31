// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.FlagsClient
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
public class FlagsClient : IFlagsClient
{
  private string _baseUrl;
  private HttpClient _httpClient;
  private static Lazy<JsonSerializerSettings> _settings = new Lazy<JsonSerializerSettings>(new Func<JsonSerializerSettings>(FlagsClient.CreateSerializerSettings), true);

  public FlagsClient(string baseUrl, HttpClient httpClient)
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

  protected JsonSerializerSettings JsonSerializerSettings => FlagsClient._settings.Value;

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task ClearAllFlagsAsync(string api_version)
  {
    return this.ClearAllFlagsAsync(api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task ClearAllFlagsAsync(
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
        stringBuilder.Append("Flags/ClearAllFlags");
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
              FlagsClient.ObjectResponseResult<Response13> objectResponseResult = await this.ReadObjectResponseAsync<Response13>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response13>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
  public virtual Task<Collection<ServerReportSummary>> FlagReportAsync(string api_version)
  {
    return this.FlagReportAsync(api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<Collection<ServerReportSummary>> FlagReportAsync(
    string api_version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    Collection<ServerReportSummary> collection;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("Flags/FlagReport");
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
              FlagsClient.ObjectResponseResult<Collection<ServerReportSummary>> objectResponseResult1 = await this.ReadObjectResponseAsync<Collection<ServerReportSummary>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              collection = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 500:
              FlagsClient.ObjectResponseResult<Response14> objectResponseResult2 = await this.ReadObjectResponseAsync<Response14>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response14>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
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
    return collection;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task FlagSelfAsync(
    Guid? worldId,
    string problemDescription,
    bool? circumventingPaidItems,
    string api_version)
  {
    return this.FlagSelfAsync(worldId, problemDescription, circumventingPaidItems, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task FlagSelfAsync(
    Guid? worldId,
    string problemDescription,
    bool? circumventingPaidItems,
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
        stringBuilder.Append("Flags/FlagSelf");
        stringBuilder.Append('?');
        if (worldId.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (worldId))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) worldId, CultureInfo.InvariantCulture))).Append('&');
        if (problemDescription != null)
          stringBuilder.Append(Uri.EscapeDataString(nameof (problemDescription))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) problemDescription, CultureInfo.InvariantCulture))).Append('&');
        if (circumventingPaidItems.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (circumventingPaidItems))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) circumventingPaidItems, CultureInfo.InvariantCulture))).Append('&');
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
              FlagsClient.ObjectResponseResult<Response15> objectResponseResult = await this.ReadObjectResponseAsync<Response15>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response15>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
  /// Registers or updates the given world, on the given port.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task FlagServerAsync(
    string worldTicket,
    string problemDescription,
    bool? circumventingPaidItems,
    string api_version)
  {
    return this.FlagServerAsync(worldTicket, problemDescription, circumventingPaidItems, api_version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <summary>
  /// Registers or updates the given world, on the given port.
  /// </summary>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task FlagServerAsync(
    string worldTicket,
    string problemDescription,
    bool? circumventingPaidItems,
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
        stringBuilder.Append("Flags/FlagServer");
        stringBuilder.Append('?');
        if (worldTicket != null)
          stringBuilder.Append(Uri.EscapeDataString(nameof (worldTicket))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) worldTicket, CultureInfo.InvariantCulture))).Append('&');
        if (problemDescription != null)
          stringBuilder.Append(Uri.EscapeDataString(nameof (problemDescription))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) problemDescription, CultureInfo.InvariantCulture))).Append('&');
        if (circumventingPaidItems.HasValue)
          stringBuilder.Append(Uri.EscapeDataString(nameof (circumventingPaidItems))).Append('=').Append(Uri.EscapeDataString(this.ConvertToString((object) circumventingPaidItems, CultureInfo.InvariantCulture))).Append('&');
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
              FlagsClient.ObjectResponseResult<Response16> objectResponseResult = await this.ReadObjectResponseAsync<Response16>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response16>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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

  protected virtual async Task<FlagsClient.ObjectResponseResult<T>> ReadObjectResponseAsync<T>(
    HttpResponseMessage response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    CancellationToken cancellationToken)
  {
    if (response == null || response.Content == null)
      return new FlagsClient.ObjectResponseResult<T>(default (T), string.Empty);
    if (this.ReadResponseAsString)
    {
      string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
      try
      {
        return new FlagsClient.ObjectResponseResult<T>(JsonConvert.DeserializeObject<T>(str, this.JsonSerializerSettings), str);
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
              return new FlagsClient.ObjectResponseResult<T>(JsonSerializer.Create(this.JsonSerializerSettings).Deserialize<T>((JsonReader) jsonTextReader), string.Empty);
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
