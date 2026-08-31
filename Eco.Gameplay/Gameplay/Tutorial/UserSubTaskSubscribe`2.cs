// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.UserSubTaskSubscribe`2
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;

#nullable disable
namespace Eco.Gameplay.Tutorial;

public abstract class UserSubTaskSubscribe<TParam1, TParam2> : UserSubTask
{
  protected abstract ThreadSafeAction<TParam1, TParam2> Subscription { get; }

  protected virtual bool IsComplete(TParam1 p1, TParam2 p2);

  protected void CheckComplete(TParam1 p1, TParam2 p2);

  protected override void OnInit();

  protected override void OnDeInit();
}
