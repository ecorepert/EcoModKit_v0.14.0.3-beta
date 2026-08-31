// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Filters.ExceptionFilter
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

#nullable enable
namespace Eco.WebServer.Web.Filters;

public class ExceptionFilter : IExceptionFilter, IFilterMetadata
{
  public ExceptionFilter(ILoggerFactory loggerFactory);

  public void OnException(ExceptionContext context);
}
