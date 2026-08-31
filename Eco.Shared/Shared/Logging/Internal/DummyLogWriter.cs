// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Logging.Internal.DummyLogWriter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Logging.Internal;

/// <summary>Dummy log writer that does nothing.</summary>
/// <remarks>Use only for testing.</remarks>
internal class DummyLogWriter : ILogWriter
{
  public void Debug(string message);

  public void Write(string message);

  public void WriteError(ref ILogWriter.ErrorInfo errorInfo, bool stripTagsForConsole = false);

  public void WriteWarning(string message);
}
