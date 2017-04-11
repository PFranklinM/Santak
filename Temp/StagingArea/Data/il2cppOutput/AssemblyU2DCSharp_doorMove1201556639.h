#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"
#include "UnityEngine_UnityEngine_Vector34282066566.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// doorMove
struct  doorMove_t1201556639  : public MonoBehaviour_t667441552
{
public:
	// System.Boolean doorMove::doorIsHittable
	bool ___doorIsHittable_2;
	// UnityEngine.Vector3 doorMove::originalPos
	Vector3_t4282066566  ___originalPos_3;

public:
	inline static int32_t get_offset_of_doorIsHittable_2() { return static_cast<int32_t>(offsetof(doorMove_t1201556639, ___doorIsHittable_2)); }
	inline bool get_doorIsHittable_2() const { return ___doorIsHittable_2; }
	inline bool* get_address_of_doorIsHittable_2() { return &___doorIsHittable_2; }
	inline void set_doorIsHittable_2(bool value)
	{
		___doorIsHittable_2 = value;
	}

	inline static int32_t get_offset_of_originalPos_3() { return static_cast<int32_t>(offsetof(doorMove_t1201556639, ___originalPos_3)); }
	inline Vector3_t4282066566  get_originalPos_3() const { return ___originalPos_3; }
	inline Vector3_t4282066566 * get_address_of_originalPos_3() { return &___originalPos_3; }
	inline void set_originalPos_3(Vector3_t4282066566  value)
	{
		___originalPos_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
