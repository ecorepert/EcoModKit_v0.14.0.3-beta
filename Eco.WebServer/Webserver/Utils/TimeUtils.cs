// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Utils.TimeUtils
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.WebServer.Utils;

/// <summary>Helper classes for working with times inside the Eco web services.</summary>
public static class TimeUtils
{
  public static float InputDaysToQuerySeconds(double days, float maxSeconds);

  public static Range InputDaysToRangeSeconds(double startDays, double endDays, float maxSeconds);
}
