// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.IScopeAwareEnumerable`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>
/// Interface for scope aware enumerable. Some methods may not consume enumerable immediately and may want to save enumerable reference.
/// In that case if enumerable isn't scoped then it may just save reference to enumerable otherwise it need to make a copy, because enumerable is only valid for the scope
/// (i.e. it may be modified when leaves scope or use inside LINQ references to objects which may become invalid after leaving scope - disposed or replaced).
/// This approach helps to safely pass enumerable to such methods with explicit scope control.
/// Usually you should either assume enumerable unscoped and just save reference to it, in other cases it may be only valid in the scope and you need to copy it.
/// You must follow rules to avoid problems and errors and most safe way is to always copy, but it is an expensive approach.
/// But using <see cref="T:Eco.Shared.Collections.IScopeAwareEnumerable`1" /> you may explicitly say if enumerable is only valid within a scope and then decide if you need to copy it or not when want to save reference.
/// This pattern inspired by C# 11 <c>scoped</c> keyword for references (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#scope-of-references-and-values).
/// <example><code language="CSharp"><![CDATA[
/// var l = new List<string> { "Hello", "World" };
/// Call(l.Unscoped()); // error, because `l` modified outside of scope (Clear call bellow) and can't be considered valid if leaves scope inside Call method
/// Call(l.Scoped());   // ok, if `l` have to leave scope inside of `Call` then it will be a copy of original list and won't be impacted by Clear call bellow
/// l.Clear();
/// Call(new List<string> { "Hello", "World" }.Unscoped());             // ok, because you don't have other references to List and it guaranteed to not be modified
/// Call(Enumerable.Range(1, 10).Select(i => i.ToString()).Unscoped()); // ok, because this enumerable doesn't depend on any shared state and may be safely resolved outside of scope
/// var db = new DB();
/// Call(Enumerable.Range(1, 10).Select(i => db.GetString(i)).Unscoped()); // error, because this enumerable depends on `db` which then disposed and if enumerable leaves scope of Call method and we will try to use it later then it will fail with error trying to access `db` object
/// db.Dispose();
/// 
/// void Call(IScopedEnumerable<string> enumerable)
/// {
///     IEnumerable<string> unscoped = enumerable.IsScoped ? enumerable.ToUnscopedCollection() : enumerable;
///     Task.Run(() => foreach (var item in unscoped) { Console.WriteLine(item); });
/// }
/// ]]></code></example>&gt;
/// </summary>
public interface IScopeAwareEnumerable<out T> : IEnumerable<T>, IEnumerable
{
  bool IsScoped { get; }

  /// <summary>Returns unscoped collection which may be safely used outside of local scope. Makes defensive copy for scoped enumerable.</summary>
  IReadOnlyCollection<T> ToUnscopedCollection();
}
