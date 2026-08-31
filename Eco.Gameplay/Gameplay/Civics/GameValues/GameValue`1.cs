// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValue`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

public abstract class GameValue<T> : GameValue
{
  public override (object Val, LocString Message) ValueAsObject(IContextObject action);

  /// <summary>Evaluates value with exception handling and returns <see cref="F:Eco.Core.Utils.Eval`1.Invalid" /> value if exception happens.</summary>
  public virtual Eval<T> Value(IContextObject action);

  /// TODO: In 10.0 make this abstract and Value non-virtual. We don't wanna break Mods API in intermediate release.
  protected virtual Eval<T> Evaluate(IContextObject action);

  public static Type ChoosesType { get; }
}
