// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.SyncedStringList
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Utils;

[Serialized]
public class SyncedStringList : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public IEnumerable<string> Val { get; set; }

  public void OnChanged();

  [DoNotNotify]
  public ref int ControllerID { get; }
}
