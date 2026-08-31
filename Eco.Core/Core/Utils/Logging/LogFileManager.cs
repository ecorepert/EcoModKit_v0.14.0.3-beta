// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Logging.LogFileManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;
using System.IO;

#nullable enable
namespace Eco.Core.Utils.Logging;

/// <summary>Utility log manager for accessing information about logs stored in a directory.</summary>
public class LogFileManager
{
  /// <summary>Represents the server's logging directory.</summary>
  public string LogDirectory;

  public LogFileManager(string logDirectory);

  /// <summary>Creates relative path from an absolute log file path.</summary>
  /// <param name="path">Absolute path of a log file.</param>
  /// <returns>Relative path string of the log file.</returns>
  public string GetRelativeToLogFolder(string path);

  /// <inheritdoc cref="M:Eco.Core.Utils.Logging.LogFileManager.GetRelativeToLogFolder(System.String)" />
  public IEnumerable<string> GetRelativeToLogFolder(IEnumerable<string> paths);

  /// <summary>Returns all log category folder paths currently on the server.</summary>
  /// <param name="category">Root directory to search for category folders.</param>
  /// <param name="options"><seealso cref="T:System.IO.SearchOption" /> to use in the file search</param>
  /// <returns>Array containing all discovered category folders.</returns>
  public string[] GetLogCategories(string category, SearchOption options = SearchOption.TopDirectoryOnly);

  /// <inheritdoc cref="M:Eco.Core.Utils.Logging.LogFileManager.GetLogCategories(System.String,System.IO.SearchOption)" />
  public string[] GetLogCategories(SearchOption options = SearchOption.TopDirectoryOnly);

  /// <summary>Retrieves a list of all log files in a log folder/category.</summary>
  /// <param name="category">Category/folder to search. Leaving this as an empty string searches the entire log directory.</param>
  /// <param name="options"><seealso cref="T:System.IO.SearchOption" /> to use in the file search</param>
  /// <returns></returns>
  public string[] GetLogFiles(string category, SearchOption options = SearchOption.TopDirectoryOnly);

  /// <inheritdoc cref="M:Eco.Core.Utils.Logging.LogFileManager.GetLogFiles(System.String,System.IO.SearchOption)" />
  public string[] GetLogFiles(SearchOption options = SearchOption.TopDirectoryOnly);

  /// <summary>Retrieves the full path to a local log file using its relative path. This also performs sub path validation.</summary>
  /// <param name="path">Relative or absolute log file path to retrieve/validate.</param>
  /// <returns>Full string path to the log file.</returns>
  public string GetLogFilePath(string path);
}
