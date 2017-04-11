#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

// fpsClass
struct fpsClass_t1351734799;
// UnityEngine.GUIText
struct GUIText_t3371372606;
// System.Object
struct Il2CppObject;

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array1146569071.h"
#include "AssemblyU2DUnityScript_U3CModuleU3E86524790.h"
#include "AssemblyU2DUnityScript_U3CModuleU3E86524790MethodDeclarations.h"
#include "AssemblyU2DUnityScript_fpsClass1351734799.h"
#include "AssemblyU2DUnityScript_fpsClass1351734799MethodDeclarations.h"
#include "mscorlib_System_Void2863195528.h"
#include "UnityEngine_UnityEngine_MonoBehaviour667441552MethodDeclarations.h"
#include "mscorlib_System_Single4291918972.h"
#include "UnityEngine_UnityEngine_Component3501516275MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Object3071478659MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Behaviour200106419MethodDeclarations.h"
#include "UnityEngine_UnityEngine_GUIText3371372606.h"
#include "UnityEngine_UnityEngine_Component3501516275.h"
#include "mscorlib_System_Boolean476798718.h"
#include "UnityEngine_UnityEngine_Object3071478659.h"
#include "mscorlib_System_String7231557.h"
#include "mscorlib_System_Object4170816371.h"
#include "UnityEngine_UnityEngine_Time4241968337MethodDeclarations.h"
#include "Boo_Lang_Boo_Lang_Runtime_RuntimeServices3947355960MethodDeclarations.h"
#include "UnityEngine_UnityEngine_GUIText3371372606MethodDeclarations.h"
#include "mscorlib_System_Int321153838500.h"
#include "mscorlib_System_Single4291918972MethodDeclarations.h"

// !!0 UnityEngine.Component::GetComponent<System.Object>()
extern "C"  Il2CppObject * Component_GetComponent_TisIl2CppObject_m267839954_gshared (Component_t3501516275 * __this, const MethodInfo* method);
#define Component_GetComponent_TisIl2CppObject_m267839954(__this, method) ((  Il2CppObject * (*) (Component_t3501516275 *, const MethodInfo*))Component_GetComponent_TisIl2CppObject_m267839954_gshared)(__this, method)
// !!0 UnityEngine.Component::GetComponent<UnityEngine.GUIText>()
#define Component_GetComponent_TisGUIText_t3371372606_m3481831379(__this, method) ((  GUIText_t3371372606 * (*) (Component_t3501516275 *, const MethodInfo*))Component_GetComponent_TisIl2CppObject_m267839954_gshared)(__this, method)
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void fpsClass::.ctor()
extern "C"  void fpsClass__ctor_m72125409 (fpsClass_t1351734799 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2022291967(__this, /*hidden argument*/NULL);
		__this->set_updateInterval_2((0.5f));
		return;
	}
}
// System.Void fpsClass::Start()
extern Il2CppClass* Object_t3071478659_il2cpp_TypeInfo_var;
extern const MethodInfo* Component_GetComponent_TisGUIText_t3371372606_m3481831379_MethodInfo_var;
extern Il2CppCodeGenString* _stringLiteral1412040755;
extern const uint32_t fpsClass_Start_m3314230497_MetadataUsageId;
extern "C"  void fpsClass_Start_m3314230497 (fpsClass_t1351734799 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (fpsClass_Start_m3314230497_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		GUIText_t3371372606 * L_0 = Component_GetComponent_TisGUIText_t3371372606_m3481831379(__this, /*hidden argument*/Component_GetComponent_TisGUIText_t3371372606_m3481831379_MethodInfo_var);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t3071478659_il2cpp_TypeInfo_var);
		bool L_1 = Object_op_Implicit_m2106766291(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_0026;
		}
	}
	{
		MonoBehaviour_print_m1497342762(NULL /*static, unused*/, _stringLiteral1412040755, /*hidden argument*/NULL);
		Behaviour_set_enabled_m2046806933(__this, (bool)0, /*hidden argument*/NULL);
		goto IL_0032;
	}

IL_0026:
	{
		float L_2 = __this->get_updateInterval_2();
		__this->set_timeleft_5(L_2);
	}

IL_0032:
	{
		return;
	}
}
// System.Void fpsClass::Update()
extern Il2CppClass* RuntimeServices_t3947355960_il2cpp_TypeInfo_var;
extern const MethodInfo* Component_GetComponent_TisGUIText_t3371372606_m3481831379_MethodInfo_var;
extern Il2CppCodeGenString* _stringLiteral97648079;
extern Il2CppCodeGenString* _stringLiteral3212;
extern const uint32_t fpsClass_Update_m3962749772_MetadataUsageId;
extern "C"  void fpsClass_Update_m3962749772 (fpsClass_t1351734799 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (fpsClass_Update_m3962749772_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_timeleft_5();
		float L_1 = Time_get_deltaTime_m2741110510(NULL /*static, unused*/, /*hidden argument*/NULL);
		__this->set_timeleft_5(((float)((float)L_0-(float)L_1)));
		float L_2 = __this->get_accum_3();
		float L_3 = Time_get_timeScale_m1970669766(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_4 = Time_get_deltaTime_m2741110510(NULL /*static, unused*/, /*hidden argument*/NULL);
		__this->set_accum_3(((float)((float)L_2+(float)((float)((float)L_3/(float)L_4)))));
		int32_t L_5 = __this->get_frames_4();
		__this->set_frames_4(((int32_t)((int32_t)L_5+(int32_t)1)));
		float L_6 = __this->get_timeleft_5();
		if ((((float)L_6) > ((float)(((float)((float)0))))))
		{
			goto IL_0090;
		}
	}
	{
		GUIText_t3371372606 * L_7 = Component_GetComponent_TisGUIText_t3371372606_m3481831379(__this, /*hidden argument*/Component_GetComponent_TisGUIText_t3371372606_m3481831379_MethodInfo_var);
		float L_8 = __this->get_accum_3();
		int32_t L_9 = __this->get_frames_4();
		V_0 = ((float)((float)L_8/(float)(((float)((float)L_9)))));
		String_t* L_10 = Single_ToString_m639595682((&V_0), _stringLiteral3212, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(RuntimeServices_t3947355960_il2cpp_TypeInfo_var);
		String_t* L_11 = RuntimeServices_op_Addition_m3391097550(NULL /*static, unused*/, _stringLiteral97648079, L_10, /*hidden argument*/NULL);
		GUIText_set_text_m1963534853(L_7, L_11, /*hidden argument*/NULL);
		float L_12 = __this->get_updateInterval_2();
		__this->set_timeleft_5(L_12);
		__this->set_accum_3((((float)((float)0))));
		__this->set_frames_4(0);
	}

IL_0090:
	{
		return;
	}
}
// System.Void fpsClass::Main()
extern "C"  void fpsClass_Main_m56368316 (fpsClass_t1351734799 * __this, const MethodInfo* method)
{
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
