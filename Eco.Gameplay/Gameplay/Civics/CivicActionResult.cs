// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicActionResult
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Civics;

public struct CivicActionResult
{
  public CivicArticle RelevantArticle;
  public CivicActionResult.ActionResult Result;
  public ElectionProcess ElectionNeeded;
  public LocString Details;

  public static CivicActionResult CanPerform(
    FormattableString details,
    CivicArticle article,
    ElectionProcess electionNeeded = null);

  public static CivicActionResult CannotPerform(FormattableString details, CivicArticle article);

  public string DescribeSelection();

  public enum ActionResult
  {
    ExecutorPrivilege,
    CannotPerform,
    ElectionRequired,
  }
}
