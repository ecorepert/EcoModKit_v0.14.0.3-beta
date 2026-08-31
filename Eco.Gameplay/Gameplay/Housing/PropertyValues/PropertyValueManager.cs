// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.PropertyValueManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Shared.Utils;

#nullable enable
namespace Eco.Gameplay.Housing.PropertyValues;

/// <summary>Tracks and updates the value of deeds dependent on what kind of property they are. Watches for changes from the RoomsPlugin.</summary>
public class PropertyValueManager : Singleton<
#nullable disable
PropertyValueManager>
{
  public ThreadSafeAction<Room> OnRoomValueChangedEvent { get; internal set; }

  public PropertyValue Make(Deed deed);

  public void Initialize();

  public void UpdateProperty(Deed deed);

  public void UpdateAllProperties();

  public void DoInitialPropertyUpdate();
}
