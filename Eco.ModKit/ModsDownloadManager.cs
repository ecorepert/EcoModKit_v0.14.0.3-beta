// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.ModsDownloadManager
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Eco.ModKit.Internal;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.ModKit;

public static class ModsDownloadManager
{
  /// <summary>Get a list of mods from mod.io</summary>
  /// <param name="token"></param>
  /// <param name="offset"></param>
  /// <param name="pageSize">max number of results to return, can be a max of 100</param>
  /// <returns></returns>
  public static Task<ModList> GetModInfosAsync(CancellationToken token, int offset = 0, int pageSize = 100);

  public static Task<Dictionary<int, Mod>> GetModInfosAsync(
    IEnumerable<int> modIDs,
    CancellationToken token);

  public static Task<Mod?> GetModInfoAsync(int modID, CancellationToken token);

  public static Task<ModDependenciesData> GetModDependenciesAsync(Mod mod, CancellationToken token);

  public static Task DownloadModPackageAsync(
    Mod mod,
    CancellationToken token,
    IProgress<long>? progress);

  public static Task InstallModAsync(Mod mod, CancellationToken token);

  public static void UninstallMod(Mod mod);
}
