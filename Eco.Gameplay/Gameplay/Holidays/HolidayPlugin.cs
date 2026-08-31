// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Holidays.HolidayPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Holidays;

/// <inheritdoc cref="T:Eco.Gameplay.Holidays.HolidayManager" />
[LocDisplayName("HolidayPlugin")]
public sealed class HolidayPlugin : 
  EditablePlugin<HolidayManager, HolidayConfig>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IInitializablePlugin
{
  public void Run();

  public void Initialize(TimedTask timer);

  public Task ShutdownAsync();

  public override string ToString();
}
