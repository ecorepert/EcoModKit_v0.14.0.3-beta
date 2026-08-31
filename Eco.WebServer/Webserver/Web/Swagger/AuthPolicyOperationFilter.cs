// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Swagger.AuthPolicyOperationFilter
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

#nullable disable
namespace Eco.WebServer.Web.Swagger;

/// <summary>Custom <seealso cref="T:Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter" /> for populating Eco authentication information into the server's Swagger documentation.</summary>
public class AuthPolicyOperationFilter : IOperationFilter
{
  public void Apply(OpenApiOperation operation, OperationFilterContext context);
}
