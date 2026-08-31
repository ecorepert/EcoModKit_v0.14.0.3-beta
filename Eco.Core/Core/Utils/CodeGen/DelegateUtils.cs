// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.CodeGen.DelegateUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Reflection;

#nullable enable
namespace Eco.Core.Utils.CodeGen;

/// <summary>Class containing utility methods that provide faster alternatives to using relfection in the runtime.</summary>
/// <remarks>For more information see the wiki page at https://github.com/StrangeLoopGames/Eco/wiki/Delegate-Utils.</remarks>
public static class DelegateUtils
{
  /// <summary>
  /// Creates delegate factory for <paramref name="methodInfo" /> allowing fast delegate creation bounded to an instance.
  /// It generates and returns compiled <see cref="T:System.Reflection.Emit.DynamicMethod" /> as:
  /// <code>
  /// public TDelegate MethodDelegateFactory(object obj) =&gt; obj.Method;
  /// </code>
  /// Performance of such generated method is about same as if write a same statically compiled method.
  /// Alternative approach with <c>(TDelegate)Delegate.CreateDelegate(typeof(TDelegate), obj, methodInfo)</c> is ~24 times slower (6.7728ns vs 161.0455ns).
  /// May be used when you need to create a delegate with same method, but a different instance.
  /// </summary>
  public static Func<object, TDelegate> CreateMethodDelegateFactory<TDelegate>(
    this MethodInfo methodInfo)
    where TDelegate : Delegate;

  /// <summary>Creates delegate that can invoke given method on an instance passed to it. Using returned delegate is ~40 times faster than calling Invoke on MethodInfo.</summary>
  /// <typeparam name="TDelegate">
  /// Type of the created delegate. Must have the same return type as method for which it is generated and
  /// take instance on which the method will be called as its first parameter. Other parameters must match parameters taken by the method.
  /// </typeparam>
  /// <param name="methodInfo">Method for which delegate will be created.</param>
  /// <remarks>If method is to be called multiple times on the same instance <see cref="M:Eco.Core.Utils.CodeGen.DelegateUtils.CreateMethodDelegateFactory``1(System.Reflection.MethodInfo)" /> can be used for better performance.</remarks>
  public static TDelegate CreateMethodInvoker<TDelegate>(this MethodInfo methodInfo) where TDelegate : Delegate;

  /// <summary>Creates a delegate that can invoke given method on an instance passed to it. Using returned delegate is ~40 times faster than calling Invoke on MethodInfo.</summary>
  /// <typeparam name="TDelegate">
  /// Type of the created delegate. Must return object if method for which it is generated has any return type and
  /// take object reference pointing to instance on which the method will be called as its first parameter.
  /// Other parameters must also be of object type and their count has to match the number of parameters taken by the method.
  /// </typeparam>
  /// <param name="methodInfo">Method for which delegate will be created.</param>
  /// <remarks>This method creates a delegates that take objects as parameters and return nothing or an object. If you know parameter types and return type at compile time use <see cref="M:Eco.Core.Utils.CodeGen.DelegateUtils.CreateMethodInvoker``1(System.Reflection.MethodInfo)" /> instead.</remarks>
  public static TDelegate CreateCastingMethodInvoker<TDelegate>(this MethodInfo methodInfo) where TDelegate : Delegate;

  /// <summary>Creates a delegate that returns value of given property on instance that is passed to it. Using returned delegate is ~25 times faster than calling GetValue on PropertyInfo.</summary>
  /// <typeparam name="TDeclaring">Type which declares the property.</typeparam>
  /// <typeparam name="TProperty">Type of the property.</typeparam>
  /// <param name="propertyInfo">Property for which delegate will be created.</param>
  public static Func<TDeclaring, TProperty> CreatePropertyValueGetter<TDeclaring, TProperty>(
    this PropertyInfo propertyInfo);

  /// <summary>Creates a delegate that returns value of given property on instance that is passed to it. Using returned delegate is ~25 times faster than calling GetValue on PropertyInfo.</summary>
  /// <param name="propertyInfo">Property for which delegate will be created.</param>
  /// <remarks>This method creates a delegate that takes and returns an object. If you know declaring type and type of the property at compile time use <see cref="M:Eco.Core.Utils.CodeGen.DelegateUtils.CreatePropertyValueGetter``2(System.Reflection.PropertyInfo)" /> instead.</remarks>
  public static Func<object, object> CreateCastingPropertyValueGetter(this PropertyInfo propertyInfo);

  /// <summary>Same as <see cref="M:Eco.Core.Utils.CodeGen.DelegateUtils.CreateMethodDelegateFactory``1(System.Reflection.MethodInfo)" />, but returns untyped delegate.</summary>
  public static Func<object, Delegate> CreateMethodDelegateFactory(this MethodInfo methodInfo);
}
