// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.DevSectionConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Services;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Systems;

/// <summary>Settings for storing dev configs</summary>
[Localized(true, false, "", false)]
public class DevSectionConfig : Singleton<DevSectionConfig>
{
  [VisibleForQAOnly]
  [LocDescription("Defines hours offset for local and UTC time exhaustion debugging. Simple way to move exhaustion time back and forth.")]
  public float ExhaustionDateHoursOffset { get; set; }
}
