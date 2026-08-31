// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Authentication.ClaimExtensions
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

#nullable disable
namespace Eco.WebServer.Web.Authentication;

public static class ClaimExtensions
{
  /// <summary>Returns lowercase boolean value as string.</summary>
  /// <remarks>Implementation as suggested by Microsoft: https://docs.microsoft.com/en-us/dotnet/api/system.boolean.tostring#:~:text=This%20method%20returns%20the%20constants%20%22True%22%20or%20%22False%22.%20Note,should%20be%20called%20first%20to%20convert%20it%20to%20lowercase.</remarks>
  public static string ToStringLower(this bool value);
}
