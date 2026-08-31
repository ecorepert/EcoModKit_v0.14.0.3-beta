// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PostResult
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

public class PostResult : Result
{
  public List<Func<LocString>> PostEffects;

  public static PostResult Succeeded { get; }

  public static PostResult FailedNoMessage { get; }

  public static PostResult None(string debug = null);

  public PostResult();

  public PostResult(ResultType type);

  public PostResult(FormattableString msg, bool shouldAllow);

  public PostResult(LocString msg, bool shouldAllow);

  public PostResult(Func<LocString> postEffect);

  public PostResult(Action postEffect);

  public override Result Merge(Result otherResult);

  public void AddPostEffect(Action action);

  public void DoPostResults();
}
