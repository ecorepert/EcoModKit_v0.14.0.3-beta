// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Holidays.HolidayConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Holidays;

/// <summary>Configuration model used by the <see cref="T:Eco.Gameplay.Holidays.HolidayPlugin" /> instance loaded from the "Holiday.eco" file in the server's config directory.</summary>
[Serialized]
public sealed class HolidayConfig
{
  /// <summary>Global flag for enabling/disabling all holidays without removing them from the server's configuration.</summary>
  [Serialized]
  public bool HolidaysEnabled { get; set; }

  /// <summary>Represents all configured holiday events that can be run on Eco Server.</summary>
  [Serialized]
  public ThreadSafeList<HolidayEvent> Holidays { get; set; }
}
