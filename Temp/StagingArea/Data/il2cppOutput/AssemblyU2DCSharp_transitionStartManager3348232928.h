#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// doorMove
struct doorMove_t1201556639;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// transitionStartManager
struct  transitionStartManager_t3348232928  : public MonoBehaviour_t667441552
{
public:
	// System.Single transitionStartManager::doorTimer
	float ___doorTimer_2;
	// System.Boolean transitionStartManager::transitionIsCounting
	bool ___transitionIsCounting_3;
	// doorMove transitionStartManager::doorScript
	doorMove_t1201556639 * ___doorScript_4;
	// System.Boolean transitionStartManager::playerTouchedTransition
	bool ___playerTouchedTransition_5;

public:
	inline static int32_t get_offset_of_doorTimer_2() { return static_cast<int32_t>(offsetof(transitionStartManager_t3348232928, ___doorTimer_2)); }
	inline float get_doorTimer_2() const { return ___doorTimer_2; }
	inline float* get_address_of_doorTimer_2() { return &___doorTimer_2; }
	inline void set_doorTimer_2(float value)
	{
		___doorTimer_2 = value;
	}

	inline static int32_t get_offset_of_transitionIsCounting_3() { return static_cast<int32_t>(offsetof(transitionStartManager_t3348232928, ___transitionIsCounting_3)); }
	inline bool get_transitionIsCounting_3() const { return ___transitionIsCounting_3; }
	inline bool* get_address_of_transitionIsCounting_3() { return &___transitionIsCounting_3; }
	inline void set_transitionIsCounting_3(bool value)
	{
		___transitionIsCounting_3 = value;
	}

	inline static int32_t get_offset_of_doorScript_4() { return static_cast<int32_t>(offsetof(transitionStartManager_t3348232928, ___doorScript_4)); }
	inline doorMove_t1201556639 * get_doorScript_4() const { return ___doorScript_4; }
	inline doorMove_t1201556639 ** get_address_of_doorScript_4() { return &___doorScript_4; }
	inline void set_doorScript_4(doorMove_t1201556639 * value)
	{
		___doorScript_4 = value;
		Il2CppCodeGenWriteBarrier(&___doorScript_4, value);
	}

	inline static int32_t get_offset_of_playerTouchedTransition_5() { return static_cast<int32_t>(offsetof(transitionStartManager_t3348232928, ___playerTouchedTransition_5)); }
	inline bool get_playerTouchedTransition_5() const { return ___playerTouchedTransition_5; }
	inline bool* get_address_of_playerTouchedTransition_5() { return &___playerTouchedTransition_5; }
	inline void set_playerTouchedTransition_5(bool value)
	{
		___playerTouchedTransition_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
