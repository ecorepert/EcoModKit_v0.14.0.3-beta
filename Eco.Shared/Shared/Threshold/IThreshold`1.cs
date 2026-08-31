// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Threshold.IThreshold`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Threshold;

/// <summary>
/// Threshold value interface. May be used to update value with threshold checking to avoid spamming value change events.
/// </summary>
public interface IThreshold<T> where T : struct
{
  /// <summary>
  /// Try pass threshold with specified <paramref name="delta" />. It will aggregate delta for multiple calls until the threshold reached then total delta value will reset.
  /// </summary>
  /// <param name="delta">delta between last value and new value.</param>
  /// <returns><c>true</c> if threshold passed with this (and all previous deltas), <c>false</c> otherwise.</returns>
  bool TryPass(T delta);

  /// <summary> Updates <paramref name="value" /> to <paramref name="newValue" />. It returns result of (see <see cref="M:Eco.Shared.Threshold.IThreshold`1.TryPass(`0)" />) for delta between <paramref name="value" /> and <paramref name="newValue" />. </summary>
  bool UpdateValue(ref T value, T newValue);

  /// <summary> It updates value as <see cref="M:Eco.Shared.Threshold.IThreshold`1.UpdateValue(`0@,`0)" />, but also clamps it to specified range and if the value changed and <paramref name="newValue" /> on bounds then returns <c>true</c>. </summary>
  bool ClampValue(ref T value, T newValue, T minValue, T maxValue);
}
