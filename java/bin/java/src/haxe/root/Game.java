// Generated by Haxe 4.0.5
package haxe.root;

import haxe.root.*;

@SuppressWarnings(value={"rawtypes", "unchecked"})
public class Game extends haxe.lang.HxObject
{
	public Game(haxe.lang.EmptyObject empty)
	{
	}
	
	
	public Game()
	{
		//line 6 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.root.Game.__hx_ctor__Game(this);
	}
	
	
	protected static void __hx_ctor__Game(haxe.root.Game __hx_this)
	{
	}
	
	
	public void start(haxe.root.Move move)
	{
		//line 9 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		java.lang.Object playerA = new haxe.lang.DynamicObject(new java.lang.String[]{"move", "name"}, new java.lang.Object[]{move, "Simon"}, new java.lang.String[]{}, new double[]{});
		//line 10 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		java.lang.Class e = haxe.root.Move.class;
		//line 10 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.root.Move playerB = null;
		//line 10 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		if (( ((java.lang.Object) (e) ) != ((java.lang.Object) (null) ) )) 
		{
			//line 10 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			haxe.root.Array<haxe.root.Move> arr = ((haxe.root.Array<haxe.root.Move>) (((haxe.root.Array) (haxe.root.Type.allEnums(((java.lang.Class) (e) ))) )) );
			//line 10 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			playerB = ( (( ( arr != null ) && ( arr.length > 0 ) )) ? (arr.__get(((int) (java.lang.Math.floor(( (( ( arr.length - 1 ) + 1 )) * java.lang.Math.random() ))) ))) : (null) );
		}
		else
		{
			//line 10 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			playerB = null;
		}
		
		//line 10 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		java.lang.Object playerB1 = new haxe.lang.DynamicObject(new java.lang.String[]{"move", "name"}, new java.lang.Object[]{playerB, "Nicolas"}, new java.lang.String[]{}, new double[]{});
		//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.root.Result result = null;
		//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.root.Move _g = ((haxe.root.Move) (haxe.lang.Runtime.getField(playerB1, "move", true)) );
		//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		switch (((haxe.root.Move) (haxe.lang.Runtime.getField(playerA, "move", true)) ))
		{
			case Rock:
			{
				//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				if (( _g == null )) 
				{
					//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
					result = haxe.root.Result.Draw;
				}
				else
				{
					//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
					switch (_g)
					{
						case Paper:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Winner(playerB1);
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
						
						case Scissors:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Winner(playerA);
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
						
						default:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Draw;
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
					}
					
				}
				
				//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				break;
			}
			
			
			case Paper:
			{
				//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				if (( _g == null )) 
				{
					//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
					result = haxe.root.Result.Draw;
				}
				else
				{
					//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
					switch (_g)
					{
						case Rock:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Winner(playerA);
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
						
						case Scissors:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Winner(playerB1);
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
						
						default:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Draw;
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
					}
					
				}
				
				//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				break;
			}
			
			
			case Scissors:
			{
				//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				if (( _g == null )) 
				{
					//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
					result = haxe.root.Result.Draw;
				}
				else
				{
					//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
					switch (_g)
					{
						case Rock:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Winner(playerB1);
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
						
						case Paper:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Winner(playerA);
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
						
						default:
						{
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							result = haxe.root.Result.Draw;
							//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							break;
						}
						
					}
					
				}
				
				//line 13 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				break;
			}
			
			
		}
		
		//line 25 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		haxe.Log.trace.__hx_invoke2_o(0.0, ( "result: " + haxe.root.Std.string(result) ), 0.0, new haxe.lang.DynamicObject(new java.lang.String[]{"className", "fileName", "methodName"}, new java.lang.Object[]{"Game", "src/Main.hx", "start"}, new java.lang.String[]{"lineNumber"}, new double[]{((double) (((double) (25) )) )}));
	}
	
	
	@Override public java.lang.Object __hx_getField(java.lang.String field, boolean throwErrors, boolean isCheck, boolean handleProperties)
	{
		//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		{
			//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			boolean __temp_executeDef1 = true;
			//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			if (( field != null )) 
			{
				//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				switch (field.hashCode())
				{
					case 109757538:
					{
						//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
						if (field.equals("start")) 
						{
							//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							__temp_executeDef1 = false;
							//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							return ((haxe.lang.Function) (new haxe.lang.Closure(this, "start")) );
						}
						
						//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
						break;
					}
					
					
				}
				
			}
			
			//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			if (__temp_executeDef1) 
			{
				//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				return super.__hx_getField(field, throwErrors, isCheck, handleProperties);
			}
			else
			{
				//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				throw null;
			}
			
		}
		
	}
	
	
	@Override public java.lang.Object __hx_invokeField(java.lang.String field, java.lang.Object[] dynargs)
	{
		//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		{
			//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			boolean __temp_executeDef1 = true;
			//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			if (( field != null )) 
			{
				//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				switch (field.hashCode())
				{
					case 109757538:
					{
						//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
						if (field.equals("start")) 
						{
							//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							__temp_executeDef1 = false;
							//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
							this.start(((haxe.root.Move) (dynargs[0]) ));
						}
						
						//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
						break;
					}
					
					
				}
				
			}
			
			//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
			if (__temp_executeDef1) 
			{
				//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
				return super.__hx_invokeField(field, dynargs);
			}
			
		}
		
		//line 5 "/media/divy/Data/data/Projects/stone_paper_scrissor/java/src/Main.hx"
		return null;
	}
	
	
}


