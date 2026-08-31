// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GamePickerListFactory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary>Helper class for <see cref="T:Eco.Gameplay.Civics.GameValues.GamePickerList" /> creation. With <see cref="M:Eco.Gameplay.Civics.GameValues.GamePickerListFactory.Create(System.Type)" /> method you can create best suitable <see cref="T:Eco.Gameplay.Civics.GameValues.GamePickerList" /> implementation for a base type. Use it instead of <see cref="T:Eco.Gameplay.Civics.GameValues.GamePickerList" /> constructor.</summary>
public static class GamePickerListFactory
{
  /// <summary>Creates new <see cref="T:Eco.Gameplay.Civics.GameValues.GamePickerList" /> best suitable for <paramref name="baseType" />.</summary>
  public static GamePickerList Create(Type baseType);
}
