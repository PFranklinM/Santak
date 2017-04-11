#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// DynamicLight2D.DynamicLight
struct DynamicLight_t1259058991;
// System.Collections.Generic.List`1<DynamicLight2D.verts>
struct List_1_t3453138112;
// DynamicLight2D.verts
struct verts_t2084952560;

#include "codegen/il2cpp-codegen.h"
#include "AssemblyU2DCSharp_DynamicLight2D_verts2084952560.h"

// System.Void DynamicLight2D.DynamicLight::.ctor()
extern "C"  void DynamicLight__ctor_m268675503 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::Start()
extern "C"  void DynamicLight_Start_m3510780591 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::Update()
extern "C"  void DynamicLight_Update_m1465868094 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::getAllMeshes()
extern "C"  void DynamicLight_getAllMeshes_m1939125691 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::resetBounds()
extern "C"  void DynamicLight_resetBounds_m754005457 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::setLight()
extern "C"  void DynamicLight_setLight_m1398017129 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::renderLightMesh()
extern "C"  void DynamicLight_renderLightMesh_m1372025818 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::sortList(System.Collections.Generic.List`1<DynamicLight2D.verts>)
extern "C"  void DynamicLight_sortList_m3233504094 (DynamicLight_t1259058991 * __this, List_1_t3453138112 * ___lista0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void DynamicLight2D.DynamicLight::drawLinePerVertex()
extern "C"  void DynamicLight_drawLinePerVertex_m1987413846 (DynamicLight_t1259058991 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Single DynamicLight2D.DynamicLight::getVectorAngle(System.Boolean,System.Single,System.Single)
extern "C"  float DynamicLight_getVectorAngle_m2670337828 (DynamicLight_t1259058991 * __this, bool ___pseudo0, float ___x1, float ___y2, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Single DynamicLight2D.DynamicLight::pseudoAngle(System.Single,System.Single)
extern "C"  float DynamicLight_pseudoAngle_m3270774882 (DynamicLight_t1259058991 * __this, float ___dx0, float ___dy1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 DynamicLight2D.DynamicLight::<sortList>m__0(DynamicLight2D.verts,DynamicLight2D.verts)
extern "C"  int32_t DynamicLight_U3CsortListU3Em__0_m3685765878 (Il2CppObject * __this /* static, unused */, verts_t2084952560 * ___item10, verts_t2084952560 * ___item21, const MethodInfo* method) IL2CPP_METHOD_ATTR;
