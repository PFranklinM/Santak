#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


// DynamicLight2D.verts
struct verts_t2084952560;

#include "mscorlib_System_Array1146569071.h"
#include "AssemblyU2DCSharp_DynamicLight2D_verts2084952560.h"

#pragma once
// DynamicLight2D.verts[]
struct vertsU5BU5D_t2550878289  : public Il2CppArray
{
public:
	ALIGN_FIELD (8) verts_t2084952560 * m_Items[1];

public:
	inline verts_t2084952560 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline verts_t2084952560 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, verts_t2084952560 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
