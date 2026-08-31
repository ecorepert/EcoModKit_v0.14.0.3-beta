// Decompiled with JetBrains decompiler
// Type: Eco.Mods.ChatLog.ChatLogger
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;

#nullable disable
namespace Eco.Mods.ChatLog;

/// <summary> Logs chat and related information (such as login/logout events) to plain text files for server administration purposes. </summary>
internal class ChatLogger : IModKitPlugin, IServerPlugin, IInitializablePlugin
{
  public string GetCategory();

  public override string ToString();

  public string GetStatus();

  public void Initialize(TimedTask timer);
}
