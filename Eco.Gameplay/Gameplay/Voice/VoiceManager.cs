// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Voice.VoiceManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Voice;

/// <summary> Manages voice clusters for player voice chat wrapping </summary>
[Serialized]
[ChatCommandHandler]
[Priority(200)]
public class VoiceManager : 
  Singleton<VoiceManager>,
  IEditablePluginData,
  ISimplePluginData,
  IStorage,
  ISerializable
{
  public IPersistent StorageHandle { get; set; }

  public object EditObject { get; set; }

  public VoiceConfig VoiceConfig { get; }

  public string GetCategory();

  public string GetDisplayText();

  public string GetStatus();

  public override string ToString();

  public void OnEditObjectChanged(object o, string param);

  public void SyncVoiceConfigs();

  public void Initialize();

  /// <summary>
  /// This function works the fact that game world space loops but Vivox does not. It creates clusters of players
  /// that can possibly hear each other, which then get offset by the client.
  /// </summary>
  public void UpdateClusters();
}
