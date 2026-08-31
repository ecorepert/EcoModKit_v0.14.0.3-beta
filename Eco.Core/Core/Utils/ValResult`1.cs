// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ValResult`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Core.Utils;

public class ValResult<T> : Result
{
  public static ValResult<T> Default;

  public T Val { get; }

  public ValResult(T val);

  public ValResult(T val, LocString message);

  public ValResult(T val, LocString message, bool success);

  public ValResult(LocString message);

  public static ValResult<T> Localize(FormattableString s);

  public static ValResult<T> LocalizeStr(string s);

  public ValResult<T> MergeResult(Result result);
}
