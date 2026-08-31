// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Voice.VoiceChatUser
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Voice;

[Serialized]
public class VoiceChatUser : IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  public int Id { get; set; }

  [SyncToView(null, true)]
  public string VivoxId { get; set; }

  [SyncToView(null, true)]
  public string Username { get; set; }

  public User User { get; set; }
}
