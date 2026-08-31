// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.IDisplayErrorUI
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils.PropertyScanning;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

public interface IDisplayErrorUI
{
  ErrorDisplayData ErrorData { get; set; }

  [SyncToView(null, true)]
  List<PropError> Errors { get; set; }

  bool RootCanBeNull { get; }
}
