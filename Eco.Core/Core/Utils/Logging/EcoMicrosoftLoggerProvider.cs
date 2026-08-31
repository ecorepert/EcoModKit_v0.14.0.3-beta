// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Logging.EcoMicrosoftLoggerProvider
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;

#nullable disable
namespace Eco.Core.Utils.Logging;

/// <summary><see cref="T:Microsoft.Extensions.Logging.ILoggerProvider" /> implementation for registering and using the <see cref="T:Eco.Core.Utils.Logging.EcoMicrosoftLogger" /> object.</summary>
public class EcoMicrosoftLoggerProvider : ILoggerProvider, IDisposable
{
  public EcoMicrosoftLoggerProvider(
    IOptionsMonitor<EcoMicrosoftLoggerConfiguration> config);

  public ILogger CreateLogger(string categoryName);

  /// <inheritdoc cref="M:System.IDisposable.Dispose" />
  protected virtual void Dispose(bool disposing);

  public void Dispose();
}
