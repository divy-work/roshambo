// Generated by Haxe 4.0.5
package haxe.root;

import haxe.root.*;

@SuppressWarnings(value={"rawtypes", "unchecked"})
public class Main extends haxe.lang.HxObject
{
	public static void main(String[] args)
	{
		haxe.java.Init.init();
		{
			//line 1 "?"
			haxe.root.Main.main();
		}
	}
	
	public Main(haxe.lang.EmptyObject empty)
	{
	}
	
	
	public Main()
	{
		//line 29 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.root.Main.__hx_ctor__Main(this);
	}
	
	
	protected static void __hx_ctor__Main(haxe.root.Main __hx_this)
	{
	}
	
	
	public static void main()
	{
		//line 33 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.root.Game newGame = new haxe.root.Game();
		//line 32 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		java.lang.String line = haxe.root.Sys.stdin().readLine();
		//line 35 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.root.Move playerMove = ((haxe.root.Move) (haxe.root.Type.createEnum(((java.lang.Class) (haxe.root.Move.class) ), haxe.lang.Runtime.toString(line), ((haxe.root.Array) (null) ))) );
		//line 36 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		newGame.start(playerMove);
	}
	
	
}


