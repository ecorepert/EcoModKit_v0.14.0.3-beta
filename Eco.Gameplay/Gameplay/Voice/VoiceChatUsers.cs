// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Voice.VoiceChatUsers
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Voice;

[Serialized]
public class VoiceChatUsers : 
  Singleton<VoiceChatUsers>,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  [Serialized]
  public ControllerList<VoiceChatUser> Users { get; }

  public int Count { get; }

  [SyncToView(null, true)]
  public int AudibleDistance { get; set; }

  [SyncToView(null, true)]
  public int ConversationalDistance { get; set; }

  [SyncToView(null, true)]
  public int AudioFadeModel { get; set; }

  [SyncToView(null, true)]
  public float AudioFadeIntensityByDistance { get; set; }

  public void Initialize();

  public void AddUser(User user);

  public void RemoveUser(User user);

  public ref int ControllerID { get; }

  /// <summary> Makes sure props change will run on 1 static pros so clients can reconnect to voice </summary>
  public void OnChanged();
}
