// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Type : global::haxe.lang.HxObject {
	
	public Type(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Type() {
		global::Type.__hx_ctor__Type(this);
	}
	
	
	protected static void __hx_ctor__Type(global::Type __hx_this) {
	}
	
	
	public static T createEnum<T>(global::System.Type e, string constr, global::Array @params) {
		if (( ( @params == null ) || ( ((int) (global::haxe.lang.Runtime.getField_f(@params, "length", 520590566, true)) ) == 0 ) )) {
			T ret = global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.slowGetField(e, constr, true));
			if (( ((object) (ret) ) is global::haxe.lang.Function )) {
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Constructor ", constr), " needs parameters"));
			}
			
			return ret;
		}
		else {
			object[] ret1 = new object[((int) (global::haxe.lang.Runtime.getField_f(@params, "length", 520590566, true)) )];
			global::cs.Lib.p_nativeArray<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@params) ))) ), ((global::System.Array) (ret1) ));
			return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.slowCallField(e, constr, ret1));
		}
		
	}
	
	
	public static global::Array<string> getClassFields(global::System.Type c) {
		if (global::System.Object.ReferenceEquals(((object) (c) ), ((object) (typeof(string)) ))) {
			return new global::Array<string>(new string[]{"fromCharCode"});
		}
		
		global::Array<string> ret = new global::Array<string>(new string[]{});
		global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Public, true);
		global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
		global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) )) ), true);
		global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
		global::System.Reflection.MemberInfo[] infos = ((global::System.Type) (c) ).GetMembers(((global::System.Reflection.BindingFlags) (this2) ));
		{
			int _g = 0;
			int _g1 = ( infos as global::System.Array ).Length;
			while (( _g < _g1 )) {
				int i = _g++;
				string name = ((global::System.Reflection.MemberInfo) (infos[i]) ).Name;
				if ( ! (name.StartsWith("__hx_")) ) {
					ret.push(name);
				}
				
			}
			
		}
		
		return ret;
	}
	
	
	public static global::Array<string> getEnumConstructs(global::System.Type e) {
		global::System.Type t = ((global::System.Type) (( ((object) (e) ) as global::System.Type )) );
		global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
		global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
		global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.NonPublic) ) )) ), true);
		global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
		global::System.Reflection.FieldInfo f = t.GetField(((string) ("__hx_constructs") ), ((global::System.Reflection.BindingFlags) (this2) ));
		if (( f != null )) {
			global::System.Array values = ((global::System.Array) (f.GetValue(default(object))) );
			string[] copy = new string[values.Length];
			global::System.Array.Copy(((global::System.Array) (values) ), ((global::System.Array) (copy) ), ((int) (values.Length) ));
			return new global::Array<string>(((string[]) (copy) ));
		}
		else {
			return new global::Array<string>(((string[]) (global::System.Enum.GetNames(((global::System.Type) (t) ))) ));
		}
		
	}
	
	
	public static bool enumEq<T>(T a, T b) {
		if (global::haxe.lang.Runtime.eq(a, default(T))) {
			return global::haxe.lang.Runtime.eq(b, default(T));
		}
		else if (global::haxe.lang.Runtime.eq(b, default(T))) {
			return false;
		}
		else {
			return a.Equals(b);
		}
		
	}
	
	
	public static int enumIndex(object e) {
		if (( e is global::System.Enum )) {
			global::System.Array values = global::System.Enum.GetValues(((global::System.Type) (((object) (e) ).GetType()) ));
			return global::System.Array.IndexOf(((global::System.Array) (values) ), ((object) (e) ));
		}
		else {
			return (((global::haxe.lang.Enum) (e) ))._hx_index;
		}
		
	}
	
	
	public static global::Array<T> allEnums<T>(global::System.Type e) {
		global::Array<string> ctors = global::Type.getEnumConstructs(e);
		global::Array<T> ret = new global::Array<T>(new T[]{});
		{
			int _g = 0;
			while (( _g < ctors.length )) {
				string ctor = ctors[_g];
				 ++ _g;
				T v = global::haxe.lang.Runtime.genericCast<T>(global::Reflect.field(e, ctor));
				if (global::Std.@is(v, e)) {
					ret.push(v);
				}
				
			}
			
		}
		
		return ret;
	}
	
	
}


