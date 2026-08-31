// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.NetworkStabilityMetrics
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;

#nullable disable
namespace Eco.Core.DebugStatistic;

/// <summary> This class provides a RPC for client so it can add ping data to network stability manager. It will 1 per user, so users will have its own Pong subscription.  </summary>
internal class NetworkStabilityMetrics : IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }
}
