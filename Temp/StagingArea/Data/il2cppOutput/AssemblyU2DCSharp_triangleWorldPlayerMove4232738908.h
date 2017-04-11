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

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// triangleWorldPlayerMove
struct  triangleWorldPlayerMove_t4232738908  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject triangleWorldPlayerMove::player
	GameObject_t3674682005 * ___player_2;
	// System.Single triangleWorldPlayerMove::moveSpeed
	float ___moveSpeed_3;
	// System.Int32 triangleWorldPlayerMove::health
	int32_t ___health_4;
	// UnityEngine.GameObject triangleWorldPlayerMove::HP1
	GameObject_t3674682005 * ___HP1_5;
	// UnityEngine.GameObject triangleWorldPlayerMove::HP2
	GameObject_t3674682005 * ___HP2_6;
	// UnityEngine.GameObject triangleWorldPlayerMove::HP3
	GameObject_t3674682005 * ___HP3_7;

public:
	inline static int32_t get_offset_of_player_2() { return static_cast<int32_t>(offsetof(triangleWorldPlayerMove_t4232738908, ___player_2)); }
	inline GameObject_t3674682005 * get_player_2() const { return ___player_2; }
	inline GameObject_t3674682005 ** get_address_of_player_2() { return &___player_2; }
	inline void set_player_2(GameObject_t3674682005 * value)
	{
		___player_2 = value;
		Il2CppCodeGenWriteBarrier(&___player_2, value);
	}

	inline static int32_t get_offset_of_moveSpeed_3() { return static_cast<int32_t>(offsetof(triangleWorldPlayerMove_t4232738908, ___moveSpeed_3)); }
	inline float get_moveSpeed_3() const { return ___moveSpeed_3; }
	inline float* get_address_of_moveSpeed_3() { return &___moveSpeed_3; }
	inline void set_moveSpeed_3(float value)
	{
		___moveSpeed_3 = value;
	}

	inline static int32_t get_offset_of_health_4() { return static_cast<int32_t>(offsetof(triangleWorldPlayerMove_t4232738908, ___health_4)); }
	inline int32_t get_health_4() const { return ___health_4; }
	inline int32_t* get_address_of_health_4() { return &___health_4; }
	inline void set_health_4(int32_t value)
	{
		___health_4 = value;
	}

	inline static int32_t get_offset_of_HP1_5() { return static_cast<int32_t>(offsetof(triangleWorldPlayerMove_t4232738908, ___HP1_5)); }
	inline GameObject_t3674682005 * get_HP1_5() const { return ___HP1_5; }
	inline GameObject_t3674682005 ** get_address_of_HP1_5() { return &___HP1_5; }
	inline void set_HP1_5(GameObject_t3674682005 * value)
	{
		___HP1_5 = value;
		Il2CppCodeGenWriteBarrier(&___HP1_5, value);
	}

	inline static int32_t get_offset_of_HP2_6() { return static_cast<int32_t>(offsetof(triangleWorldPlayerMove_t4232738908, ___HP2_6)); }
	inline GameObject_t3674682005 * get_HP2_6() const { return ___HP2_6; }
	inline GameObject_t3674682005 ** get_address_of_HP2_6() { return &___HP2_6; }
	inline void set_HP2_6(GameObject_t3674682005 * value)
	{
		___HP2_6 = value;
		Il2CppCodeGenWriteBarrier(&___HP2_6, value);
	}

	inline static int32_t get_offset_of_HP3_7() { return static_cast<int32_t>(offsetof(triangleWorldPlayerMove_t4232738908, ___HP3_7)); }
	inline GameObject_t3674682005 * get_HP3_7() const { return ___HP3_7; }
	inline GameObject_t3674682005 ** get_address_of_HP3_7() { return &___HP3_7; }
	inline void set_HP3_7(GameObject_t3674682005 * value)
	{
		___HP3_7 = value;
		Il2CppCodeGenWriteBarrier(&___HP3_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
