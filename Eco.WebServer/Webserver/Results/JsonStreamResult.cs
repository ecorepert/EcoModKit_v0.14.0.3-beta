// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Results.JsonStreamResult
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Threading.Tasks;

#nullable enable
namespace Eco.WebServer.Results;

/// <summary>Custom implementation of <seealso cref="T:Microsoft.AspNetCore.Mvc.ActionResult" /> for streaming large amounts of JSON data using async methods from an <seealso cref="T:System.Collections.IEnumerable" /></summary>
public class JsonStreamResult : ActionResult
{
  /// <summary><seealso cref="T:System.Collections.IEnumerable" /> instance to stream over HTTP/HTTPS to the client.</summary>
  public 
  #nullable disable
  IEnumerable Enumerable { get; }

  public JsonStreamResult(IEnumerable enumerable);

  public override Task ExecuteResultAsync(ActionContext context);
}
