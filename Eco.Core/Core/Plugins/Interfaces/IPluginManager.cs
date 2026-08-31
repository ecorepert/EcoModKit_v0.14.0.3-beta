// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IPluginManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.FileStorage;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

public interface IPluginManager
{
  IFileStorage BaseStorage { get; }

  IFileStorage ConfigStorage { get; }

  IFileStorage DefaultConfigStorage { get; }

  T GetPlugin<T>();

  void ForEach(Action<IServerPlugin> action);

  IEnumerable<IServerPlugin> Plugins { get; }

  bool Initialized { get; }

  void OpenServerUI();

  void RunIfOrWhenInited(Action action);

  /// <summary>
  /// Initiates shutdown procedure, but doesn't wait until it complete. It doesn't terminate code execution and so instruction after this call will be executed as usual.
  /// Optional <paramref name="exitCode" /> contains application exit code.
  /// </summary>
  /// <param name="exitCode">Exit code to return to the host operating system.</param>
  void FireShutdown(ApplicationExitCodes exitCode = ApplicationExitCodes.NormalShutdown);
}
