// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Logging.ILogWriter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Logging;

/// <summary>Interface for different log writer implementations.</summary>
public interface ILogWriter
{
  void Write(string message);

  void WriteWarning(string message);

  void WriteError(ref ILogWriter.ErrorInfo errorInfo, bool stripTagsForConsole = false);

  void Debug(string message);

  /// <summary>
  /// <see cref="T:Eco.Shared.Logging.ILogWriter.ErrorInfo" /> for error messages. It may be used for separate access to <see cref="F:Eco.Shared.Logging.ILogWriter.ErrorInfo.Message" /> and <see cref="F:Eco.Shared.Logging.ILogWriter.ErrorInfo.Exception" /> or to obtain cached <see cref="P:Eco.Shared.Logging.ILogWriter.ErrorInfo.MessageWithException" />.
  /// Main purpose of this struct to avoid expensive <see cref="P:Eco.Shared.Logging.ILogWriter.ErrorInfo.MessageWithException" /> build if there multiple log consumers.
  /// </summary>
  ref struct ErrorInfo
  {
    private string? messageWithException;
    public readonly string? Message;
    public readonly Exception? Exception;

    public string MessageWithException { get; }

    public ErrorInfo(string? message, Exception? exception);
  }
}
