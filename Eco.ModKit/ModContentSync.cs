// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.ModContentSync
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.ModKit;

public sealed class ModContentSync
{
  public 
  #nullable disable
  BSONCachedValue Manifest;

  public ModContentSync(int maxCount = 5);

  /// <summary>Reads and clears the watcher's pending refresh request.</summary>
  public bool ConsumeRefreshRequest();

  /// <summary>Starts watching the mods folder so live refreshes react to file drops immediately instead of waiting for the next poll.</summary>
  public void StartWatching();

  public void RefreshContent();

  /// <summary>Sends the requested content files, returning whether all uploads completed. On a stalled upload the client is disconnected
  /// (a stuck reliable send never recovers, leaving the client hanging on a dead download) and remaining files are skipped.</summary>
  public Task<bool> SendContentFiles(List<string> requestList, INetClient targetClient);
}
