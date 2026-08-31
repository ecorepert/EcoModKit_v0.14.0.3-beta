// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Eval`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Core.Utils;

public class Eval<T> : Eval
{
  public bool Invalid;

  public T Val { get; set; }

  public bool Valid { get; }

  public Eval(T val);

  public Eval(LocString message, T val = null);

  public Eval(LocString message, bool invalid);

  public Eval<TValue> Prepend<TValue>(FormattableString s, TValue val = null);

  public Eval<T> Apply(Func<T, T> func);

  public Eval<T> Apply(FormattableString prepend, Func<T, T> func);

  public static ValResult<T> LocalizeStr(string s);

  public Eval<TNewType> ConvertTo<TNewType>() where TNewType : T;

  public Eval<TNewType> ConvertMessageOnly<TNewType>();

  public static implicit operator Eval<T>(T val);
}
