// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.DateTimeUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class DateTimeUtils
{
  /// <summary>Take number from string as minutes and count a new date from current time.</summary>
  /// <param name="time">String should follow the template: 1m || 1h || 1d || 1w</param>
  public static (bool Result, DateTime Date) DateTimeFromString(string time);
}
