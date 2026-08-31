// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Logging.LogWriterExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Logging;

/// <summary>Extension methods for <see cref="T:Eco.Shared.Logging.ILogWriter" /> for direct message logging.</summary>
public static class LogWriterExtensions
{
  public static string DescribeException(Exception ex);

  public static void WriteError(this ILogWriter logWriter, string message, bool stripTags = false);

  public static void WriteError(
    this ILogWriter logWriter,
    ILogWriter.ErrorInfo errorInfo,
    bool stripTags = false);
}
