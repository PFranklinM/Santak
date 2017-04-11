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

// circleEnemyMove
struct  circleEnemyMove_t4264118409  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject circleEnemyMove::player
	GameObject_t3674682005 * ___player_2;
	// UnityEngine.GameObject circleEnemyMove::key1
	GameObject_t3674682005 * ___key1_3;
	// UnityEngine.Vector3 circleEnemyMove::startPos
	Vector3_t4282066566  ___startPos_4;
	// UnityEngine.Vector3 circleEnemyMove::endPos
	Vector3_t4282066566  ___endPos_5;
	// UnityEngine.Vector3 circleEnemyMove::dir
	Vector3_t4282066566  ___dir_6;
	// System.Int32 circleEnemyMove::health
	int32_t ___health_7;

public:
	inline static int32_t get_offset_of_player_2() { return static_cast<int32_t>(offsetof(circleEnemyMove_t4264118409, ___player_2)); }
	inline GameObject_t3674682005 * get_player_2() const { return ___player_2; }
	inline GameObject_t3674682005 ** get_address_of_player_2() { return &___player_2; }
	inline void set_player_2(GameObject_t3674682005 * value)
	{
		___player_2 = value;
		Il2CppCodeGenWriteBarrier(&___player_2, value);
	}

	inline static int32_t get_offset_of_key1_3() { return static_cast<int32_t>(offsetof(circleEnemyMove_t4264118409, ___key1_3)); }
	inline GameObject_t3674682005 * get_key1_3() const { return ___key1_3; }
	inline GameObject_t3674682005 ** get_address_of_key1_3() { return &___key1_3; }
	inline void set_key1_3(GameObject_t3674682005 * value)
	{
		___key1_3 = value;
		Il2CppCodeGenWriteBarrier(&___key1_3, value);
	}

	inline static int32_t get_offset_of_startPos_4() { return static_cast<int32_t>(offsetof(circleEnemyMove_t4264118409, ___startPos_4)); }
	inline Vector3_t4282066566  get_startPos_4() const { return ___startPos_4; }
	inline Vector3_t4282066566 * get_address_of_startPos_4() { return &___startPos_4; }
	inline void set_startPos_4(Vector3_t4282066566  value)
	{
		___startPos_4 = value;
	}

	inline static int32_t get_offset_of_endPos_5() { return static_cast<int32_t>(offsetof(circleEnemyMove_t4264118409, ___endPos_5)); }
	inline Vector3_t4282066566  get_endPos_5() const { return ___endPos_5; }
	inline Vector3_t4282066566 * get_address_of_endPos_5() { return &___endPos_5; }
	inline void set_endPos_5(Vector3_t4282066566  value)
	{
		___endPos_5 = value;
	}

	inline static int32_t get_offset_of_dir_6() { return static_cast<int32_t>(offsetof(circleEnemyMove_t4264118409, ___dir_6)); }
	inline Vector3_t4282066566  get_dir_6() const { return ___dir_6; }
	inline Vector3_t4282066566 * get_address_of_dir_6() { return &___dir_6; }
	inline void set_dir_6(Vector3_t4282066566  value)
	{
		___dir_6 = value;
	}

	inline static int32_t get_offset_of_health_7() { return static_cast<int32_t>(offsetof(circleEnemyMove_t4264118409, ___health_7)); }
	inline int32_t get_health_7() const { return ___health_7; }
	inline int32_t* get_address_of_health_7() { return &___health_7; }
	inline void set_health_7(int32_t value)
	{
		___health_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
