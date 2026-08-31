// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PaintableComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Graphics;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>
/// Adds painting support to world objects. World objects this component attached can have three colorable regions defined.
/// These regions receive color through shader inputs that apply channel 1 - 3 to RGB masked regions on the model.
/// </summary>
[Serialized]
[LocDescription("Set the paint colors of an object.")]
[HasIcon(null)]
public sealed class PaintableComponent : WorldObjectComponent, IPersistentData
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  public PaintableItemData PaintData { get; set; }

  public object PersistentData { get; set; }

  /// <summary>
  /// Sets a channel color to the specified color. If the color specified is <see cref="F:Eco.Shared.Utils.Color.ClearBlack" /> then the object
  /// reverts to its default color as defined in the client prefab.
  /// </summary>
  /// <param name="channel">Channel to modify. Accepts a value of 1 through 3.</param>
  /// <param name="color">Color to set the channel as.</param>
  /// <returns>True if the color was changed. Otherwise false.</returns>
  public bool SetColor(int channel, ByteColor color);

  public void SetColor(ByteColor color);

  /// <inheritdoc cref="M:Eco.Gameplay.Components.PaintableComponent.SetColor(System.Int32,Eco.Shared.Utils.ByteColor)" />
  public bool SetColor(int channel, NamedColors color);

  public bool ClearColor(int channel);

  public bool ClearColors();

  public bool GetColor(int channel, out ByteColor color);

  /// <summary> Check if target channel can accept paint. Ex if its already same paint if will return false, etc. </summary>
  public bool CanBePainted(ByteColor color, int channel);
}
