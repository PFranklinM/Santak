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

// enemySpawnerBoss1
struct  enemySpawnerBoss1_t2162126212  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject enemySpawnerBoss1::Boss1
	GameObject_t3674682005 * ___Boss1_2;
	// System.Int32 enemySpawnerBoss1::spawnCounter
	int32_t ___spawnCounter_3;

public:
	inline static int32_t get_offset_of_Boss1_2() { return static_cast<int32_t>(offsetof(enemySpawnerBoss1_t2162126212, ___Boss1_2)); }
	inline GameObject_t3674682005 * get_Boss1_2() const { return ___Boss1_2; }
	inline GameObject_t3674682005 ** get_address_of_Boss1_2() { return &___Boss1_2; }
	inline void set_Boss1_2(GameObject_t3674682005 * value)
	{
		___Boss1_2 = value;
		Il2CppCodeGenWriteBarrier(&___Boss1_2, value);
	}

	inline static int32_t get_offset_of_spawnCounter_3() { return static_cast<int32_t>(offsetof(enemySpawnerBoss1_t2162126212, ___spawnCounter_3)); }
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
