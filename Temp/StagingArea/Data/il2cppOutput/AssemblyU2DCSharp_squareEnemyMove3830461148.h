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
// UnityEngine.Rigidbody2D
struct Rigidbody2D_t1743771669;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// squareEnemyMove
struct  squareEnemyMove_t3830461148  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject squareEnemyMove::player
	GameObject_t3674682005 * ___player_2;
	// UnityEngine.GameObject squareEnemyMove::key1
	GameObject_t3674682005 * ___key1_3;
	// UnityEngine.Rigidbody2D squareEnemyMove::rb
	Rigidbody2D_t1743771669 * ___rb_4;
	// System.Boolean squareEnemyMove::touchingGround
	bool ___touchingGround_5;
	// System.Single squareEnemyMove::jumpCounter
	float ___jumpCounter_6;
	// System.Int32 squareEnemyMove::health
	int32_t ___health_7;
	// System.Single squareEnemyMove::timerFlash
	float ___timerFlash_8;

public:
	inline static int32_t get_offset_of_player_2() { return static_cast<int32_t>(offsetof(squareEnemyMove_t3830461148, ___player_2)); }
	inline GameObject_t3674682005 * get_player_2() const { return ___player_2; }
	inline GameObject_t3674682005 ** get_address_of_player_2() { return &___player_2; }
	inline void set_player_2(GameObject_t3674682005 * value)
	{
		___player_2 = value;
		Il2CppCodeGenWriteBarrier(&___player_2, value);
	}

	inline static int32_t get_offset_of_key1_3() { return static_cast<int32_t>(offsetof(squareEnemyMove_t3830461148, ___key1_3)); }
	inline GameObject_t3674682005 * get_key1_3() const { return ___key1_3; }
	inline GameObject_t3674682005 ** get_address_of_key1_3() { return &___key1_3; }
	inline void set_key1_3(GameObject_t3674682005 * value)
	{
		___key1_3 = value;
		Il2CppCodeGenWriteBarrier(&___key1_3, value);
	}

	inline static int32_t get_offset_of_rb_4() { return static_cast<int32_t>(offsetof(squareEnemyMove_t3830461148, ___rb_4)); }
	inline Rigidbody2D_t1743771669 * get_rb_4() const { return ___rb_4; }
	inline Rigidbody2D_t1743771669 ** get_address_of_rb_4() { return &___rb_4; }
	inline void set_rb_4(Rigidbody2D_t1743771669 * value)
	{
		___rb_4 = value;
		Il2CppCodeGenWriteBarrier(&___rb_4, value);
	}

	inline static int32_t get_offset_of_touchingGround_5() { return static_cast<int32_t>(offsetof(squareEnemyMove_t3830461148, ___touchingGround_5)); }
	inline bool get_touchingGround_5() const { return ___touchingGround_5; }
	inline bool* get_address_of_touchingGround_5() { return &___touchingGround_5; }
	inline void set_touchingGround_5(bool value)
	{
		___touchingGround_5 = value;
	}

	inline static int32_t get_offset_of_jumpCounter_6() { return static_cast<int32_t>(offsetof(squareEnemyMove_t3830461148, ___jumpCounter_6)); }
	inline float get_jumpCounter_6() const { return ___jumpCounter_6; }
	inline float* get_address_of_jumpCounter_6() { return &___jumpCounter_6; }
	inline void set_jumpCounter_6(float value)
	{
		___jumpCounter_6 = value;
	}

	inline static int32_t get_offset_of_health_7() { return static_cast<int32_t>(offsetof(squareEnemyMove_t3830461148, ___health_7)); }
	inline int32_t get_health_7() const { return ___health_7; }
	inline int32_t* get_address_of_health_7() { return &___health_7; }
	inline void set_health_7(int32_t value)
	{
		___health_7 = value;
	}

	inline static int32_t get_offset_of_timerFlash_8() { return static_cast<int32_t>(offsetof(squareEnemyMove_t3830461148, ___timerFlash_8)); }
	inline float get_timerFlash_8() const { return ___timerFlash_8; }
	inline float* get_address_of_timerFlash_8() { return &___timerFlash_8; }
	inline void set_timerFlash_8(float value)
	{
		___timerFlash_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
