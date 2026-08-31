// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ReflectionUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Shared.Utils;

public static class ReflectionUtils
{
  public const BindingFlags HierarchyBindingWithStatic = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
  public const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
  public const BindingFlags HierarchyBinding = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
  public const BindingFlags LocalBinding = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
  public const BindingFlags LocalStaticBinding = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

  /// <summary> Check member is serialized, through SerializedAttribute, EcoAttribute or SerializedDerivedAttribute </summary>
  public static bool IsSerialized(this MemberInfo member);

  /// <summary>Checks if <see cref="T:System.Type" /> may be referenced in serialized data, but may not be serialized itself. Any <see cref="M:Eco.Shared.Utils.ReflectionUtils.IsSerialized(System.Reflection.MemberInfo)" /> type is also <see cref="M:Eco.Shared.Utils.ReflectionUtils.IsSerializedTypeName(System.Reflection.MemberInfo)" />, but not all <see cref="M:Eco.Shared.Utils.ReflectionUtils.IsSerializedTypeName(System.Reflection.MemberInfo)" /> types are <see cref="M:Eco.Shared.Utils.ReflectionUtils.IsSerialized(System.Reflection.MemberInfo)" />.</summary>
  public static bool IsSerializedTypeName(this MemberInfo member);

  /// <summary> Returns all derived types for <paramref name="baseType" /> optionally in specific <paramref name="assembly" /> and optionally (if <paramref name="includeSelf" /> set) returning the type itself. </summary>
  public static IEnumerable<Type> DerivedTypes(
    this Type baseType,
    Assembly? assembly = null,
    bool includeSelf = false);

  /// <summary> Returns all derived types for <paramref name="baseType" /> in <paramref name="assemblies" /> optionally (if <paramref name="includeSelf" /> set) returning the type itself. </summary>
  public static IEnumerable<Type> DerivedTypes(
    this IEnumerable<Assembly> assemblies,
    Type baseType,
    bool includeSelf = false);

  /// <summary>Return true if the given method has the exact list of types in this order as its signature.</summary>
  public static bool VerifySignature(this MethodInfo method, params Type[] types);

  /// <summary> Returns all types that implements interface <paramref name="interfaceType" />  </summary>
  public static IEnumerable<Type> ConcreteTypesWithInterface(
    this Type interfaceType,
    IEnumerable<Assembly>? assemblies = null);

  public static IEnumerable<Type> DerivedTypes<T>(
    this IEnumerable<Assembly> assemblies,
    bool includeSelf = false);

  public static IEnumerable<Type> ConcreteTypes(
    this Type baseType,
    Assembly? assembly = null,
    bool includeSelf = false);

  /// <summary>Returns all compile time implementations of <paramref name="genericTypeDefinition" />.</summary>
  public static IEnumerable<Type> GenericTypeImplementations(
    this Type genericTypeDefinition,
    Assembly assembly);

  /// <summary>Checks if <paramref name="type" /> has any generic parameters. I.e. when generic type used as based it isn't more generic type definition, but still has generic parameters in it's definition (i.e. base class for StringKeyDictionary{TValue} : Dictionary{string, TValue}).</summary>
  public static bool HasGenericParameters(this Type type);

  /// <summary> Checks if any base class is generic type from generic type definition. </summary>
  /// <sample><code>EconomyManager.IsInheritFromGenericTypeDefinition(typeof(Singleton&lt;&gt;)) // true</code></sample>
  public static bool IsInheritFromGenericTypeDefinition(this Type? type, Type genericTypeDefinition);

  /// <summary>Returns types that derive from this type in the given assembly (or all assemblies if null), and optionally the passed type itself, if it's creatable.</summary>
  public static IEnumerable<Type> CreatableTypes(
    this Type baseType,
    Assembly? assembly = null,
    bool includeSelf = false);

  /// <summary>Call a static function on the given type.</summary>
  public static void CallStatic(this Type type, string name, params object[] p);

  /// <summary>Try to call a static method, doing nothing if it doesn't exist or is wrong signature.</summary>
  public static void TryCallStatic(this Type type, string name, params object[] p);

  /// <summary>Call a static with an expected return type T</summary>
  public static T? CallStatic<T>(this Type type, string name, params object[] p);

  /// <summary>Call a static function of the given name, triggering an error if it doesnt exist.  T = return type</summary>
  public static T? TryCallStatic<T>(this Type type, string name, params object[] p);

  public static bool DerivesFrom(this Type derivedType, Type baseType);

  public static bool DerivesFrom<TBase>(this Type derivedType);

  public static bool IsParentOf(this Type baseType, Type derivedType);

  public static bool IsParentOf<TDerived>(this Type baseType);

  /// <summary> Gets all properties, methods, and extension methods.  Operates either on instance members or static members based on passed bool. </summary>
  public static IEnumerable<MemberInfo> AllMembers(this Type type, bool instanceMembers = true);

  /// <summary>Syntax sugar for <see cref="M:Eco.Shared.Utils.ReflectionUtils.WithAttribute``2(System.Collections.Generic.IEnumerable{``0},System.Boolean)" /> for property infos.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IEnumerable<PropertyInfo> WithAttribute<TAttr>(
    this IEnumerable<PropertyInfo> properties,
    bool inherit = true)
    where TAttr : System.Attribute;

  /// <summary>Filters <paramref name="members" /> to keep only members with <typeparamref name="TAttr" /> attribute(s).</summary>
  public static IEnumerable<TMember> WithAttribute<TMember, TAttr>(
    this IEnumerable<TMember> members,
    bool inherit = true)
    where TMember : MemberInfo
    where TAttr : System.Attribute;

  public static void PrepareCache(Type type, Type attributeType);

  /// <summary> Returns all public instance and static members that have the passed attribute, including from parent classes. </summary>
  public static IEnumerable<(MemberInfo Member, T Attr)> MembersWithAttribute<T>(
    this Type type,
    bool includeExtensions = true)
    where T : System.Attribute;

  /// <summary>Execute action for every member of type that has argument of type T.</summary>
  /// <param name="includeExtensions">Should extension methods be included?</param>
  public static void ForEachMemberWithAttribute<T>(
    this Type type,
    bool includeExtensions,
    Action<MemberInfo, T> action)
    where T : System.Attribute;

  /// <summary>Returns value of static field on <typeparamref name="TType" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TFieldType? GetStaticFieldValue<TType, TFieldType>(string fieldName);

  /// <summary>Returns value of static field on <paramref name="type" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T? GetStaticFieldValue<T>(this Type type, string fieldName);

  /// <summary>Returns a value of <paramref name="property" /> converted to <typeparamref name="T" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T? PropertyValue<T>(this object obj, PropertyInfo property);

  /// <summary>Returns a value of <paramref name="property" /> converted to <typeparamref name="T" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T? Value<T>(this PropertyInfo property, object? obj);

  public static T? Value<T>(this MemberInfo member, object o, params object[] parameters);

  public static object? Value(this MemberInfo member, object o, params object[] parameters);

  public static IEnumerable<MethodInfo> MethodsWithAttribute<T>(this Type type) where T : System.Attribute;

  /// <summary>Returns first attribute of type <typeparamref name="T" /> if exists, otherwise <c>null</c>.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T? Attribute<T>(this MemberInfo member, bool inherit = true) where T : System.Attribute;

  public static T? AttributeIncludingInterfaces<T>(this MemberInfo member) where T : System.Attribute;

  public static bool TryGetAttribute<T>(this MemberInfo member, bool inherit, [MaybeNullWhen(false)] out T attr) where T : System.Attribute;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static System.Attribute? Attribute(this MemberInfo member, Type type, bool inherit = true);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IEnumerable<T> Attributes<T>(this MemberInfo member, bool inherit = true) where T : System.Attribute;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool HasAttribute<T>(this MemberInfo member, bool inherit = true) where T : System.Attribute;

  public static bool HasAttribute<T>(this MemberInfo member, Func<T, bool> predicate, bool inherit = true) where T : System.Attribute;

  /// <summary>Checks if <paramref name="property" /> has attribute <typeparamref name="T" /> or any of interfaces declaring same property has the attribute.</summary>
  public static bool HasAttributeIncludingInterfaces<T>(this PropertyInfo property) where T : System.Attribute;

  public static bool HasAnyAttribute(this MemberInfo member, params Type[] attributes);

  public static bool IsAnonymous(this Action action);

  /// <summary>Collects all attributes of 'attributeToScan' in typeToScan itself and its Fields, Properties and Methods</summary>
  /// <param name="attributeToScan">Attribute to scan for.</param>
  /// <returns>Discovered MemberInfo and their attribute data.</returns>
  public static List<(MemberInfo Info, object Attr)> DeepAttributes(
    this Type typeToScan,
    Type attributeToScan);

  public static IEnumerable<MemberInfo> GetTypeMemberInfo(this Type typeToScan, BindingFlags flags);

  public static IEnumerable<Type> GetTypesWithAttribute<T>(bool inherited);

  /// <summary>Returns all types in the assembly with the attribute,</summary>
  /// <typeparam name="T">Attribute to find,</typeparam>
  /// <param name="assembly">Assembly to check,</param>
  /// <returns><see cref="T:System.Collections.Generic.IEnumerable`1" /> containing all the found types.</returns>
  public static IEnumerable<Type> GetTypesWithAttribute<T>(this Assembly assembly);

  public static bool HasDefaultConstructor(this Type t);

  /// <summary>Tries to get <paramref name="genericInterface" /> constructed from <paramref name="genericInterfaceDefinition" /> implemented by <paramref name="type" />.</summary>
  public static bool TryGetGenericInterface(
    this Type type,
    Type genericInterfaceDefinition,
    [MaybeNullWhen(false)] out Type genericInterface);

  /// <summary>Checks if <paramref name="genericType" /> is a generic type constructed from <paramref name="genericTypeDefinition" />.</summary>
  public static bool IsGenericTypeConstructedFrom(this Type genericType, Type genericTypeDefinition);

  public static Type? GetEnumerableType(this IEnumerable enumeration);

  public static Type? GetTypeFromFullName(string typeName);

  /// <summary>Try to get a property using reflection for the given name, and assign it to val, returning true if found.</summary>
  public static bool TryGetPropertyValueByName<T>(this object obj, string name, out T? val);

  public static T? GetPropertyValueByName<T>(this object obj, string name);

  public static bool SetPropertyByName(this object obj, string name, object value);

  public static bool IsHidden(this Type t);

  public static T GetStructPropertyByName<T>(this object obj, string name) where T : struct;

  public static string? GetStringPropertyByName(this object obj, string name);

  /// <summary> Checks if <paramref name="type" /> in <paramref name="namespace" /> (same or nested). </summary>
  public static bool InNamespace(this Type type, string @namespace);

  /// <summary> Checks if <paramref name="fieldInfo" /> is backing field (for auto-property). </summary>
  public static bool IsBackingField(this FieldInfo fieldInfo);

  /// <summary>
  /// Checks if <paramref name="field" /> may be accessed (without reflection) from <paramref name="assembly" />.
  /// It is possible in 3 cases:
  /// - field is "public";
  /// - field declared in the assembly;
  /// - field declared as "protected" or "protected internal" and field's owning type is in the assembly;
  /// <remarks>It currently doesn't support intermediate types through inheritance, i.e. in A (Assembly 1) : B (Assembly 2) : C (Assembly 3) if you check for Assembly 2 for A.field
  /// which is declared as protected in C then it will return false. Adding this check will make logic more complex and doesn't have practical usage for now.</remarks>
  /// </summary>
  public static bool CanAccess(this Assembly assembly, FieldInfo field);

  /// <summary>
  /// Checks if <paramref name="method" /> may be accessed (without reflection) from <paramref name="assembly" />.
  /// It is possible in 3 cases:
  /// - <paramref name="method" /> is "public";
  /// - <paramref name="method" /> declared in the <paramref name="assembly" />;
  /// - <paramref name="method" /> declared as "protected" or "protected internal" and <paramref name="method" />'s owning type is in the <paramref name="assembly" />;
  /// <remarks>It currently doesn't support intermediate types through inheritance, i.e. in A (Assembly 1) : B (Assembly 2) : C (Assembly 3) if you check for Assembly 2 for A.Method
  /// which is declared as protected in C then it will return false. Adding this check will make logic more complex and doesn't have practical usage for now.</remarks>
  /// </summary>
  public static bool CanAccess(this Assembly assembly, MethodInfo method);

  /// <summary> Goes over each assignable member of type T in the given object, gets the value in both 'object' and 'other', and calls the func to transform
  /// them into the final value.
  /// </summary>
  /// <typeparam name="T">The parameter type of properties we're looking at.</typeparam>
  /// <param name="target">The given object.</param>
  /// <param name="leftObj">The object providing the left value in the transformFunc</param>
  /// <param name="rightObj">The object providing the right value in the transformFunc</param>
  /// <param name="transformFunc">The function that accepts the property from both left and right, and returns the value of the new one. </param>
  public static void ZipByProperty<T>(
    this object target,
    object leftObj,
    object rightObj,
    Func<T, T, T> transformFunc)
    where T : new();

  /// <summary> Clones source, then assigns all int and float values a lerped-value relative to 'target' </summary>
  public static object BlendProperties(ICloneable source, ICloneable target, float lerp);

  public static string NameNoGeneric(this Type type);

  public static string NameNoGeneric(this MemberInfo info);

  public static string NameNoGeneric(this string type);

  /// <summary>Searches matching method starting from <paramref name="methodInfo" /> and then fallback to base class and interfaces. I.e. may be used to find base method in non-generic type.</summary>
  public static bool TryGetMatchingMethodWithInheritance(
    MethodInfo methodInfo,
    Func<MethodInfo, bool> predicate,
    [MaybeNullWhen(false)] out MethodInfo matchingMethodInfo);

  /// <summary>Tries to get first interface declaring <paramref name="methodInfo" /> matching <paramref name="predicate" />.</summary>
  public static bool TryGetMatchingInterfaceMethod(
    MethodInfo methodInfo,
    Func<MethodInfo, bool> predicate,
    [MaybeNullWhen(false)] out MethodInfo interfaceMethodInfo);

  /// <summary>Checks if <paramref name="methodInfo" /> is an extension method.</summary>
  public static bool IsExtension(this MethodInfo methodInfo);

  /// <summary>Checks if <paramref name="methodInfo" /> is an method override.</summary>
  public static bool IsOverride(this MethodInfo methodInfo);

  /// <summary>Try to get the extension type of the method if it's an extended method else return false.</summary>
  public static bool TryGetExtensionType(this MethodInfo methodInfo, [MaybeNullWhen(false)] out Type type);

  /// <summary>If the method is an extended one we get the extension type else we just get the method declaring type.</summary>
  public static Type GetMethodRealType(this MethodInfo methodInfo);

  /// <summary>
  /// Returns basest type in hierarchy matching <paramref name="predicate" />. All types higher in hierarchy also should match the <paramref name="predicate" />.
  /// Usually may be used to find a base type which first implements an interface: <code>type.BasestOrDefault(t =&gt; typeof(IController).IsAssignableFrom(t)).</code>
  /// </summary>
  public static Type? BasestOrDefault(this Type type, Func<Type, bool> predicate);

  /// <summary>Returns simple name (without explicit interface specification). I.e. Eco.Core.Systems.IRegistrar.IdToObj =&gt; IdToObj.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static string GetSimpleName(this MemberInfo member);

  /// <summary>Returns simple name (without explicit interface specification). I.e. Eco.Core.Systems.IRegistrar.IdToObj =&gt; IdToObj.</summary>
  public static string GetSimpleName(string name);

  /// <summary>Returns method with same name and arguments in <paramref name="type" /> (looking into declared members only). Returns <c>null</c> if such method not found.</summary>
  public static MethodInfo? GetMatchingMethod(this MethodInfo methodInfoInTypeDefinition, Type type);

  /// <summary>Returns (if exists) type corresponding to <paramref name="genericTypeDefinition" /> in <paramref name="type" /> hierarchy. I.e. if when check for List{}: List{string} -&gt; List{string}, IntList : List{int} -&gt; List{int}.</summary>
  public static Type? GetTypeByGenericTypeDefinitionInHierarchy(
    this Type type,
    Type genericTypeDefinition);

  /// <summary>Returns default value for <paramref name="type" />.</summary>
  /// <returns>Same as default(T) via reflection.</returns>
  public static object? GetDefaultValue(Type type);

  /// <summary>Add details on each of the properties and fields of the passed object.</summary>
  public static void ReflectionToString(StringBuilder sb, object obj);

  /// <summary>Get the properties on this type, and all properties in interface hierarchies it implements.</summary>
  public static IEnumerable<MemberInfo> GetAllMembers(this Type type, BindingFlags flags);

  /// <summary>Get a member from a given type, and include all the sub interfaces too, which usually arent included with default GetMember.</summary>
  public static MemberInfo? GetMemberFromAll(this Type type, string name, BindingFlags flags);

  /// <summary>Get the properties on this type, and all properties in interface hierarchies it implements.</summary>
  public static IEnumerable<PropertyInfo> GetPublicProperties(this Type type, BindingFlags flags);
}
