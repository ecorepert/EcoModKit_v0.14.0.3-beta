// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModuleAdminCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary>Admin chat commands for the plugin-module system. <c>/admin clearmodules</c> wipes installed modules from craft stations near the player; bypasses <see cref="T:Eco.Gameplay.Items.PermanentModuleRestriction" /> via the privileged <see cref="M:Eco.Gameplay.Items.InventoryChangeSet.Clear(Eco.Gameplay.Items.Inventory)" /> path.</summary>
[ChatCommandHandler]
public static class ModuleAdminCommands
{
  [ChatSubCommand("Admin", "Clears all installed plugin modules from worldobjects within the given radius (default 5m). Bypasses the permanence restriction; modules are destroyed, not returned to anyone.", "clearmodules", ChatAuthorizationLevel.Admin)]
  public static void ClearModules(User user, float radius = 5f);
}
