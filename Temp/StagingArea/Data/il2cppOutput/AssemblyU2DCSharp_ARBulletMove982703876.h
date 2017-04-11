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

// ARBulletMove
struct  ARBulletMove_t982703876  : public MonoBehaviour_t667441552
{
public:
	// System.Single ARBulletMove::moveSpeed
	float ___moveSpeed_2;
	// UnityEngine.GameObject ARBulletMove::target
	GameObject_t3674682005 * ___target_3;
	// UnityEngine.GameObject ARBulletMove::Bullet
	GameObject_t3674682005 * ___Bullet_4;
	// UnityEngine.GameObject ARBulletMove::player
	GameObject_t3674682005 * ___player_5;
	// UnityEngine.Vector3 ARBulletMove::targetPos
	Vector3_t4282066566  ___targetPos_6;

public:
	inline static int32_t get_offset_of_moveSpeed_2() { return static_cast<int32_t>(offsetof(ARBulletMove_t982703876, ___moveSpeed_2)); }
	inline float get_moveSpeed_2() const { return ___moveSpeed_2; }
	inline float* get_address_of_moveSpeed_2() { return &___moveSpeed_2; }
	inline void set_moveSpeed_2(float value)
	{
		___moveSpeed_2 = value;
	}

	inline static int32_t get_offset_of_target_3() { return static_cast<int32_t>(offsetof(ARBulletMove_t982703876, ___target_3)); }
	inline GameObject_t3674682005 * get_target_3() const { return ___target_3; }
	inline GameObject_t3674682005 ** get_address_of_target_3() { return &___target_3; }
	inline void set_target_3(GameObject_t3674682005 * value)
	{
		___target_3 = value;
		Il2CppCodeGenWriteBarrier(&___target_3, value);
	}

	inline static int32_t get_offset_of_Bullet_4() { return static_cast<int32_t>(offsetof(ARBulletMove_t982703876, ___Bullet_4)); }
	inline GameObject_t3674682005 * get_Bullet_4() const { return ___Bullet_4; }
	inline GameObject_t3674682005 ** get_address_of_Bullet_4() { return &___Bullet_4; }
	inline void set_Bullet_4(GameObject_t3674682005 * value)
	{
		___Bullet_4 = value;
		Il2CppCodeGenWriteBarrier(&___Bullet_4, value);
	}

	inline static int32_t get_offset_of_player_5() { return static_cast<int32_t>(offsetof(ARBulletMove_t982703876, ___player_5)); }
	inline GameObject_t3674682005 * get_player_5() const { return ___player_5; }
	inline GameObject_t3674682005 ** get_address_of_player_5() { return &___player_5; }
	inline void set_player_5(GameObject_t3674682005 * value)
	{
		___player_5 = value;
		Il2CppCodeGenWriteBarrier(&___player_5, value);
	}

	inline static int32_t get_offset_of_targetPos_6() { return static_cast<int32_t>(offsetof(ARBulletMove_t982703876, ___targetPos_6)); }
	inline Vector3_t4282066566  get_targetPos_6() const { return ___targetPos_6; }
	inline Vector3_t4282066566 * get_address_of_targetPos_6() { return &___targetPos_6; }
	inline void set_targetPos_6(Vector3_t4282066566  value)
	{
		___targetPos_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
