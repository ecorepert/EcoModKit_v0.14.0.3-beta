// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.DeltaControllerHashSetBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Networking;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Utils;

/// <summary>Base class factored out just so we can call an RPC (because RPCs dont work on generic types without it)</summary>
public abstract class DeltaControllerHashSetBase : IController, IViewController, IHasUniversalID
{
  [RPC]
  public abstract List<object> AddConsumerAndGetFullSet(INetClient consumer);

  [DoNotNotify]
  public ref int ControllerID { get; }
}
