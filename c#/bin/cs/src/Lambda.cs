// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Lambda : global::haxe.lang.HxObject {
	
	public Lambda(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Lambda() {
		global::Lambda.__hx_ctor__Lambda(this);
	}
	
	
	protected static void __hx_ctor__Lambda(global::Lambda __hx_this) {
	}
	
	
	public static global::Array<A> array<A>(object it) {
		global::Array<A> a = new global::Array<A>();
		{
			object i = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, null)) );
			while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(i, "hasNext", 407283053, null))) {
				A i1 = global::haxe.lang.Runtime.genericCast<A>(global::haxe.lang.Runtime.callField(i, "next", 1224901875, null));
				a.push(i1);
			}
			
		}
		
		return a;
	}
	
	
}


