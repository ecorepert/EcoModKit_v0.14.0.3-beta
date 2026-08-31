// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.InfluenceObjects.InfluenceManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;

#nullable disable
namespace Eco.Gameplay.InfluenceObjects;

public class InfluenceManager : 
  Singleton<InfluenceManager>,
  IController,
  IViewController,
  IHasUniversalID
{
  public InfluenceChangeNotifier InfluenceChangeNotifier { get; }

  internal InfluenceMap AddMap(object handle, string displayName, float priority);

  public InfluenceMap GetMap(object handle);

  [DoNotNotify]
  public ref int ControllerID { get; }
}
