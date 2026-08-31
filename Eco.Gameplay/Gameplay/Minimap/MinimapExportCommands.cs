// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Minimap.MinimapExportCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Minimap;

[ChatCommandHandler]
public static class MinimapExportCommands
{
  [ChatCommand("Server data export tools.", ChatAuthorizationLevel.Admin)]
  public static void Export(IChatClient client);

  [ChatSubCommand("Export", "Dumps the tree subset of the live MinimapObject hashset to disk for bulk-load benchmarking. Optional <filename> overrides the auto timestamped basename.", "exporttreehashset", ChatAuthorizationLevel.Admin)]
  public static void TreeHashSet(IChatClient client, string filename = null);
}
