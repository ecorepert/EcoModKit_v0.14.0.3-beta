// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Streaming.StreamerManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using StrangeCloud.Service.Client.Contracts;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.Streaming;

/// <summary>Tracks currently brodcasting streamers in the server.</summary>
public class StreamerManager : IController, IViewController, IHasUniversalID
{
  public void RegisterStreams(IEnumerable<StreamInfo> streams);

  public IEnumerable<StreamInfo> Streams { get; }

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
