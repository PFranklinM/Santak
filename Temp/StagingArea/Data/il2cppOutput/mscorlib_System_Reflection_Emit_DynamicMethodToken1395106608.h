#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.Reflection.Emit.DynamicMethod
struct DynamicMethod_t2315379190;

#include "mscorlib_System_Object4170816371.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.Emit.DynamicMethodTokenGenerator
struct  DynamicMethodTokenGenerator_t1395106608  : public Il2CppObject
{
public:
	// System.Reflection.Emit.DynamicMethod System.Reflection.Emit.DynamicMethodTokenGenerator::m
	DynamicMethod_t2315379190 * ___m_0;

public:
	inline static int32_t get_offset_of_m_0() { return static_cast<int32_t>(offsetof(DynamicMethodTokenGenerator_t1395106608, ___m_0)); }
	inline DynamicMethod_t2315379190 * get_m_0() const { return ___m_0; }
	inline DynamicMethod_t2315379190 ** get_address_of_m_0() { return &___m_0; }
	inline void set_m_0(DynamicMethod_t2315379190 * value)
	{
		___m_0 = value;
		Il2CppCodeGenWriteBarrier(&___m_0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
