// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Holidays.HolidayManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Holidays;

/// <summary>
/// Singleton plugin class that manages holidays. This class is responsible for checking if holidays are enabled and swapping out the current holiday.
/// To utilize this on the client create addressable override content following the name pattern of NormalName_HolidayName. For example if you wanted to
/// create a holiday for "Christmas" that changed the elk to reindeer you would create a new addressable override content called "Elk_Christmas". When no override
/// content is present the default content is used.
/// 
/// This system can also be utilized from Eco's modkit. Overridable content can also be loaded from a mod's AssetBundle. Create a GameObject with the same name
/// scheme in the mod's objects scene.
/// </summary>
[Serialized]
public sealed class HolidayManager : 
  Singleton<HolidayManager>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IEditablePluginData,
  ISimplePluginData,
  IStorage,
  ISerializable
{
  [SyncToView(null, true)]
  public string CurrentEvent { get; }

  public HolidayConfig Config { get; }

  public void Initialize(TimedTask timer);

  public void Run();

  public Task ShutdownAsync();

  public string GetDisplayText();

  public string GetStatus();

  public string GetCategory();

  public override string ToString();

  /// <summary>
  /// Called when the user changes the server settings for the holiday plugin.
  /// Performs the normal config sav operation and checks if holidays are still enabled if they are not clears the current holiday.
  /// </summary>
  /// <inheritdoc cref="M:Eco.Core.Plugins.IEditablePluginData.OnEditObjectChanged(System.Object,System.String)" />
  public void OnEditObjectChanged(object o, string param);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  public object EditObject { get; set; }

  IPersistent IStorage.StorageHandle { get; set; }
}
