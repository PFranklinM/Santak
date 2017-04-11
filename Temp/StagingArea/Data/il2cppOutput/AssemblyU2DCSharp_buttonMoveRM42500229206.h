#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t3674682005;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"
#include "UnityEngine_UnityEngine_Vector34282066566.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// buttonMoveRM4
struct  buttonMoveRM4_t2500229206  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.Vector3 buttonMoveRM4::originalPos
	Vector3_t4282066566  ___originalPos_2;
	// System.Single buttonMoveRM4::buttonDownTimer
	float ___buttonDownTimer_3;
	// System.Single buttonMoveRM4::buttonUpTimer
	float ___buttonUpTimer_4;
	// System.Boolean buttonMoveRM4::somethingOnButton
	bool ___somethingOnButton_5;
	// System.Boolean buttonMoveRM4::buttonActive
	bool ___buttonActive_6;
	// System.Boolean buttonMoveRM4::boxOnButton
	bool ___boxOnButton_7;
	// UnityEngine.GameObject buttonMoveRM4::barrier1
	GameObject_t3674682005 * ___barrier1_8;

public:
	inline static int32_t get_offset_of_originalPos_2() { return static_cast<int32_t>(offsetof(buttonMoveRM4_t2500229206, ___originalPos_2)); }
	inline Vector3_t4282066566  get_originalPos_2() const { return ___originalPos_2; }
	inline Vector3_t4282066566 * get_address_of_originalPos_2() { return &___originalPos_2; }
	inline void set_originalPos_2(Vector3_t4282066566  value)
	{
		___originalPos_2 = value;
	}

	inline static int32_t get_offset_of_buttonDownTimer_3() { return static_cast<int32_t>(offsetof(buttonMoveRM4_t2500229206, ___buttonDownTimer_3)); }
	inline float get_buttonDownTimer_3() const { return ___buttonDownTimer_3; }
	inline float* get_address_of_buttonDownTimer_3() { return &___buttonDownTimer_3; }
	inline void set_buttonDownTimer_3(float value)
	{
		___buttonDownTimer_3 = value;
	}

	inline static int32_t get_offset_of_buttonUpTimer_4() { return static_cast<int32_t>(offsetof(buttonMoveRM4_t2500229206, ___buttonUpTimer_4)); }
	inline float get_buttonUpTimer_4() const { return ___buttonUpTimer_4; }
	inline float* get_address_of_buttonUpTimer_4() { return &___buttonUpTimer_4; }
	inline void set_buttonUpTimer_4(float value)
	{
		___buttonUpTimer_4 = value;
	}

	inline static int32_t get_offset_of_somethingOnButton_5() { return static_cast<int32_t>(offsetof(buttonMoveRM4_t2500229206, ___somethingOnButton_5)); }
	inline bool get_somethingOnButton_5() const { return ___somethingOnButton_5; }
	inline bool* get_address_of_somethingOnButton_5() { return &___somethingOnButton_5; }
	inline void set_somethingOnButton_5(bool value)
	{
		___somethingOnButton_5 = value;
	}

	inline static int32_t get_offset_of_buttonActive_6() { return static_cast<int32_t>(offsetof(buttonMoveRM4_t2500229206, ___buttonActive_6)); }
	inline bool get_buttonActive_6() const { return ___buttonActive_6; }
	inline bool* get_address_of_buttonActive_6() { return &___buttonActive_6; }
	inline void set_buttonActive_6(bool value)
	{
		___buttonActive_6 = value;
	}

	inline static int32_t get_offset_of_boxOnButton_7() { return static_cast<int32_t>(offsetof(buttonMoveRM4_t2500229206, ___boxOnButton_7)); }
	inline bool get_boxOnButton_7() const { return ___boxOnButton_7; }
	inline bool* get_address_of_boxOnButton_7() { return &___boxOnButton_7; }
	inline void set_boxOnButton_7(bool value)
	{
		___boxOnButton_7 = value;
	}

	inline static int32_t get_offset_of_barrier1_8() { return static_cast<int32_t>(offsetof(buttonMoveRM4_t2500229206, ___barrier1_8)); }
	inline GameObject_t3674682005 * get_barrier1_8() const { return ___barrier1_8; }
	inline GameObject_t3674682005 ** get_address_of_barrier1_8() { return &___barrier1_8; }
	inline void set_barrier1_8(GameObject_t3674682005 * value)
	{
		___barrier1_8 = value;
		Il2CppCodeGenWriteBarrier(&___barrier1_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
