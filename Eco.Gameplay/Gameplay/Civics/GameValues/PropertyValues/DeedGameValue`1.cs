// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PropertyValues.DeedGameValue`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.PropertyValues;

public abstract class DeedGameValue<T> : GameValue<T>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The deed that will be checked.")]
  public GameValue<Eco.Gameplay.Property.Deed> Deed { get; set; }
}
