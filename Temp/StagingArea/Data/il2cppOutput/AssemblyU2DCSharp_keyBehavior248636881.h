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

// keyBehavior
struct  keyBehavior_t248636881  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.Vector3 keyBehavior::originalPos
	Vector3_t4282066566  ___originalPos_2;
	// UnityEngine.GameObject keyBehavior::player
	GameObject_t3674682005 * ___player_3;

public:
	inline static int32_t get_offset_of_originalPos_2() { return static_cast<int32_t>(offsetof(keyBehavior_t248636881, ___originalPos_2)); }
	inline Vector3_t4282066566  get_originalPos_2() const { return ___originalPos_2; }
	inline Vector3_t4282066566 * get_address_of_originalPos_2() { return &___originalPos_2; }
	inline void set_originalPos_2(Vector3_t4282066566  value)
	{
		___originalPos_2 = value;
	}

	inline static int32_t get_offset_of_player_3() { return static_cast<int32_t>(offsetof(keyBehavior_t248636881, ___player_3)); }
	inline GameObject_t3674682005 * get_player_3() const { return ___player_3; }
	inline GameObject_t3674682005 ** get_address_of_player_3() { return &___player_3; }
	inline void set_player_3(GameObject_t3674682005 * value)
	{
		___player_3 = value;
		Il2CppCodeGenWriteBarrier(&___player_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
