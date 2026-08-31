// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.LocalizationConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems;

[Localized(true, false, "", false)]
public class LocalizationConfig
{
  [LockedInChina]
  [LocDescription("The currently selected language. If you change languages, you'll need to restart the server for changes to fully take effect.")]
  public SupportedLanguage Language { get; set; }

  [NotLocalizedDisplayName("China Locked Mode")]
  [DebugCategory]
  [VisibleForQAOnly]
  [Description("Should Simplified Chinese only be enabled, or should the all languages. You'll need to restart the server for changes to fully take effect.")]
  [DontSerializeIntoTemplate]
  public bool ForceChinaLockedMode { get; set; }

  [NotLocalizedDisplayName("Debug English")]
  [DebugCategory]
  [VisibleForQAOnly]
  [Description("Debug translations. You'll need to restart the server for changes to fully take effect.")]
  [DontSerializeIntoTemplate]
  public bool DebugEnglish { get; set; }
}
