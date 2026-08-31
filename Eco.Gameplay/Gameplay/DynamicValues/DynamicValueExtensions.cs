// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.DynamicValueExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public static class DynamicValueExtensions
{
  public static float GetCurrentValue(this IDynamicValue value, User user);

  public static float GetCurrentValue(this IDynamicValue value, User user, object obj);
}
