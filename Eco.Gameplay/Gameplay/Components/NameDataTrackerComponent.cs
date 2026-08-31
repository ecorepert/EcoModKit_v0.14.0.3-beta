// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.NameDataTrackerComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Tracks object's name changes and saves it into persistent data.</summary>
[Serialized]
[Priority(-100)]
public class NameDataTrackerComponent : WorldObjectComponent, IPersistentData
{
  [Serialized]
  public NameItemData NameData { get; set; }

  public object PersistentData { get; set; }

  public override void Initialize();
}
