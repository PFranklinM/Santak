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

// bouncingEnemySpawner
struct  bouncingEnemySpawner_t116257445  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject bouncingEnemySpawner::player
	GameObject_t3674682005 * ___player_2;
	// UnityEngine.GameObject bouncingEnemySpawner::jumpingEnemy
	GameObject_t3674682005 * ___jumpingEnemy_3;
	// System.Single bouncingEnemySpawner::spawnTimer
	float ___spawnTimer_4;
	// UnityEngine.Vector3 bouncingEnemySpawner::spawnerPos
	Vector3_t4282066566  ___spawnerPos_5;
	// playerMove bouncingEnemySpawner::thePlayer
	playerMove_t2095641170 * ___thePlayer_6;
	// System.Boolean bouncingEnemySpawner::playerInCombat
	bool ___playerInCombat_7;

public:
	inline static int32_t get_offset_of_player_2() { return static_cast<int32_t>(offsetof(bouncingEnemySpawner_t116257445, ___player_2)); }
	inline GameObject_t3674682005 * get_player_2() const { return ___player_2; }
	inline GameObject_t3674682005 ** get_address_of_player_2() { return &___player_2; }
	inline void set_player_2(GameObject_t3674682005 * value)
	{
		___player_2 = value;
		Il2CppCodeGenWriteBarrier(&___player_2, value);
	}

	inline static int32_t get_offset_of_jumpingEnemy_3() { return static_cast<int32_t>(offsetof(bouncingEnemySpawner_t116257445, ___jumpingEnemy_3)); }
	inline GameObject_t3674682005 * get_jumpingEnemy_3() const { return ___jumpingEnemy_3; }
	inline GameObject_t3674682005 ** get_address_of_jumpingEnemy_3() { return &___jumpingEnemy_3; }
	inline void set_jumpingEnemy_3(GameObject_t3674682005 * value)
	{
		___jumpingEnemy_3 = value;
		Il2CppCodeGenWriteBarrier(&___jumpingEnemy_3, value);
	}

	inline static int32_t get_offset_of_spawnTimer_4() { return static_cast<int32_t>(offsetof(bouncingEnemySpawner_t116257445, ___spawnTimer_4)); }
	inline float get_spawnTimer_4() const { return ___spawnTimer_4; }
	inline float* get_address_of_spawnTimer_4() { return &___spawnTimer_4; }
	inline void set_spawnTimer_4(float value)
	{
		___spawnTimer_4 = value;
	}

	inline static int32_t get_offset_of_spawnerPos_5() { return static_cast<int32_t>(offsetof(bouncingEnemySpawner_t116257445, ___spawnerPos_5)); }
	inline Vector3_t4282066566  get_spawnerPos_5() const { return ___spawnerPos_5; }
	inline Vector3_t4282066566 * get_address_of_spawnerPos_5() { return &___spawnerPos_5; }
	inline void set_spawnerPos_5(Vector3_t4282066566  value)
	{
		___spawnerPos_5 = value;
	}

	inline static int32_t get_offset_of_thePlayer_6() { return static_cast<int32_t>(offsetof(bouncingEnemySpawner_t116257445, ___thePlayer_6)); }
	inline playerMove_t2095641170 * get_thePlayer_6() const { return ___thePlayer_6; }
	inline playerMove_t2095641170 ** get_address_of_thePlayer_6() { return &___thePlayer_6; }
	inline void set_thePlayer_6(playerMove_t2095641170 * value)
	{
		___thePlayer_6 = value;
		Il2CppCodeGenWriteBarrier(&___thePlayer_6, value);
	}

	inline static int32_t get_offset_of_playerInCombat_7() { return static_cast<int32_t>(offsetof(bouncingEnemySpawner_t116257445, ___playerInCombat_7)); }
	inline bool get_playerInCombat_7() const { return ___playerInCombat_7; }
	inline bool* get_address_of_playerInCombat_7() { return &___playerInCombat_7; }
	inline void set_playerInCombat_7(bool value)
	{
		___playerInCombat_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
