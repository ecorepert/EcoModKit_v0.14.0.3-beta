// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.ModKitConfig
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Eco.Core.Plugins;
using Eco.Core.Utils;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.ModKit;

[Localized(true, false, "", false)]
[IgnoreHostedWorlds]
public class ModKitConfig
{
  [LocDescription("Whether to use a whitelist to choose which mods to load.  If disabled, all mods will be loaded.")]
  public bool WhitelistEnabled { get; set; }

  [LocDescription("If the WhitelistEnabled setting is turned on, the whitelist of mods to load, by .dll file name")]
  public SerializedSynchronizedCollection<string> Whitelist { get; set; }

  [LocDescription("Check for unity file updates regularly. (Useful if you are actively building mod bundles and don't want to restart the server to test changes.)")]
  public bool LiveUpdateUnityFiles { get; set; }

  [LocDescription("List of mod.io mod ids that this server is subscribed to.")]
  public SerializedSynchronizedCollection<int> SubscribedMods { get; set; }

  [LocDescription("Preserve or not auto-generated Eco.Mods.dll assembly. When server started it will be saved in current directory.")]
  public bool PreserveGeneratedModsAssembly { get; set; }

  [LocDescription("The max count of clients that can download mods at the same time.")]
  public int MaxNumberOfDownloadRequests { get; set; }
}
