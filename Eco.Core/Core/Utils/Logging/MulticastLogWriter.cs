// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Logging.MulticastLogWriter
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Logging;

#nullable enable
namespace Eco.Core.Utils.Logging;

/// <summary>Implementation of <see cref="T:Eco.Shared.Logging.ILogWriter" /> allowing to write message to any number of different loggers.</summary>
public class MulticastLogWriter : ILogWriter
{
  public MulticastLogWriter(params ILogWriter[] writers);

  public void Write(string message);

  public void WriteWarning(string message);

  public void Debug(string message);

  public void WriteError(ref ILogWriter.ErrorInfo errorInfo, bool stripTags = false);
}
