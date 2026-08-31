// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.MapEditRequest
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Gameplay;

public class MapEditRequest
{
  [Eco.Shared.Networking.Eco(true)]
  public EditableOverlay Overlay { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public Dictionary<int, EditableEntryStatus> EntryStatus { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool AllowNameChange { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool Readonly { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool AllowNewEntries { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public EditableEntryStatus DefaultEntryStatus { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public string MapHintTitle { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public LocString MapHint { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public string RelatedRegistrar { get; set; }
}
