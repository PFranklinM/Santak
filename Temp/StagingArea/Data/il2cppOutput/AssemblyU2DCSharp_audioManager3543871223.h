#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AudioSource
struct AudioSource_t1740077639;
// UnityEngine.AudioClip
struct AudioClip_t794140988;
// bouncingEnemySpawner
struct bouncingEnemySpawner_t116257445;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// audioManager
struct  audioManager_t3543871223  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.AudioSource audioManager::theAudio
	AudioSource_t1740077639 * ___theAudio_2;
	// UnityEngine.AudioClip audioManager::track1
	AudioClip_t794140988 * ___track1_3;
	// UnityEngine.AudioClip audioManager::track2
	AudioClip_t794140988 * ___track2_4;
	// System.Single audioManager::audio1Volume
	float ___audio1Volume_5;
	// System.Single audioManager::audio2Volume
	float ___audio2Volume_6;
	// System.Boolean audioManager::track1Playing
	bool ___track1Playing_7;
	// System.Boolean audioManager::track2Playing
	bool ___track2Playing_8;
	// bouncingEnemySpawner audioManager::combatManager
	bouncingEnemySpawner_t116257445 * ___combatManager_9;

public:
	inline static int32_t get_offset_of_theAudio_2() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___theAudio_2)); }
	inline AudioSource_t1740077639 * get_theAudio_2() const { return ___theAudio_2; }
	inline AudioSource_t1740077639 ** get_address_of_theAudio_2() { return &___theAudio_2; }
	inline void set_theAudio_2(AudioSource_t1740077639 * value)
	{
		___theAudio_2 = value;
		Il2CppCodeGenWriteBarrier(&___theAudio_2, value);
	}

	inline static int32_t get_offset_of_track1_3() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___track1_3)); }
	inline AudioClip_t794140988 * get_track1_3() const { return ___track1_3; }
	inline AudioClip_t794140988 ** get_address_of_track1_3() { return &___track1_3; }
	inline void set_track1_3(AudioClip_t794140988 * value)
	{
		___track1_3 = value;
		Il2CppCodeGenWriteBarrier(&___track1_3, value);
	}

	inline static int32_t get_offset_of_track2_4() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___track2_4)); }
	inline AudioClip_t794140988 * get_track2_4() const { return ___track2_4; }
	inline AudioClip_t794140988 ** get_address_of_track2_4() { return &___track2_4; }
	inline void set_track2_4(AudioClip_t794140988 * value)
	{
		___track2_4 = value;
		Il2CppCodeGenWriteBarrier(&___track2_4, value);
	}

	inline static int32_t get_offset_of_audio1Volume_5() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___audio1Volume_5)); }
	inline float get_audio1Volume_5() const { return ___audio1Volume_5; }
	inline float* get_address_of_audio1Volume_5() { return &___audio1Volume_5; }
	inline void set_audio1Volume_5(float value)
	{
		___audio1Volume_5 = value;
	}

	inline static int32_t get_offset_of_audio2Volume_6() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___audio2Volume_6)); }
	inline float get_audio2Volume_6() const { return ___audio2Volume_6; }
	inline float* get_address_of_audio2Volume_6() { return &___audio2Volume_6; }
	inline void set_audio2Volume_6(float value)
	{
		___audio2Volume_6 = value;
	}

	inline static int32_t get_offset_of_track1Playing_7() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___track1Playing_7)); }
	inline bool get_track1Playing_7() const { return ___track1Playing_7; }
	inline bool* get_address_of_track1Playing_7() { return &___track1Playing_7; }
	inline void set_track1Playing_7(bool value)
	{
		___track1Playing_7 = value;
	}

	inline static int32_t get_offset_of_track2Playing_8() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___track2Playing_8)); }
	inline bool get_track2Playing_8() const { return ___track2Playing_8; }
	inline bool* get_address_of_track2Playing_8() { return &___track2Playing_8; }
	inline void set_track2Playing_8(bool value)
	{
		___track2Playing_8 = value;
	}

	inline static int32_t get_offset_of_combatManager_9() { return static_cast<int32_t>(offsetof(audioManager_t3543871223, ___combatManager_9)); }
	inline bouncingEnemySpawner_t116257445 * get_combatManager_9() const { return ___combatManager_9; }
	inline bouncingEnemySpawner_t116257445 ** get_address_of_combatManager_9() { return &___combatManager_9; }
	inline void set_combatManager_9(bouncingEnemySpawner_t116257445 * value)
	{
		___combatManager_9 = value;
		Il2CppCodeGenWriteBarrier(&___combatManager_9, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
