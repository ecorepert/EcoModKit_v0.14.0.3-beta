// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.StrangeApiException
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NSwag", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class StrangeApiException : Exception
{
  public int StatusCode { get; private set; }

  public string Response { get; private set; }

  public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

  public StrangeApiException(
    string message,
    int statusCode,
    string response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    Exception innerException)
    : base($"{message}\n\nStatus: {statusCode.ToString()}\nResponse: \n{(response == null ? "(null)" : response.Substring(0, response.Length >= 512 /*0x0200*/ ? 512 /*0x0200*/ : response.Length))}", innerException)
  {
    this.StatusCode = statusCode;
    this.Response = response;
    this.Headers = headers;
  }

  public override string ToString() => $"HTTP Response: \n\n{this.Response}\n\n{base.ToString()}";
}
