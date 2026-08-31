// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Weaving.EcoLogger
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

#nullable enable
namespace Eco.ModKit.Internal.Weaving;

/// <summary><see cref="T:Eco.ModKit.Internal.Weaving.EcoLogger" /> implements Fody <see cref="T:ILogger" /> interface for Eco standard logger.</summary>
/// <inheritdoc />
public class EcoLogger : ILogger
{
  public bool ErrorOccurred { get; }

  public void SetCurrentWeaverName(string weaverName);

  public void ClearWeaverName();

  public void LogDebug(string message);

  public void LogInfo(string message);

  public void LogMessage(string message, int level);

  public void LogWarning(string message, string? code = "");

  public void LogWarning(
    string message,
    string? file,
    int lineNumber,
    int columnNumber,
    int endLineNumber,
    int endColumnNumber,
    string? code = "");

  public void LogError(
    string message,
    string? file,
    int lineNumber,
    int columnNumber,
    int endLineNumber,
    int endColumnNumber);

  public void LogError(string message);
}
