// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.IMvcNetClient
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using ConcurrentCollections;
using Eco.Shared.Collections;
using Eco.Shared.Networking;

#nullable enable
namespace Eco.Core.Controller;

public interface IMvcNetClient : INetClient, INetObject
{
  /// <summary>Packaged messages which should be delivered to client before any other message. Used for views and data blobs.</summary>
  SpinLockBuffer<byte[]> Views { get; }

  SpinLockBuffer<byte[]> Blobs { get; }

  bool ShouldNotify(IController controller, string memberName);

  ConcurrentHashSet<int> KnownBlobs { get; }

  ConcurrentHashSet<string> HashesOfCachedData { get; }

  void Request(IController controller, string name);

  bool IsRequested(IController controller, string name);
}
