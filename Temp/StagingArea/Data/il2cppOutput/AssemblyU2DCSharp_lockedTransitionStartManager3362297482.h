#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// lockedDoorMove
struct lockedDoorMove_t2161654217;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// lockedTransitionStartManager
struct  lockedTransitionStartManager_t3362297482  : public MonoBehaviour_t667441552
{
public:
	// System.Single lockedTransitionStartManager::doorTimer
	float ___doorTimer_2;
	// System.Boolean lockedTransitionStartManager::transitionIsCounting
	bool ___transitionIsCounting_3;
	// lockedDoorMove lockedTransitionStartManager::lockedDoorScript
	lockedDoorMove_t2161654217 * ___lockedDoorScript_4;
	// System.Boolean lockedTransitionStartManager::playerTouchedTransition
	bool ___playerTouchedTransition_5;

public:
	inline static int32_t get_offset_of_doorTimer_2() { return static_cast<int32_t>(offsetof(lockedTransitionStartManager_t3362297482, ___doorTimer_2)); }
	inline float get_doorTimer_2() const { return ___doorTimer_2; }
	inline float* get_address_of_doorTimer_2() { return &___doorTimer_2; }
	inline void set_doorTimer_2(float value)
	{
		___doorTimer_2 = value;
	}

	inline static int32_t get_offset_of_transitionIsCounting_3() { return static_cast<int32_t>(offsetof(lockedTransitionStartManager_t3362297482, ___transitionIsCounting_3)); }
	inline bool get_transitionIsCounting_3() const { return ___transitionIsCounting_3; }
	inline bool* get_address_of_transitionIsCounting_3() { return &___transitionIsCounting_3; }
	inline void set_transitionIsCounting_3(bool value)
	{
		___transitionIsCounting_3 = value;
	}

	inline static int32_t get_offset_of_lockedDoorScript_4() { return static_cast<int32_t>(offsetof(lockedTransitionStartManager_t3362297482, ___lockedDoorScript_4)); }
	inline lockedDoorMove_t2161654217 * get_lockedDoorScript_4() const { return ___lockedDoorScript_4; }
	inline lockedDoorMove_t2161654217 ** get_address_of_lockedDoorScript_4() { return &___lockedDoorScript_4; }
	inline void set_lockedDoorScript_4(lockedDoorMove_t2161654217 * value)
	{
		___lockedDoorScript_4 = value;
		Il2CppCodeGenWriteBarrier(&___lockedDoorScript_4, value);
	}

	inline static int32_t get_offset_of_playerTouchedTransition_5() { return static_cast<int32_t>(offsetof(lockedTransitionStartManager_t3362297482, ___playerTouchedTransition_5)); }
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
