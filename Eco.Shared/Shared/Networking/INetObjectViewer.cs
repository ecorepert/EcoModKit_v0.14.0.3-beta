// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.INetObjectViewer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Networking;

public interface INetObjectViewer : INotifyNetObjectDestroy
{
  INetClient Client { get; }

  double LastSentUpdateTime { get; set; }

  void OnRemoveObject(INetObject netObject);

  void AddDestroyAction(Action<INetObjectViewer> action);

  void RemoveDestroyAction(Action<INetObjectViewer> action);
}
