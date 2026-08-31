// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.IWorldObserver
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Networking;

public interface IWorldObserver : INetObjectViewer, INotifyNetObjectDestroy
{
  ViewDistance ViewDistance { get; }

  ViewDistance ChunkViewDistance { get; }

  ViewDistance SimulationViewDistance { get; }

  Vector3 Position { get; }

  Vector3 FacingDir { get; }

  int ChangedChunksSendCapacity { get; set; }

  int ChunkColumnsSendCapacity { get; set; }

  Vector3 LastCheckedPosition { get; set; }

  float LastCheckedViewDistance { get; set; }

  bool IsInitialized { get; set; }

  string Name { get; }

  int ID { get; }

  void InfoBox(string msg);

  bool IsAdmin();

  object ConvertToType(Type type);

  void Error(LocString msg);
}
