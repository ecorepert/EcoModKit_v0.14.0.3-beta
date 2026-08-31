// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Logging.EcoMicrosoftLoggerExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Microsoft.Extensions.Logging;
using System;

#nullable enable
namespace Eco.Core.Utils.Logging;

/// <summary>Extensions for <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" /></summary>
public static class EcoMicrosoftLoggerExtensions
{
  /// <summary>Registers the <see cref="T:Eco.Core.Utils.Logging.EcoMicrosoftLogger" /> <see cref="T:Microsoft.Extensions.Logging.ILogger" /> instance with the <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" />.</summary>
  public static ILoggingBuilder AddEcoMicrosoftLogger(this ILoggingBuilder builder);

  /// <inheritdoc cref="M:Eco.Core.Utils.Logging.EcoMicrosoftLoggerExtensions.AddEcoMicrosoftLogger(Microsoft.Extensions.Logging.ILoggingBuilder)" />
  /// <param name="configure"><see cref="T:Eco.Core.Utils.Logging.EcoMicrosoftLoggerConfiguration" /> configuration to use for this logger instance.</param>
  public static ILoggingBuilder AddEcoMicrosoftLogger(
    this ILoggingBuilder builder,
    Action<EcoMicrosoftLoggerConfiguration> configure);
}
