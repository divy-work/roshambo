// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Game : global::haxe.lang.HxObject {
	
	public Game(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Game() {
		global::Game.__hx_ctor__Game(this);
	}
	
	
	protected static void __hx_ctor__Game(global::Game __hx_this) {
	}
	
	
	public virtual void start(global::Move move) {
		unchecked {
			object playerA = new global::haxe.lang.DynamicObject(new int[]{1214309137, 1224700491}, new object[]{move, "Simon"}, new int[]{}, new double[]{});
			global::System.Type e = typeof(global::Move);
			global::Move playerB = null;
			if ( ! (global::haxe.lang.Runtime.typeEq(e, null)) ) {
				global::Array<object> arr = global::Type.allEnums<object>(((global::System.Type) (e) ));
				playerB = ( (( ( arr != null ) && ( arr.length > 0 ) )) ? (((global::Move) (arr[((int) (global::System.Math.Floor(((double) (( (( ( arr.length - 1 ) + 1 )) * global::Math.rand.NextDouble() )) ))) )]) )) : (null) );
			}
			else {
				playerB = null;
			}
			
			object playerB1 = new global::haxe.lang.DynamicObject(new int[]{1214309137, 1224700491}, new object[]{playerB, "Nicolas"}, new int[]{}, new double[]{});
			global::Result result = null;
			global::Move _g = ((global::Move) (global::haxe.lang.Runtime.getField(playerB1, "move", 1214309137, true)) );
			switch (((global::Move) (global::haxe.lang.Runtime.getField(playerA, "move", 1214309137, true)) )._hx_index) {
				case 0:
				{
					if (( _g == null )) {
						result = global::Result.Draw;
					}
					else {
						switch (_g._hx_index) {
							case 1:
							{
								result = global::Result.Winner(playerB1);
								break;
							}
							
							
							case 2:
							{
								result = global::Result.Winner(playerA);
								break;
							}
							
							
							default:
							{
								result = global::Result.Draw;
								break;
							}
							
						}
						
					}
					
					break;
				}
				
				
				case 1:
				{
					if (( _g == null )) {
						result = global::Result.Draw;
					}
					else {
						switch (_g._hx_index) {
							case 0:
							{
								result = global::Result.Winner(playerA);
								break;
							}
							
							
							case 2:
							{
								result = global::Result.Winner(playerB1);
								break;
							}
							
							
							default:
							{
								result = global::Result.Draw;
								break;
							}
							
						}
						
					}
					
					break;
				}
				
				
				case 2:
				{
					if (( _g == null )) {
						result = global::Result.Draw;
					}
					else {
						switch (_g._hx_index) {
							case 0:
							{
								result = global::Result.Winner(playerB1);
								break;
							}
							
							
							case 1:
							{
								result = global::Result.Winner(playerA);
								break;
							}
							
							
							default:
							{
								result = global::Result.Draw;
								break;
							}
							
						}
						
					}
					
					break;
				}
				
				
			}
			
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("result: ", global::Std.@string(result)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"start", "Game", "src/Main.hx"}, new int[]{1981972957}, new double[]{((double) (25) )}));
		}
	}
	
	
	public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 67859554:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "start", 67859554)) );
				}
				
				
				default:
				{
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override object __hx_invokeField(string field, int hash, object[] dynargs) {
		unchecked {
			switch (hash) {
				case 67859554:
				{
					this.start(((global::Move) (dynargs[0]) ));
					break;
				}
				
				
				default:
				{
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
			return null;
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class EntryPoint__Main {
	public static void Main() {
		global::cs.Boot.init();
		{
			global::Main.main();
		}
	}
}

public class Main : global::haxe.lang.HxObject {
	
	public Main(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Main() {
		global::Main.__hx_ctor__Main(this);
	}
	
	
	protected static void __hx_ctor__Main(global::Main __hx_this) {
	}
	
	
	public static void main() {
		global::Game newGame = new global::Game();
		string line = ((global::haxe.io.Input) (new global::cs.io.NativeInput(((global::System.IO.Stream) (global::System.Console.OpenStandardInput()) ))) ).readLine();
		global::Move playerMove = ((global::Move) (global::Type.createEnum<object>(((global::System.Type) (typeof(global::Move)) ), ((string) (line) ), default(global::Array))) );
		newGame.start(playerMove);
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Move : global::haxe.lang.Enum {
	
	protected Move(int index) : base(index) {
	}
	
	
	public static readonly global::Move Rock = new global::Move_Rock();
	
	public static readonly global::Move Paper = new global::Move_Paper();
	
	public static readonly global::Move Scissors = new global::Move_Scissors();
	
	protected static readonly string[] __hx_constructs = new string[]{"Rock", "Paper", "Scissors"};
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class Move_Rock : global::Move {
	
	public Move_Rock() : base(0) {
	}
	
	
	public override string getTag() {
		return "Rock";
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class Move_Paper : global::Move {
	
	public Move_Paper() : base(1) {
	}
	
	
	public override string getTag() {
		return "Paper";
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class Move_Scissors : global::Move {
	
	public Move_Scissors() : base(2) {
	}
	
	
	public override string getTag() {
		return "Scissors";
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Result : global::haxe.lang.Enum {
	
	protected Result(int index) : base(index) {
	}
	
	
	public static global::Result Winner(object player) {
		return new global::Result_Winner(player);
	}
	
	
	public static readonly global::Result Draw = new global::Result_Draw();
	
	protected static readonly string[] __hx_constructs = new string[]{"Winner", "Draw"};
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class Result_Winner : global::Result {
	
	public Result_Winner(object player) : base(0) {
		this.player = player;
	}
	
	
	public override global::Array<object> getParams() {
		return new global::Array<object>(new object[]{this.player});
	}
	
	
	public override string getTag() {
		return "Winner";
	}
	
	
	public override int GetHashCode() {
		return global::haxe.lang.Enum.paramsGetHashCode(0, new object[]{this.player});
	}
	
	
	public override bool Equals(object other) {
		if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
			return true;
		}
		
		global::Result_Winner en = ( other as global::Result_Winner );
		if (( en == null )) {
			return false;
		}
		
		if ( ! (global::Type.enumEq<object>(((object) (this.player) ), ((object) (en.player) ))) ) {
			return false;
		}
		
		return true;
	}
	
	
	public override string toString() {
		return global::haxe.lang.Enum.paramsToString("Winner", new object[]{this.player});
	}
	
	
	public readonly object player;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class Result_Draw : global::Result {
	
	public Result_Draw() : base(1) {
	}
	
	
	public override string getTag() {
		return "Draw";
	}
	
	
}


