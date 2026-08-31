// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ColorItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>
/// Base class for items that have color.
/// Specifies color in name and tooltip with overrides.
/// Is unique stackable and has caching of dynamic props.
/// </summary>
[Serialized]
public abstract class ColorItem : Item, INotifyPropertyChanged
{
  public virtual LocString Label { get; }

  public virtual string ColoredOverlayName { get; }

  protected ColorItem();

  protected ColorItem(ByteColor color);

  [SyncToView(null, true)]
  [Serialized]
  [Notify]
  public ByteColor Color { get; protected set; }

  public override LocString DisplayName { get; }

  public override LocString MarkedUpName { get; }

  public LocString ColorName { get; }

  public override bool IsStackable { get; }

  public override int StackingHash { get; }

  public override bool RepresentsItem(Item other);

  public override int RepresentativeHash();

  public void SetColor(ByteColor color);

  protected override LocString ItemIconUILink(LocString text);

  public event PropertyChangedEventHandler PropertyChanged;

  public override Item Clone();

  /// <summary> Method that implements setting random color for this item type. Default implementation refers to default named colors without blends </summary>
  public virtual void SetRandomColor();
}
