// Generated by Haxe 4.0.5
#ifndef INCLUDED_Game
#define INCLUDED_Game

#ifndef HXCPP_H
#include <hxcpp.h>
#endif

HX_DECLARE_CLASS0(Game)
HX_DECLARE_CLASS0(Move)



class HXCPP_CLASS_ATTRIBUTES Game_obj : public hx::Object
{
	public:
		typedef hx::Object super;
		typedef Game_obj OBJ_;
		Game_obj();

	public:
		enum { _hx_ClassId = 0x2f382012 };

		void __construct();
		inline void *operator new(size_t inSize, bool inContainer=false,const char *inName="Game")
			{ return hx::Object::operator new(inSize,inContainer,inName); }
		inline void *operator new(size_t inSize, int extra)
			{ return hx::Object::operator new(inSize+extra,false,"Game"); }
		static hx::ObjectPtr< Game_obj > __new();
		static hx::ObjectPtr< Game_obj > __alloc(hx::Ctx *_hx_ctx);
		static void * _hx_vtable;
		static Dynamic __CreateEmpty();
		static Dynamic __Create(hx::DynamicArray inArgs);
		//~Game_obj();

		HX_DO_RTTI_ALL;
		hx::Val __Field(const ::String &inString, hx::PropertyAccess inCallProp);
		static void __register();
		bool _hx_isInstanceOf(int inClassId);
		::String __ToString() const { return HX_("Game",12,20,38,2f); }

		void start( ::Move move);
		::Dynamic start_dyn();

};


#endif /* INCLUDED_Game */ 
