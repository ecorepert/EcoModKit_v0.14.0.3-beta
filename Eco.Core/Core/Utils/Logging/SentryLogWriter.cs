// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Logging.SentryLogWriter
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Logging;

#nullable enable
namespace Eco.Core.Utils.Logging;

/// <summary>Implementation of <see cref="T:Eco.Shared.Logging.ILogWriter" /> for logging details to Sentry.</summary>
public sealed class SentryLogWriter : ILogWriter
{
  /// <summary>Constant public url used to ingest data relating to EcoServer</summary>
  public const string SentryDsn = "https://7c5eee5398b2f6a4a9aef43cdf4ed15c@o4504650447847424.ingest.sentry.io/4506611657736192";
  public static readonly SentryLogWriter Instance;

  public void Write(string message);

  public void WriteWarning(string message);

  public void Debug(string message);

  public void WriteError(ref ILogWriter.ErrorInfo errorInfo, bool stripTagsForConsole = false);
}
