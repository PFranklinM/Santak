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

// mineMove
struct  mineMove_t2931258052  : public MonoBehaviour_t667441552
{
public:
	// System.Single mineMove::moveSpeed
	float ___moveSpeed_2;
	// UnityEngine.GameObject mineMove::target
	GameObject_t3674682005 * ___target_3;
	// UnityEngine.GameObject mineMove::mine
	GameObject_t3674682005 * ___mine_4;
	// UnityEngine.GameObject mineMove::player
	GameObject_t3674682005 * ___player_5;
	// UnityEngine.GameObject mineMove::explosionEffect
	GameObject_t3674682005 * ___explosionEffect_6;
	// System.Single mineMove::targetDistance
	float ___targetDistance_7;
	// System.Single mineMove::playerExplosionDistance
	float ___playerExplosionDistance_8;
	// System.Single mineMove::playerPropulsionSpeed
	float ___playerPropulsionSpeed_9;

public:
	inline static int32_t get_offset_of_moveSpeed_2() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___moveSpeed_2)); }
	inline float get_moveSpeed_2() const { return ___moveSpeed_2; }
	inline float* get_address_of_moveSpeed_2() { return &___moveSpeed_2; }
	inline void set_moveSpeed_2(float value)
	{
		___moveSpeed_2 = value;
	}

	inline static int32_t get_offset_of_target_3() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___target_3)); }
	inline GameObject_t3674682005 * get_target_3() const { return ___target_3; }
	inline GameObject_t3674682005 ** get_address_of_target_3() { return &___target_3; }
	inline void set_target_3(GameObject_t3674682005 * value)
	{
		___target_3 = value;
		Il2CppCodeGenWriteBarrier(&___target_3, value);
	}

	inline static int32_t get_offset_of_mine_4() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___mine_4)); }
	inline GameObject_t3674682005 * get_mine_4() const { return ___mine_4; }
	inline GameObject_t3674682005 ** get_address_of_mine_4() { return &___mine_4; }
	inline void set_mine_4(GameObject_t3674682005 * value)
	{
		___mine_4 = value;
		Il2CppCodeGenWriteBarrier(&___mine_4, value);
	}

	inline static int32_t get_offset_of_player_5() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___player_5)); }
	inline GameObject_t3674682005 * get_player_5() const { return ___player_5; }
	inline GameObject_t3674682005 ** get_address_of_player_5() { return &___player_5; }
	inline void set_player_5(GameObject_t3674682005 * value)
	{
		___player_5 = value;
		Il2CppCodeGenWriteBarrier(&___player_5, value);
	}

	inline static int32_t get_offset_of_explosionEffect_6() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___explosionEffect_6)); }
	inline GameObject_t3674682005 * get_explosionEffect_6() const { return ___explosionEffect_6; }
	inline GameObject_t3674682005 ** get_address_of_explosionEffect_6() { return &___explosionEffect_6; }
	inline void set_explosionEffect_6(GameObject_t3674682005 * value)
	{
		___explosionEffect_6 = value;
		Il2CppCodeGenWriteBarrier(&___explosionEffect_6, value);
	}

	inline static int32_t get_offset_of_targetDistance_7() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___targetDistance_7)); }
	inline float get_targetDistance_7() const { return ___targetDistance_7; }
	inline float* get_address_of_targetDistance_7() { return &___targetDistance_7; }
	inline void set_targetDistance_7(float value)
	{
		___targetDistance_7 = value;
	}

	inline static int32_t get_offset_of_playerExplosionDistance_8() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___playerExplosionDistance_8)); }
	inline float get_playerExplosionDistance_8() const { return ___playerExplosionDistance_8; }
	inline float* get_address_of_playerExplosionDistance_8() { return &___playerExplosionDistance_8; }
	inline void set_playerExplosionDistance_8(float value)
	{
		___playerExplosionDistance_8 = value;
	}

	inline static int32_t get_offset_of_playerPropulsionSpeed_9() { return static_cast<int32_t>(offsetof(mineMove_t2931258052, ___playerPropulsionSpeed_9)); }
	inline float get_playerPropulsionSpeed_9() const { return ___playerPropulsionSpeed_9; }
	inline float* get_address_of_playerPropulsionSpeed_9() { return &___playerPropulsionSpeed_9; }
	inline void set_playerPropulsionSpeed_9(float value)
	{
		___playerPropulsionSpeed_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
