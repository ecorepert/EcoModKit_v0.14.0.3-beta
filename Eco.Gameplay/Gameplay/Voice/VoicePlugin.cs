// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Voice.VoicePlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Voice;

/// <summary> Separate voice plugin implementation for server UI configs. So VoiceManager holds only logic</summary>
[LocDisplayName("VoicePlugin")]
public class VoicePlugin : 
  EditablePlugin<
  #nullable disable
  VoiceManager, VoiceConfig>,
  IInitializablePlugin,
  IServerPlugin,
  IThreadedPlugin,
  IShutdownablePlugin
{
  public void Run();

  public void Initialize(TimedTask timer);

  public Task ShutdownAsync();

  public override string GetDisplayText();
}
