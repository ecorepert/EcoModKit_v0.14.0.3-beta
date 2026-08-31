// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Logging.NLogManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Logging;

#nullable enable
namespace Eco.Core.Utils.Logging;

/// <summary>
/// <see cref="T:Eco.Core.Utils.Logging.NLogManager" /> class provides high level API with pre-configured defaults for <see cref="T:Eco.Core.Utils.Logging.NLogWriter" /> creation.
/// <see cref="T:Eco.Core.Utils.Logging.NLogWriter" /> is implementation of <see cref="T:Eco.Shared.Logging.ILogWriter" /> interface wrapping NLog library <see cref="T:NLog.Logger" />.
/// To get default logger you may use <see cref="M:Eco.Core.Utils.Logging.NLogManager.GetEcoLogWriter" /> and if you need separate log (i..e admin commands log, chat log etc) then you can use <see cref="M:Eco.Core.Utils.Logging.NLogManager.GetLogWriter(System.String)" /> with any valid file name.
/// </summary>
public static class NLogManager
{
  /// <summary>Returns custom <see cref="T:Eco.Core.Utils.Logging.NLogWriter" /> outputting to Logs/{name}/ directory. If <paramref name="name" /> is "Eco" then it will return default logger which output files to Logs directory.</summary>
  public static NLogWriter GetLogWriter(string name);

  /// <summary>Returns default Eco log writer configured to produce log files in Logs directory and output same messages to console with <see cref="T:Eco.Core.Utils.Logging.ConsoleLogWriter" />.</summary>
  public static ILogWriter GetEcoLogWriter();

  /// <summary>Synchronously flushes all pending disk changes.</summary>
  public static void Flush();
}
