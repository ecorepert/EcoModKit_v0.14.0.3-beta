// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.FileResponse
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NSwag", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class FileResponse : IDisposable
{
  private IDisposable _client;
  private IDisposable _response;

  public int StatusCode { get; private set; }

  public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

  public Stream Stream { get; private set; }

  public bool IsPartial => this.StatusCode == 206;

  public FileResponse(
    int statusCode,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    Stream stream,
    IDisposable client,
    IDisposable response)
  {
    this.StatusCode = statusCode;
    this.Headers = headers;
    this.Stream = stream;
    this._client = client;
    this._response = response;
  }

  public void Dispose()
  {
    this.Stream.Dispose();
    if (this._response != null)
      this._response.Dispose();
    if (this._client == null)
      return;
    this._client.Dispose();
  }
}
