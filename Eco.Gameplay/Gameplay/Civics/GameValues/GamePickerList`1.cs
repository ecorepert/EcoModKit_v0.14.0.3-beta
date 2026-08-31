// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GamePickerList`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary>
/// Generic version of GamePickerList. Gives access to the wrapped type of GamePickerList through reflection. Non-generic version is still supported.
/// This happens because to obtain 'MustDeriveType', we'd need the object's instance, which is hard and inefficient to obtain.
/// So, the generic version is introduced to wrap 'MustDeriveType' under 'T'. Now 'MustDeriveType' is easily obtainable through `memberInfo.GenericTypeArguments[0]`.
/// </summary>
public class GamePickerList<T> : GamePickerList, ICloneable
{
  protected GamePickerList();

  public GamePickerList(string emptyDesc = null);

  public IEnumerable<T> Values { get; }

  object ICloneable.Clone();
}
