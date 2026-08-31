// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskTooltipOpened
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Items;
using System;

#nullable disable
namespace Eco.Gameplay.Tutorial.Internal;

/// <summary> Completes once the player opens a tooltip that derived from ItemType /// </summary>
public class UserSubTaskTooltipOpened : UserSubTaskSubscribe<TutorialWatch, Type>
{
  public Type ItemType;

  protected override ThreadSafeAction<TutorialWatch, Type> Subscription { get; }

  protected override bool IsComplete(TutorialWatch flag, Type type);

  protected override void OnInit();

  protected override void OnDeInit();
}
