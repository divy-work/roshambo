// Generated by Haxe 4.0.5
#include <hxcpp.h>

#ifndef INCLUDED_95f339a1d026d52c
#define INCLUDED_95f339a1d026d52c
#include "hxMath.h"
#endif
#ifndef INCLUDED_Date
#include <Date.h>
#endif
#ifndef INCLUDED_Lambda
#include <Lambda.h>
#endif
#ifndef INCLUDED_Random
#include <Random.h>
#endif
#ifndef INCLUDED_Type
#include <Type.h>
#endif

HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_17_bool,"Random","bool",0x79247e55,"Random.bool","Random.hx",17,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_23_int,"Random","int",0x9a64c124,"Random.int","Random.hx",23,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_29_float,"Random","float",0xd268b111,"Random.float","Random.hx",29,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_35_string,"Random","string",0x190c43bc,"Random.string","Random.hx",35,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_47_date,"Random","date",0x7a6c5059,"Random.date","Random.hx",47,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_53_fromArray,"Random","fromArray",0xee9da1c4,"Random.fromArray","Random.hx",53,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_59_shuffle,"Random","shuffle",0xbd98b8ae,"Random.shuffle","Random.hx",59,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_75_fromIterable,"Random","fromIterable",0xe2c31767,"Random.fromIterable","Random.hx",75,0x4903e47b)
HX_LOCAL_STACK_FRAME(_hx_pos_e6ce86bad4751eed_81_enumConstructor,"Random","enumConstructor",0xfa5f572e,"Random.enumConstructor","Random.hx",81,0x4903e47b)

void Random_obj::__construct() { }

Dynamic Random_obj::__CreateEmpty() { return new Random_obj; }

void *Random_obj::_hx_vtable = 0;

Dynamic Random_obj::__Create(hx::DynamicArray inArgs)
{
	hx::ObjectPtr< Random_obj > _hx_result = new Random_obj();
	_hx_result->__construct();
	return _hx_result;
}

bool Random_obj::_hx_isInstanceOf(int inClassId) {
	return inClassId==(int)0x00000001 || inClassId==(int)0x2a85f987;
}

bool Random_obj::_hx_bool(){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_17_bool)
HXDLIN(  17)		return (::Math_obj::random() < ((Float)0.5));
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC0(Random_obj,_hx_bool,return )

int Random_obj::_hx_int(int from,int to){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_23_int)
HXDLIN(  23)		return (from + ::Math_obj::floor((( (Float)(((to - from) + 1)) ) * ::Math_obj::random())));
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC2(Random_obj,_hx_int,return )

Float Random_obj::_hx_float(Float from,Float to){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_29_float)
HXDLIN(  29)		return (from + ((to - from) * ::Math_obj::random()));
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC2(Random_obj,_hx_float,return )

::String Random_obj::string(int length,::String __o_charactersToUse){
            		::String charactersToUse = __o_charactersToUse;
            		if (hx::IsNull(__o_charactersToUse)) charactersToUse = HX_("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789",9f,35,ea,01);
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_35_string)
HXLINE(  36)		::String str = HX_("",00,00,00,00);
HXLINE(  37)		{
HXLINE(  37)			int _g = 0;
HXDLIN(  37)			int _g1 = length;
HXDLIN(  37)			while((_g < _g1)){
HXLINE(  37)				_g = (_g + 1);
HXDLIN(  37)				int i = (_g - 1);
HXLINE(  39)				str = (str + charactersToUse.charAt(::Math_obj::floor((( (Float)(((charactersToUse.length - 1) + 1)) ) * ::Math_obj::random()))));
            			}
            		}
HXLINE(  41)		return str;
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC2(Random_obj,string,return )

 ::Date Random_obj::date( ::Date earliest, ::Date latest){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_47_date)
HXDLIN(  47)		Float from = earliest->getTime();
HXDLIN(  47)		Float _hx_tmp = (latest->getTime() - from);
HXDLIN(  47)		return ::Date_obj::fromTime((from + (_hx_tmp * ::Math_obj::random())));
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC2(Random_obj,date,return )

 ::Dynamic Random_obj::fromArray(::cpp::VirtualArray arr){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_53_fromArray)
HXDLIN(  53)		bool _hx_tmp;
HXDLIN(  53)		if (hx::IsNotNull( arr )) {
HXDLIN(  53)			_hx_tmp = (arr->get_length() > 0);
            		}
            		else {
HXDLIN(  53)			_hx_tmp = false;
            		}
HXDLIN(  53)		if (_hx_tmp) {
HXDLIN(  53)			return arr->__get(::Math_obj::floor((( (Float)(((arr->get_length() - 1) + 1)) ) * ::Math_obj::random())));
            		}
            		else {
HXDLIN(  53)			return null();
            		}
HXDLIN(  53)		return null();
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC1(Random_obj,fromArray,return )

::cpp::VirtualArray Random_obj::shuffle(::cpp::VirtualArray arr){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_59_shuffle)
HXLINE(  60)		if (hx::IsNotNull( arr )) {
HXLINE(  61)			int _g = 0;
HXDLIN(  61)			int _g1 = arr->get_length();
HXDLIN(  61)			while((_g < _g1)){
HXLINE(  61)				_g = (_g + 1);
HXDLIN(  61)				int i = (_g - 1);
HXLINE(  62)				int j = ::Math_obj::floor((( (Float)(((arr->get_length() - 1) + 1)) ) * ::Math_obj::random()));
HXLINE(  63)				 ::Dynamic a = arr->__get(i);
HXLINE(  64)				 ::Dynamic b = arr->__get(j);
HXLINE(  65)				arr->set(i,b);
HXLINE(  66)				arr->set(j,a);
            			}
            		}
HXLINE(  69)		return arr;
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC1(Random_obj,shuffle,return )

 ::Dynamic Random_obj::fromIterable( ::Dynamic it){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_75_fromIterable)
HXDLIN(  75)		if (hx::IsNotNull( it )) {
HXDLIN(  75)			::cpp::VirtualArray arr = ::Lambda_obj::array(it);
HXDLIN(  75)			bool _hx_tmp;
HXDLIN(  75)			if (hx::IsNotNull( arr )) {
HXDLIN(  75)				_hx_tmp = (arr->get_length() > 0);
            			}
            			else {
HXDLIN(  75)				_hx_tmp = false;
            			}
HXDLIN(  75)			if (_hx_tmp) {
HXDLIN(  75)				return arr->__get(::Math_obj::floor((( (Float)(((arr->get_length() - 1) + 1)) ) * ::Math_obj::random())));
            			}
            			else {
HXDLIN(  75)				return null();
            			}
            		}
            		else {
HXDLIN(  75)			return null();
            		}
HXDLIN(  75)		return null();
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC1(Random_obj,fromIterable,return )

 ::Dynamic Random_obj::enumConstructor(hx::Class e){
            	HX_STACKFRAME(&_hx_pos_e6ce86bad4751eed_81_enumConstructor)
HXDLIN(  81)		if (hx::IsNotNull( e )) {
HXDLIN(  81)			::cpp::VirtualArray arr = ::Type_obj::allEnums(e);
HXDLIN(  81)			bool _hx_tmp;
HXDLIN(  81)			if (hx::IsNotNull( arr )) {
HXDLIN(  81)				_hx_tmp = (arr->get_length() > 0);
            			}
            			else {
HXDLIN(  81)				_hx_tmp = false;
            			}
HXDLIN(  81)			if (_hx_tmp) {
HXDLIN(  81)				return arr->__get(::Math_obj::floor((( (Float)(((arr->get_length() - 1) + 1)) ) * ::Math_obj::random())));
            			}
            			else {
HXDLIN(  81)				return null();
            			}
            		}
            		else {
HXDLIN(  81)			return null();
            		}
HXDLIN(  81)		return null();
            	}


STATIC_HX_DEFINE_DYNAMIC_FUNC1(Random_obj,enumConstructor,return )


Random_obj::Random_obj()
{
}

bool Random_obj::__GetStatic(const ::String &inName, Dynamic &outValue, hx::PropertyAccess inCallProp)
{
	switch(inName.length) {
	case 3:
		if (HX_FIELD_EQ(inName,"int") ) { outValue = _hx_int_dyn(); return true; }
		break;
	case 4:
		if (HX_FIELD_EQ(inName,"bool") ) { outValue = _hx_bool_dyn(); return true; }
		if (HX_FIELD_EQ(inName,"date") ) { outValue = date_dyn(); return true; }
		break;
	case 5:
		if (HX_FIELD_EQ(inName,"float") ) { outValue = _hx_float_dyn(); return true; }
		break;
	case 6:
		if (HX_FIELD_EQ(inName,"string") ) { outValue = string_dyn(); return true; }
		break;
	case 7:
		if (HX_FIELD_EQ(inName,"shuffle") ) { outValue = shuffle_dyn(); return true; }
		break;
	case 9:
		if (HX_FIELD_EQ(inName,"fromArray") ) { outValue = fromArray_dyn(); return true; }
		break;
	case 12:
		if (HX_FIELD_EQ(inName,"fromIterable") ) { outValue = fromIterable_dyn(); return true; }
		break;
	case 15:
		if (HX_FIELD_EQ(inName,"enumConstructor") ) { outValue = enumConstructor_dyn(); return true; }
	}
	return false;
}

#ifdef HXCPP_SCRIPTABLE
static hx::StorageInfo *Random_obj_sMemberStorageInfo = 0;
static hx::StaticInfo *Random_obj_sStaticStorageInfo = 0;
#endif

hx::Class Random_obj::__mClass;

static ::String Random_obj_sStaticFields[] = {
	HX_("bool",2a,84,1b,41),
	HX_("int",ef,0c,50,00),
	HX_("float",9c,c5,96,02),
	HX_("string",d1,28,30,11),
	HX_("date",2e,56,63,42),
	HX_("fromArray",cf,57,18,da),
	HX_("shuffle",f9,45,dd,e4),
	HX_("fromIterable",3c,7a,a3,33),
	HX_("enumConstructor",79,a7,32,c9),
	::String(null())
};

void Random_obj::__register()
{
	Random_obj _hx_dummy;
	Random_obj::_hx_vtable = *(void **)&_hx_dummy;
	hx::Static(__mClass) = new hx::Class_obj();
	__mClass->mName = HX_("Random",23,96,23,ec);
	__mClass->mSuper = &super::__SGetClass();
	__mClass->mConstructEmpty = &__CreateEmpty;
	__mClass->mConstructArgs = &__Create;
	__mClass->mGetStaticField = &Random_obj::__GetStatic;
	__mClass->mSetStaticField = &hx::Class_obj::SetNoStaticField;
	__mClass->mStatics = hx::Class_obj::dupFunctions(Random_obj_sStaticFields);
	__mClass->mMembers = hx::Class_obj::dupFunctions(0 /* sMemberFields */);
	__mClass->mCanCast = hx::TCanCast< Random_obj >;
#ifdef HXCPP_SCRIPTABLE
	__mClass->mMemberStorageInfo = Random_obj_sMemberStorageInfo;
#endif
#ifdef HXCPP_SCRIPTABLE
	__mClass->mStaticStorageInfo = Random_obj_sStaticStorageInfo;
#endif
	hx::_hx_RegisterClass(__mClass->mName, __mClass);
}

