// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.SystemCultureInfoManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Systems;

/// <summary>A manager for global culture info, like number formats and such, nothing to do with Eco Culture (that's in 'CultureManager')</summary>
public class SystemCultureInfoManager : 
  Singleton<SystemCultureInfoManager>,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public string ServerCultureDecimalSeparator { get; }

  [SyncToView(null, true)]
  public string ServerCultureGroupSeparator { get; }

  public static void InitSingleton();

  public ref int ControllerID { get; }
}
