// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.UserSubTaskSubscribe
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;

#nullable disable
namespace Eco.Gameplay.Tutorial;

public abstract class UserSubTaskSubscribe : UserSubTask
{
  protected abstract ThreadSafeAction Subscription { get; }

  protected virtual bool IsComplete();

  protected void CheckComplete();

  protected override void OnInit();

  protected override void OnDeInit();
}
