// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.NetworkStabilityStatistics
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Core.DebugStatistic;

/// <summary> This class is in charge of generating performance reports that will be exposed via API.
/// The main purpose of it is to give an opportunity for admins/devs to see how well server performs without having to log in or asking players.
/// The metric that is used for evaluate performance based on time between user sends an RPC and receives a updated property changed inside of that RPC.
/// It should simulate "how fast user will see result of his actions". The value is similar to ping but also considers the internal queues of the server/client, such as queue of network events, queue of properties to notify.
/// </summary>
public class NetworkStabilityStatistics : 
  AutoSingleton<NetworkStabilityStatistics>,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public bool Enabled { get; }

  public void AddPingData(float seconds, int id);

  public ref int ControllerID { get; }
}
