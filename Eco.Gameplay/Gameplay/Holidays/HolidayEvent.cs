// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Holidays.HolidayEvent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Holidays;

/// <summary>Represents a configured holiday event that can be run on Eco Server.</summary>
[Serialized]
public struct HolidayEvent
{
  /// <summary>
  /// The name of the holiday event. This name is also used for creating override content for the holiday
  /// on Eco Client. Example supplying "Christmas" here will look for override content called "OriginalName_Christmas".
  /// </summary>
  public string HolidayName { get; set; }

  /// <summary>
  /// Flag for enabling/disabling this holiday without removing it from the server's
  /// configuration. This is useful for holidays the server operator does not want to run.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>Defines the start date of the holiday event. Years are automatically adjusted to match the current date.</summary>
  public DateTime StartDate { get; set; }

  /// <summary>Defines the end date of the holiday event. Years are automatically adjusted to match the current date.</summary>
  public DateTime EndDate { get; set; }

  public HolidayEvent();

  public HolidayEvent(string holidayName, bool enabled, DateTime startDate, DateTime endDate);

  public HolidayEvent(HolidayEvent holidayEvent);
}
