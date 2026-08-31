// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.InfluenceObjects.IInfluencer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.InfluenceObjects;

[ForceCreateView]
public interface IInfluencer : 
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  [SyncToView(null, true)]
  Color Color { get; }

  int Priority { get; }
}
