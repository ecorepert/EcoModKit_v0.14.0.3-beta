// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ExecActionHelper
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Civics;

internal static class ExecActionHelper
{
  public static LocString Executor(User user, bool useLink = true);

  public static LocString Describe(
    GameValue<bool> ifDesc,
    IDescribable thenDesc,
    IDescribable elseDesc);

  public static PostResult Perform(
    IContextObject context,
    GameValue<bool> ifTest,
    Func<PostResult> doThen,
    Func<PostResult> doElse);
}
