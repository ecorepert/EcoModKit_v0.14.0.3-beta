// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.ISyncRotationValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Systems;

[Serialized]
[ForceCreateView]
public interface ISyncRotationValue : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  [ClientInterfaceProperty]
  Quaternion Rotation { get; set; }

  [RPC]
  void SetRotation(Quaternion value);
}
