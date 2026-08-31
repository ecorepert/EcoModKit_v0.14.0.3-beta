// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.PropError
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Core.Utils.PropertyScanning;

public class PropError : IController, IViewController, IHasUniversalID
{
  public static PropError MakeLoc(FormattableString error, ScanScope scope);

  public static PropError Make(LocString error, ScanScope scope);

  [SyncToView(null, true)]
  public string PropPath { get; set; }

  [SyncToView(null, true)]
  public string PropPathDisplay { get; set; }

  [SyncToView(null, true)]
  public LocString Error { get; set; }

  public override bool Equals(object other);

  public override int GetHashCode();

  public ref int ControllerID { get; }
}
