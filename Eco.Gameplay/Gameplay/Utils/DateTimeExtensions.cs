// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.DateTimeExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class DateTimeExtensions
{
  /// <summary>Gets the number of seconds that represents the date and time of this instance.</summary>
  public static double TotalSeconds(this DateTime dateTime);

  /// <summary>Creates a new DateTime object with the same date as the given DateTime object, but with all values smaller then a second set to zero.</summary>
  public static DateTime LastWholeSecond(this DateTime time);
}
