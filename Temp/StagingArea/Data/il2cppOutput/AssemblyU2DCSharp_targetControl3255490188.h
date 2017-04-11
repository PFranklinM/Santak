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
// playerMove
struct playerMove_t2095641170;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"
#include "UnityEngine_UnityEngine_Vector34282066566.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// targetControl
struct  targetControl_t3255490188  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject targetControl::target
	GameObject_t3674682005 * ___target_2;
	// UnityEngine.GameObject targetControl::player
	GameObject_t3674682005 * ___player_3;
	// UnityEngine.GameObject targetControl::bullet
	GameObject_t3674682005 * ___bullet_4;
	// UnityEngine.GameObject targetControl::mine
	GameObject_t3674682005 * ___mine_5;
	// UnityEngine.GameObject targetControl::squareWorld
	GameObject_t3674682005 * ___squareWorld_6;
	// UnityEngine.GameObject targetControl::circleWorld
	GameObject_t3674682005 * ___circleWorld_7;
	// System.Boolean targetControl::squareWorldActive
	bool ___squareWorldActive_8;
	// UnityEngine.Vector3 targetControl::pos
	Vector3_t4282066566  ___pos_9;
	// System.Single targetControl::ROF
	float ___ROF_10;
	// System.Single targetControl::shotDelay
	float ___shotDelay_11;
	// System.Boolean targetControl::AREquipped
	bool ___AREquipped_12;
	// System.Boolean targetControl::SGEquipped
	bool ___SGEquipped_13;
	// System.Boolean targetControl::MLEquipped
	bool ___MLEquipped_14;
	// playerMove targetControl::thePlayer
	playerMove_t2095641170 * ___thePlayer_15;

public:
	inline static int32_t get_offset_of_target_2() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___target_2)); }
	inline GameObject_t3674682005 * get_target_2() const { return ___target_2; }
	inline GameObject_t3674682005 ** get_address_of_target_2() { return &___target_2; }
	inline void set_target_2(GameObject_t3674682005 * value)
	{
		___target_2 = value;
		Il2CppCodeGenWriteBarrier(&___target_2, value);
	}

	inline static int32_t get_offset_of_player_3() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___player_3)); }
	inline GameObject_t3674682005 * get_player_3() const { return ___player_3; }
	inline GameObject_t3674682005 ** get_address_of_player_3() { return &___player_3; }
	inline void set_player_3(GameObject_t3674682005 * value)
	{
		___player_3 = value;
		Il2CppCodeGenWriteBarrier(&___player_3, value);
	}

	inline static int32_t get_offset_of_bullet_4() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___bullet_4)); }
	inline GameObject_t3674682005 * get_bullet_4() const { return ___bullet_4; }
	inline GameObject_t3674682005 ** get_address_of_bullet_4() { return &___bullet_4; }
	inline void set_bullet_4(GameObject_t3674682005 * value)
	{
		___bullet_4 = value;
		Il2CppCodeGenWriteBarrier(&___bullet_4, value);
	}

	inline static int32_t get_offset_of_mine_5() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___mine_5)); }
	inline GameObject_t3674682005 * get_mine_5() const { return ___mine_5; }
	inline GameObject_t3674682005 ** get_address_of_mine_5() { return &___mine_5; }
	inline void set_mine_5(GameObject_t3674682005 * value)
	{
		___mine_5 = value;
		Il2CppCodeGenWriteBarrier(&___mine_5, value);
	}

	inline static int32_t get_offset_of_squareWorld_6() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___squareWorld_6)); }
	inline GameObject_t3674682005 * get_squareWorld_6() const { return ___squareWorld_6; }
	inline GameObject_t3674682005 ** get_address_of_squareWorld_6() { return &___squareWorld_6; }
	inline void set_squareWorld_6(GameObject_t3674682005 * value)
	{
		___squareWorld_6 = value;
		Il2CppCodeGenWriteBarrier(&___squareWorld_6, value);
	}

	inline static int32_t get_offset_of_circleWorld_7() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___circleWorld_7)); }
	inline GameObject_t3674682005 * get_circleWorld_7() const { return ___circleWorld_7; }
	inline GameObject_t3674682005 ** get_address_of_circleWorld_7() { return &___circleWorld_7; }
	inline void set_circleWorld_7(GameObject_t3674682005 * value)
	{
		___circleWorld_7 = value;
		Il2CppCodeGenWriteBarrier(&___circleWorld_7, value);
	}

	inline static int32_t get_offset_of_squareWorldActive_8() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___squareWorldActive_8)); }
	inline bool get_squareWorldActive_8() const { return ___squareWorldActive_8; }
	inline bool* get_address_of_squareWorldActive_8() { return &___squareWorldActive_8; }
	inline void set_squareWorldActive_8(bool value)
	{
		___squareWorldActive_8 = value;
	}

	inline static int32_t get_offset_of_pos_9() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___pos_9)); }
	inline Vector3_t4282066566  get_pos_9() const { return ___pos_9; }
	inline Vector3_t4282066566 * get_address_of_pos_9() { return &___pos_9; }
	inline void set_pos_9(Vector3_t4282066566  value)
	{
		___pos_9 = value;
	}

	inline static int32_t get_offset_of_ROF_10() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___ROF_10)); }
	inline float get_ROF_10() const { return ___ROF_10; }
	inline float* get_address_of_ROF_10() { return &___ROF_10; }
	inline void set_ROF_10(float value)
	{
		___ROF_10 = value;
	}

	inline static int32_t get_offset_of_shotDelay_11() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___shotDelay_11)); }
	inline float get_shotDelay_11() const { return ___shotDelay_11; }
	inline float* get_address_of_shotDelay_11() { return &___shotDelay_11; }
	inline void set_shotDelay_11(float value)
	{
		___shotDelay_11 = value;
	}

	inline static int32_t get_offset_of_AREquipped_12() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___AREquipped_12)); }
	inline bool get_AREquipped_12() const { return ___AREquipped_12; }
	inline bool* get_address_of_AREquipped_12() { return &___AREquipped_12; }
	inline void set_AREquipped_12(bool value)
	{
		___AREquipped_12 = value;
	}

	inline static int32_t get_offset_of_SGEquipped_13() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___SGEquipped_13)); }
	inline bool get_SGEquipped_13() const { return ___SGEquipped_13; }
	inline bool* get_address_of_SGEquipped_13() { return &___SGEquipped_13; }
	inline void set_SGEquipped_13(bool value)
	{
		___SGEquipped_13 = value;
	}

	inline static int32_t get_offset_of_MLEquipped_14() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___MLEquipped_14)); }
	inline bool get_MLEquipped_14() const { return ___MLEquipped_14; }
	inline bool* get_address_of_MLEquipped_14() { return &___MLEquipped_14; }
	inline void set_MLEquipped_14(bool value)
	{
		___MLEquipped_14 = value;
	}

	inline static int32_t get_offset_of_thePlayer_15() { return static_cast<int32_t>(offsetof(targetControl_t3255490188, ___thePlayer_15)); }
	inline playerMove_t2095641170 * get_thePlayer_15() const { return ___thePlayer_15; }
	inline playerMove_t2095641170 ** get_address_of_thePlayer_15() { return &___thePlayer_15; }
	inline void set_thePlayer_15(playerMove_t2095641170 * value)
	{
		___thePlayer_15 = value;
		Il2CppCodeGenWriteBarrier(&___thePlayer_15, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
