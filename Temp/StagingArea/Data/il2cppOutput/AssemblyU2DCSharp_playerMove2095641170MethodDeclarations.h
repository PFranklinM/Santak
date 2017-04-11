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

// playerMove
struct playerMove_t2095641170;
// UnityEngine.Collision2D
struct Collision2D_t2859305914;
// UnityEngine.Collider2D
struct Collider2D_t1552025098;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Collision2D2859305914.h"
#include "UnityEngine_UnityEngine_Collider2D1552025098.h"

// System.Void playerMove::.ctor()
extern "C"  void playerMove__ctor_m3495502473 (playerMove_t2095641170 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void playerMove::Start()
extern "C"  void playerMove_Start_m2442640265 (playerMove_t2095641170 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void playerMove::Update()
extern "C"  void playerMove_Update_m2713256356 (playerMove_t2095641170 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void playerMove::FixedUpdate()
extern "C"  void playerMove_FixedUpdate_m582432068 (playerMove_t2095641170 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void playerMove::OnCollisionEnter2D(UnityEngine.Collision2D)
extern "C"  void playerMove_OnCollisionEnter2D_m2833170035 (playerMove_t2095641170 * __this, Collision2D_t2859305914 * ___coll0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void playerMove::OnTriggerEnter2D(UnityEngine.Collider2D)
extern "C"  void playerMove_OnTriggerEnter2D_m3403166223 (playerMove_t2095641170 * __this, Collider2D_t1552025098 * ___coll0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
