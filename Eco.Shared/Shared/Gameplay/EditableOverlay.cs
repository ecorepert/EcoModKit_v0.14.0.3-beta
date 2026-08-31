// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.EditableOverlay
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.UI;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Gameplay;

/// Basic implementation for IEntryOverlay. Used to sent/recieve data at map edit request.
///             Note that this type is not a controller, but will be sent back and forth between both client and server, IE the client can edit it and send it back.
///             For example, when a user requests to edit an overlay, the client will send this structure to the server after the edit, containing the changes.
public class EditableOverlay : IMapEntryOverlay, IMinimapOption
{
  [Eco.Shared.Networking.Eco(true)]
  public Dictionary<int, MapEntry> MapEntries { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public Array2D<int> Map { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public string Name { get; set; }

  [Eco.Shared.Networking.Eco(true, Serialized = false)]
  public LocString MarkedUpName { get; set; }

  public EditableOverlay();

  public EditableOverlay(IMapEntryOverlay overlay);

  public Action OverlayUpdatedEvent { get; set; }

  public bool HasData { get; }
}
