// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskEat
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;

#nullable disable
namespace Eco.Gameplay.Tutorial.Internal;

public class UserSubTaskEat : UserSubTaskSubscribe<FoodItem, WorldObject>
{
  public int NutrientIndex;
  public bool RequireTable;
  public bool RequireSeated;
  public string TableName;

  protected override ThreadSafeAction<FoodItem, WorldObject> Subscription { get; }

  protected override bool IsComplete(FoodItem item, WorldObject table);
}
