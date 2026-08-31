// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.AwsS3Client
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
public class AwsS3Client : IAwsS3Client
{
  private string _baseUrl;
  private HttpClient _httpClient;
  private static Lazy<JsonSerializerSettings> _settings = new Lazy<JsonSerializerSettings>(new Func<JsonSerializerSettings>(AwsS3Client.CreateSerializerSettings), true);

  public AwsS3Client(string baseUrl, HttpClient httpClient)
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

  protected JsonSerializerSettings JsonSerializerSettings => AwsS3Client._settings.Value;

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<FileResponse> GetReleaseFileFromS3Async(string documentName)
  {
    return this.GetReleaseFileFromS3Async(documentName, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<FileResponse> GetReleaseFileFromS3Async(
    string documentName,
    CancellationToken cancellationToken)
  {
    if (documentName == null)
      throw new ArgumentNullException(nameof (documentName));
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    FileResponse releaseFileFromS3Async;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("s3/release/");
        stringBuilder.Append(Uri.EscapeDataString(this.ConvertToString((object) documentName, CultureInfo.InvariantCulture)));
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
            FileResponse fileResponse = new FileResponse(status_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, stream, (IDisposable) null, (IDisposable) response_);
            disposeClient_ = false;
            disposeResponse_ = false;
            releaseFileFromS3Async = fileResponse;
          }
          else
          {
            if (status_ == 500)
            {
              AwsS3Client.ObjectResponseResult<Response83> objectResponseResult = await this.ReadObjectResponseAsync<Response83>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response83>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
    return releaseFileFromS3Async;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<FileResponse> GetStagingReleaseFileFromS3Async(string documentName)
  {
    return this.GetStagingReleaseFileFromS3Async(documentName, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<FileResponse> GetStagingReleaseFileFromS3Async(
    string documentName,
    CancellationToken cancellationToken)
  {
    if (documentName == null)
      throw new ArgumentNullException(nameof (documentName));
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    FileResponse releaseFileFromS3Async;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("s3/staging/");
        stringBuilder.Append(Uri.EscapeDataString(this.ConvertToString((object) documentName, CultureInfo.InvariantCulture)));
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
            FileResponse fileResponse = new FileResponse(status_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, stream, (IDisposable) null, (IDisposable) response_);
            disposeClient_ = false;
            disposeResponse_ = false;
            releaseFileFromS3Async = fileResponse;
          }
          else
          {
            if (status_ == 500)
            {
              AwsS3Client.ObjectResponseResult<Response84> objectResponseResult = await this.ReadObjectResponseAsync<Response84>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response84>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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
    return releaseFileFromS3Async;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<Collection<GameVersion>> GetVersionsFromDbAsync()
  {
    return this.GetVersionsFromDbAsync(CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<Collection<GameVersion>> GetVersionsFromDbAsync(
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    Collection<GameVersion> versionsFromDbAsync;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        request_.Method = new HttpMethod("GET");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("s3/GameVersions");
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
              AwsS3Client.ObjectResponseResult<Collection<GameVersion>> objectResponseResult1 = await this.ReadObjectResponseAsync<Collection<GameVersion>>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              versionsFromDbAsync = objectResponseResult1.Object != null ? objectResponseResult1.Object : throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult1.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              break;
            case 500:
              AwsS3Client.ObjectResponseResult<Response85> objectResponseResult2 = await this.ReadObjectResponseAsync<Response85>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult2.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response85>("Internal Server Error", status_, objectResponseResult2.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult2.Object, (Exception) null);
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
    return versionsFromDbAsync;
  }

  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual Task<FileResponse> AddBuildAsync(GameVersion version)
  {
    return this.AddBuildAsync(version, CancellationToken.None);
  }

  /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
  /// <exception cref="T:StrangeCloud.Service.Client.Contracts.StrangeApiException">A server side error occurred.</exception>
  public virtual async Task<FileResponse> AddBuildAsync(
    GameVersion version,
    CancellationToken cancellationToken)
  {
    HttpClient client_ = this._httpClient;
    bool disposeClient_ = false;
    FileResponse fileResponse1;
    try
    {
      using (HttpRequestMessage request_ = new HttpRequestMessage())
      {
        StringContent stringContent = new StringContent(JsonConvert.SerializeObject((object) version, AwsS3Client._settings.Value));
        stringContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        request_.Content = (HttpContent) stringContent;
        request_.Method = new HttpMethod("POST");
        request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(this._baseUrl))
          stringBuilder.Append(this._baseUrl);
        stringBuilder.Append("s3/build");
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
              AwsS3Client.ObjectResponseResult<Response86> objectResponseResult = await this.ReadObjectResponseAsync<Response86>(response_, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, cancellationToken).ConfigureAwait(false);
              if (objectResponseResult.Object == null)
                throw new StrangeApiException("Response was null which was not expected.", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, (Exception) null);
              throw new StrangeApiException<Response86>("Internal Server Error", status_, objectResponseResult.Text, (IReadOnlyDictionary<string, IEnumerable<string>>) headers_, objectResponseResult.Object, (Exception) null);
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

  protected virtual async Task<AwsS3Client.ObjectResponseResult<T>> ReadObjectResponseAsync<T>(
    HttpResponseMessage response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    CancellationToken cancellationToken)
  {
    if (response == null || response.Content == null)
      return new AwsS3Client.ObjectResponseResult<T>(default (T), string.Empty);
    if (this.ReadResponseAsString)
    {
      string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
      try
      {
        return new AwsS3Client.ObjectResponseResult<T>(JsonConvert.DeserializeObject<T>(str, this.JsonSerializerSettings), str);
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
              return new AwsS3Client.ObjectResponseResult<T>(JsonSerializer.Create(this.JsonSerializerSettings).Deserialize<T>((JsonReader) jsonTextReader), string.Empty);
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
