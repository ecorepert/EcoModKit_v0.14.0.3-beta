// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipPartBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

[ConstantView]
public abstract class TooltipPartBase : IController, IViewController, IHasUniversalID
{
  /// <summary>The attribute from which this part was created.</summary>
  public NewTooltipAttributeBase Attribute { get; protected set; }

  [SyncToView(null, true)]
  public Type Type { get; }

  [SyncToView(null, true)]
  public Type BaseType { get; }

  [SyncToView(null, true)]
  public string Name { get; }

  [SyncToView(null, true)]
  public CacheAs CacheMode { get; }

  [SyncToView(null, true)]
  public bool RequiresOrigin { get; }

  [SyncToView(null, true)]
  public bool RequiresView { get; }

  [SyncToView(null, true)]
  public abstract bool IsTitle { get; }

  [SyncToView(null, true)]
  public abstract bool IsImage { get; }

  public bool RequiresUser { get; }

  public bool RequiresController { get; }

  protected TooltipPartBase(MemberInfo member, NewTooltipAttributeBase attr, Type rootType);

  protected TooltipPartBase.GetValueFromMember GetMemberDelegate(
    MethodInfo method,
    Type[] paramTypes);

  protected TooltipPartBase.GetValueFromMember GetMemberDelegate(PropertyInfo property);

  protected TooltipPartBase.GetValueFromMember GetMemberDelegate(FieldInfo field);

  /// <summary>Method that receives a delegate that can call the member marked with the attribute and return object returned by that member. Class overriding this should implement that method to internaly set up it's own generator delegate.</summary>
  /// <param name="generator">Delegate that can call member marked with the attribute and return object returned by that member.</param>
  /// <remarks>This method is called from the base constructor, so it can't rely on any data set in derived class's constructor.</remarks>
  protected abstract void SetGenerator(TooltipPartBase.GetValueFromMember generator);

  public abstract void ClearCache(int id);

  /// <summary>Generates text that represnets contents of this part for given context.</summary>
  /// <remarks>Generated string can be used to compare contents of parts and spot differences.</remarks>
  public abstract LocString GenerateDebugText(
    IController controller,
    TooltipOrigin origin,
    User user);

  public abstract List<KeyValuePair<(int ControllerID, TooltipOrigin Origin), LocString>> GetInternalCache();

  /// <summary>Create a reference to this part, omitting the controller and user ID if we dont care about them.</summary>
  public TooltipPartRef MakeRef(IController instance, int userId);

  /// <summary>Clear the cache of all tooltip parts and children parts.</summary>
  public static void ClearCache();

  public string DebugName();

  public string DebugName(string specificUser);

  protected int GetCacheKey(IController controller);

  [DoNotNotify]
  public ref int ControllerID { get; }

  /// <summary>Delegate that defines what parameters can members defining tooltip parts take.</summary>
  /// <returns>Returned object can be cast to proper type by derived classes that can pu constraints on what can be returned by specific tooltip members.</returns>
  protected delegate object GetValueFromMember(
    Type type,
    IController controller,
    User user,
    TooltipOrigin origin);
}
