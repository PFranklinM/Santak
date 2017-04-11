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

// enemySpawnerRM5S
struct  enemySpawnerRM5S_t4088060665  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject enemySpawnerRM5S::squareEnemy
	GameObject_t3674682005 * ___squareEnemy_2;
	// System.Int32 enemySpawnerRM5S::spawnCounter
	int32_t ___spawnCounter_3;

public:
	inline static int32_t get_offset_of_squareEnemy_2() { return static_cast<int32_t>(offsetof(enemySpawnerRM5S_t4088060665, ___squareEnemy_2)); }
	inline GameObject_t3674682005 * get_squareEnemy_2() const { return ___squareEnemy_2; }
	inline GameObject_t3674682005 ** get_address_of_squareEnemy_2() { return &___squareEnemy_2; }
	inline void set_squareEnemy_2(GameObject_t3674682005 * value)
	{
		___squareEnemy_2 = value;
		Il2CppCodeGenWriteBarrier(&___squareEnemy_2, value);
	}

	inline static int32_t get_offset_of_spawnCounter_3() { return static_cast<int32_t>(offsetof(enemySpawnerRM5S_t4088060665, ___spawnCounter_3)); }
	inline int32_t get_spawnCounter_3() const { return ___spawnCounter_3; }
	inline int32_t* get_address_of_spawnCounter_3() { return &___spawnCounter_3; }
	inline void set_spawnCounter_3(int32_t value)
	{
		___spawnCounter_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
