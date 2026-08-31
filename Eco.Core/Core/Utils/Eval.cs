// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Eval
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Core.Utils;

public class Eval
{
  public LocString Message;

  public Eval();

  public Eval(LocString message);

  public static Eval<T> Make<T>(LocString text, T value);

  public static Eval<T> Make<T>(FormattableString text, T value);

  public static Eval<T> MakeStr<T>(string text, T value);

  public static Eval<T> Make<T>(Func<T, LocString> nameFunc, T value);

  public static Eval<T> Make<T>(Func<T, FormattableString> textFunc, T value);

  public static Eval<T> Make<T>(Func<string, FormattableString> textFunc, ValResult<T> value);

  public static Eval<T> MakeFail<T>(LocString s);

  public static Eval<T> MakeFailLoc<T>(FormattableString text);

  public void Append(LocString text);

  public static ValResult<T> Make<T>(FormattableString prepend, ValResult<T> value);
}
