// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.Picker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Utils;

[Serialized]
public abstract class Picker : IController, IViewController, IHasUniversalID
{
  [Serialized]
  public string Category { get; set; }

  [Serialized]
  public Vector3i Pos { get; set; }

  [Serialized]
  public string PrependMarker { get; set; }

  [Serialized]
  public string MarkerUsername { get; set; }

  [Serialized]
  public string Description { get; set; }

  public abstract Deed Deed { get; }

  public abstract bool IsSet { get; }

  [SyncToView(null, true)]
  public abstract string Choice { get; }

  public ThreadSafeAction<User> OnContentsChanged { get; }

  public bool ContainsPropertyAt(Vector2i pos);

  public int TotalPropertyArea { get; }

  public bool Authed(User user);

  public ref int ControllerID { get; }

  public Picker();

  public Picker(string cat = null, string description = null);

  [RPC]
  public void Pick(Player player);

  protected virtual BSONValue GetView(Player player);

  public virtual void Initialize();

  [RPC]
  public virtual void SetLocation(Player player, PointOfInterest obj);

  public virtual Result ValidOwnership(string pickerName, User user);

  public virtual void Accepted(string prepend, User user);

  public void Finished();

  protected virtual void UpdateMarks();

  protected void ChoiceChanged();
}
