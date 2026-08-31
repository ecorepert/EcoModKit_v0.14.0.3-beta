// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.HouseValueGameValue`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

public abstract class HouseValueGameValue<T> : GameValue<T>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Defines what kind of house value will be queried.")]
  public HouseValue HouseValue { get; set; }

  protected string HouseValueDescription { get; }

  protected float GetHouseValue(Deed deed, IContextObject action);
}
