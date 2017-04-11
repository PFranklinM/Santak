#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// System.Reflection.Emit.DynamicMethod
struct DynamicMethod_t2315379190;
// System.String
struct String_t;
// System.Type
struct Type_t;
// System.Type[]
struct TypeU5BU5D_t3339007067;
// System.Reflection.Module
struct Module_t1394482686;
// System.Delegate
struct Delegate_t3310234105;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Object[]
struct ObjectU5BU5D_t1108656482;
// System.Reflection.Emit.ILGenerator
struct ILGenerator_t1499877190;
// System.Reflection.ParameterInfo[]
struct ParameterInfoU5BU5D_t2015293532;
// System.Object
struct Il2CppObject;
// System.Reflection.Binder
struct Binder_t1074302268;
// System.Globalization.CultureInfo
struct CultureInfo_t1065375142;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_String7231557.h"
#include "mscorlib_System_Type2863145774.h"
#include "mscorlib_System_Reflection_MethodAttributes1709777834.h"
#include "mscorlib_System_Reflection_CallingConventions2863034704.h"
#include "mscorlib_System_Reflection_Module1394482686.h"
#include "mscorlib_System_Reflection_Emit_DynamicMethod2315379190.h"
#include "mscorlib_System_Reflection_MethodImplAttributes1917366122.h"
#include "mscorlib_System_Object4170816371.h"
#include "mscorlib_System_Reflection_BindingFlags1523912596.h"
#include "mscorlib_System_Reflection_Binder1074302268.h"
#include "mscorlib_System_Globalization_CultureInfo1065375142.h"
#include "mscorlib_System_RuntimeMethodHandle2199484343.h"

// System.Void System.Reflection.Emit.DynamicMethod::.ctor(System.String,System.Type,System.Type[],System.Type)
extern "C"  void DynamicMethod__ctor_m606665232 (DynamicMethod_t2315379190 * __this, String_t* ___name0, Type_t * ___returnType1, TypeU5BU5D_t3339007067* ___parameterTypes2, Type_t * ___owner3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Reflection.Emit.DynamicMethod::.ctor(System.String,System.Type,System.Type[],System.Type,System.Boolean)
extern "C"  void DynamicMethod__ctor_m2648831853 (DynamicMethod_t2315379190 * __this, String_t* ___name0, Type_t * ___returnType1, TypeU5BU5D_t3339007067* ___parameterTypes2, Type_t * ___owner3, bool ___skipVisibility4, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Reflection.Emit.DynamicMethod::.ctor(System.String,System.Reflection.MethodAttributes,System.Reflection.CallingConventions,System.Type,System.Type[],System.Type,System.Boolean)
extern "C"  void DynamicMethod__ctor_m859215507 (DynamicMethod_t2315379190 * __this, String_t* ___name0, int32_t ___attributes1, int32_t ___callingConvention2, Type_t * ___returnType3, TypeU5BU5D_t3339007067* ___parameterTypes4, Type_t * ___owner5, bool ___skipVisibility6, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Reflection.Emit.DynamicMethod::.ctor(System.String,System.Reflection.MethodAttributes,System.Reflection.CallingConventions,System.Type,System.Type[],System.Type,System.Reflection.Module,System.Boolean,System.Boolean)
extern "C"  void DynamicMethod__ctor_m1053671628 (DynamicMethod_t2315379190 * __this, String_t* ___name0, int32_t ___attributes1, int32_t ___callingConvention2, Type_t * ___returnType3, TypeU5BU5D_t3339007067* ___parameterTypes4, Type_t * ___owner5, Module_t1394482686 * ___m6, bool ___skipVisibility7, bool ___anonHosted8, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Reflection.Emit.DynamicMethod::create_dynamic_method(System.Reflection.Emit.DynamicMethod)
extern "C"  void DynamicMethod_create_dynamic_method_m1649915426 (DynamicMethod_t2315379190 * __this, DynamicMethod_t2315379190 * ___m0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Reflection.Emit.DynamicMethod::destroy_dynamic_method(System.Reflection.Emit.DynamicMethod)
extern "C"  void DynamicMethod_destroy_dynamic_method_m1269513496 (DynamicMethod_t2315379190 * __this, DynamicMethod_t2315379190 * ___m0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Reflection.Emit.DynamicMethod::CreateDynMethod()
extern "C"  void DynamicMethod_CreateDynMethod_m3438208709 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Reflection.Emit.DynamicMethod::Finalize()
extern "C"  void DynamicMethod_Finalize_m2361736761 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Delegate System.Reflection.Emit.DynamicMethod::CreateDelegate(System.Type)
extern "C"  Delegate_t3310234105 * DynamicMethod_CreateDelegate_m2432808878 (DynamicMethod_t2315379190 * __this, Type_t * ___delegateType0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.MethodInfo System.Reflection.Emit.DynamicMethod::GetBaseDefinition()
extern "C"  MethodInfo_t * DynamicMethod_GetBaseDefinition_m1000253417 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Object[] System.Reflection.Emit.DynamicMethod::GetCustomAttributes(System.Boolean)
extern "C"  ObjectU5BU5D_t1108656482* DynamicMethod_GetCustomAttributes_m885664777 (DynamicMethod_t2315379190 * __this, bool ___inherit0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Object[] System.Reflection.Emit.DynamicMethod::GetCustomAttributes(System.Type,System.Boolean)
extern "C"  ObjectU5BU5D_t1108656482* DynamicMethod_GetCustomAttributes_m1932918 (DynamicMethod_t2315379190 * __this, Type_t * ___attributeType0, bool ___inherit1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.Emit.ILGenerator System.Reflection.Emit.DynamicMethod::GetILGenerator()
extern "C"  ILGenerator_t1499877190 * DynamicMethod_GetILGenerator_m3180908743 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.Emit.ILGenerator System.Reflection.Emit.DynamicMethod::GetILGenerator(System.Int32)
extern "C"  ILGenerator_t1499877190 * DynamicMethod_GetILGenerator_m222860184 (DynamicMethod_t2315379190 * __this, int32_t ___streamSize0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.MethodImplAttributes System.Reflection.Emit.DynamicMethod::GetMethodImplementationFlags()
extern "C"  int32_t DynamicMethod_GetMethodImplementationFlags_m2542812648 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.ParameterInfo[] System.Reflection.Emit.DynamicMethod::GetParameters()
extern "C"  ParameterInfoU5BU5D_t2015293532* DynamicMethod_GetParameters_m4076757737 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Object System.Reflection.Emit.DynamicMethod::Invoke(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)
extern "C"  Il2CppObject * DynamicMethod_Invoke_m1504415078 (DynamicMethod_t2315379190 * __this, Il2CppObject * ___obj0, int32_t ___invokeAttr1, Binder_t1074302268 * ___binder2, ObjectU5BU5D_t1108656482* ___parameters3, CultureInfo_t1065375142 * ___culture4, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Reflection.Emit.DynamicMethod::IsDefined(System.Type,System.Boolean)
extern "C"  bool DynamicMethod_IsDefined_m1520191624 (DynamicMethod_t2315379190 * __this, Type_t * ___attributeType0, bool ___inherit1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Reflection.Emit.DynamicMethod::ToString()
extern "C"  String_t* DynamicMethod_ToString_m1996022506 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.MethodAttributes System.Reflection.Emit.DynamicMethod::get_Attributes()
extern "C"  int32_t DynamicMethod_get_Attributes_m2374936618 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.CallingConventions System.Reflection.Emit.DynamicMethod::get_CallingConvention()
extern "C"  int32_t DynamicMethod_get_CallingConvention_m3873003882 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Type System.Reflection.Emit.DynamicMethod::get_DeclaringType()
extern "C"  Type_t * DynamicMethod_get_DeclaringType_m1927904293 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.RuntimeMethodHandle System.Reflection.Emit.DynamicMethod::get_MethodHandle()
extern "C"  RuntimeMethodHandle_t2199484343  DynamicMethod_get_MethodHandle_m88284214 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Reflection.Module System.Reflection.Emit.DynamicMethod::get_Module()
extern "C"  Module_t1394482686 * DynamicMethod_get_Module_m1463487787 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Reflection.Emit.DynamicMethod::get_Name()
extern "C"  String_t* DynamicMethod_get_Name_m2634297426 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Type System.Reflection.Emit.DynamicMethod::get_ReflectedType()
extern "C"  Type_t * DynamicMethod_get_ReflectedType_m1158351066 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Type System.Reflection.Emit.DynamicMethod::get_ReturnType()
extern "C"  Type_t * DynamicMethod_get_ReturnType_m2140318216 (DynamicMethod_t2315379190 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Reflection.Emit.DynamicMethod::AddRef(System.Object)
extern "C"  int32_t DynamicMethod_AddRef_m93074763 (DynamicMethod_t2315379190 * __this, Il2CppObject * ___reference0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
