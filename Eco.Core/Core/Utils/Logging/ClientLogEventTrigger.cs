// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Logging.ClientLogEventTrigger
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Logging;
using System;

#nullable enable
namespace Eco.Core.Utils.Logging;

/// <summary>Implementation of <see cref="T:Eco.Shared.Logging.ILogWriter" /> that will trigger a log to an event, which is watched by the chatserver and sent
/// to the client.</summary>
public sealed class ClientLogEventTrigger : ILogWriter
{
  public static event Action<string>? OnLogWritten;

  public void Write(string message);

  public void WriteWarning(string message);

  public void WriteError(ref ILogWriter.ErrorInfo errorInfo, bool stripTagsForConsole = false);

  public void Debug(string message);
}
