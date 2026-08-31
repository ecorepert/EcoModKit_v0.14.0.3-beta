// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.ServerLogHandler
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Systems;

/// <summary>A Handler to help propagating Log messages from client to server. Can be used when client error need to be duplicated in server log for easier issue investigation.</summary>
public class ServerLogHandler : 
  AutoSingleton<ServerLogHandler>,
  IController,
  IViewController,
  IHasUniversalID
{
  public static void InitSingleton();

  [RPC]
  public static void SendErrorToServer(string error, string username);

  ref int IHasUniversalID.ControllerID { get; }
}
