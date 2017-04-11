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
// UnityEngine.Mesh
struct Mesh_t4241756145;
// UnityEngine.Material
struct Material_t3870600107;
// UnityEngine.Rigidbody2D
struct Rigidbody2D_t1743771669;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// playerMove
struct  playerMove_t2095641170  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject playerMove::player
	GameObject_t3674682005 * ___player_2;
	// UnityEngine.GameObject playerMove::playerModelTriangle
	GameObject_t3674682005 * ___playerModelTriangle_3;
	// UnityEngine.GameObject playerMove::playerModelSquare
	GameObject_t3674682005 * ___playerModelSquare_4;
	// UnityEngine.GameObject playerMove::playerModelCircle
	GameObject_t3674682005 * ___playerModelCircle_5;
	// UnityEngine.Mesh playerMove::playerTriangleMesh
	Mesh_t4241756145 * ___playerTriangleMesh_6;
	// UnityEngine.Mesh playerMove::playerSquareMesh
	Mesh_t4241756145 * ___playerSquareMesh_7;
	// UnityEngine.Mesh playerMove::playerCircleMesh
	Mesh_t4241756145 * ___playerCircleMesh_8;
	// System.Boolean playerMove::finalKey1
	bool ___finalKey1_9;
	// System.Boolean playerMove::finalKey2
	bool ___finalKey2_10;
	// System.Boolean playerMove::finalKey3
	bool ___finalKey3_11;
	// UnityEngine.GameObject playerMove::finalLock1
	GameObject_t3674682005 * ___finalLock1_12;
	// UnityEngine.GameObject playerMove::finalLock2
	GameObject_t3674682005 * ___finalLock2_13;
	// UnityEngine.GameObject playerMove::finalLock3
	GameObject_t3674682005 * ___finalLock3_14;
	// UnityEngine.GameObject playerMove::finalDoorL
	GameObject_t3674682005 * ___finalDoorL_15;
	// UnityEngine.GameObject playerMove::finalDoorR
	GameObject_t3674682005 * ___finalDoorR_16;
	// UnityEngine.Material playerMove::unlockedDoorLight
	Material_t3870600107 * ___unlockedDoorLight_17;
	// UnityEngine.Material playerMove::unlockedDoor
	Material_t3870600107 * ___unlockedDoor_18;
	// UnityEngine.GameObject playerMove::bossBlocker1
	GameObject_t3674682005 * ___bossBlocker1_19;
	// UnityEngine.GameObject playerMove::bossBlocker2
	GameObject_t3674682005 * ___bossBlocker2_20;
	// UnityEngine.GameObject playerMove::bossBlocker3
	GameObject_t3674682005 * ___bossBlocker3_21;
	// UnityEngine.GameObject playerMove::bossBlocker2Z
	GameObject_t3674682005 * ___bossBlocker2Z_22;
	// UnityEngine.GameObject playerMove::bossBlocker1Z
	GameObject_t3674682005 * ___bossBlocker1Z_23;
	// UnityEngine.Rigidbody2D playerMove::rb
	Rigidbody2D_t1743771669 * ___rb_24;
	// System.Int32 playerMove::jumpCounter
	int32_t ___jumpCounter_25;
	// System.Boolean playerMove::playerIsFlying
	bool ___playerIsFlying_26;
	// System.Single playerMove::moveSpeed
	float ___moveSpeed_27;
	// System.Boolean playerMove::screenTransition
	bool ___screenTransition_28;
	// System.Boolean playerMove::facingLeft
	bool ___facingLeft_29;
	// System.Boolean playerMove::facingRight
	bool ___facingRight_30;
	// System.Boolean playerMove::playerInvulnerable
	bool ___playerInvulnerable_31;
	// System.Boolean playerMove::playerjustDied
	bool ___playerjustDied_32;
	// System.Int32 playerMove::health
	int32_t ___health_33;
	// System.Boolean playerMove::healthRecovery
	bool ___healthRecovery_34;
	// System.Boolean playerMove::firstPlaythrough
	bool ___firstPlaythrough_35;
	// System.Boolean playerMove::secondPlaythrough
	bool ___secondPlaythrough_36;
	// System.Boolean playerMove::thirdPlaythrough
	bool ___thirdPlaythrough_37;
	// System.Boolean playerMove::playerHasKey
	bool ___playerHasKey_38;
	// UnityEngine.GameObject playerMove::HP1
	GameObject_t3674682005 * ___HP1_39;
	// UnityEngine.GameObject playerMove::HP2
	GameObject_t3674682005 * ___HP2_40;
	// UnityEngine.GameObject playerMove::HP3
	GameObject_t3674682005 * ___HP3_41;
	// System.Boolean playerMove::canMove
	bool ___canMove_42;
	// System.Boolean playerMove::playerHasFlight
	bool ___playerHasFlight_43;
	// System.Boolean playerMove::playerHasDoubleJump
	bool ___playerHasDoubleJump_44;
	// System.Boolean playerMove::RM1Checkpoint
	bool ___RM1Checkpoint_45;
	// System.Boolean playerMove::RM2CheckpointL
	bool ___RM2CheckpointL_46;
	// System.Boolean playerMove::RM2CheckpointR
	bool ___RM2CheckpointR_47;
	// System.Boolean playerMove::RM3CheckpointL
	bool ___RM3CheckpointL_48;
	// System.Boolean playerMove::RM3CheckpointR
	bool ___RM3CheckpointR_49;
	// System.Boolean playerMove::RM4CheckpointL
	bool ___RM4CheckpointL_50;
	// System.Boolean playerMove::RM4CheckpointR
	bool ___RM4CheckpointR_51;
	// System.Boolean playerMove::RM5CheckpointL
	bool ___RM5CheckpointL_52;
	// System.Boolean playerMove::RM5CheckpointR
	bool ___RM5CheckpointR_53;
	// System.Boolean playerMove::RM6CheckpointL
	bool ___RM6CheckpointL_54;
	// System.Boolean playerMove::RM6CheckpointR
	bool ___RM6CheckpointR_55;
	// System.Boolean playerMove::RM7CheckpointL
	bool ___RM7CheckpointL_56;
	// System.Boolean playerMove::RM7CheckpointR
	bool ___RM7CheckpointR_57;
	// System.Boolean playerMove::RM8CheckpointL
	bool ___RM8CheckpointL_58;
	// System.Boolean playerMove::RM8CheckpointR
	bool ___RM8CheckpointR_59;
	// System.Boolean playerMove::RM9CheckpointL
	bool ___RM9CheckpointL_60;
	// System.Boolean playerMove::RM9CheckpointR
	bool ___RM9CheckpointR_61;
	// System.Boolean playerMove::RM10CheckpointL
	bool ___RM10CheckpointL_62;
	// System.Boolean playerMove::RM10CheckpointR
	bool ___RM10CheckpointR_63;
	// System.Boolean playerMove::RM11CheckpointL
	bool ___RM11CheckpointL_64;
	// System.Boolean playerMove::Boss1CheckpointL
	bool ___Boss1CheckpointL_65;
	// System.Boolean playerMove::Boss1CheckpointR
	bool ___Boss1CheckpointR_66;
	// System.Boolean playerMove::Boss2CheckpointL
	bool ___Boss2CheckpointL_67;
	// System.Boolean playerMove::Boss2CheckpointR
	bool ___Boss2CheckpointR_68;
	// System.Boolean playerMove::Boss3CheckpointL
	bool ___Boss3CheckpointL_69;
	// System.Boolean playerMove::Boss3CheckpointR
	bool ___Boss3CheckpointR_70;

public:
	inline static int32_t get_offset_of_player_2() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___player_2)); }
	inline GameObject_t3674682005 * get_player_2() const { return ___player_2; }
	inline GameObject_t3674682005 ** get_address_of_player_2() { return &___player_2; }
	inline void set_player_2(GameObject_t3674682005 * value)
	{
		___player_2 = value;
		Il2CppCodeGenWriteBarrier(&___player_2, value);
	}

	inline static int32_t get_offset_of_playerModelTriangle_3() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerModelTriangle_3)); }
	inline GameObject_t3674682005 * get_playerModelTriangle_3() const { return ___playerModelTriangle_3; }
	inline GameObject_t3674682005 ** get_address_of_playerModelTriangle_3() { return &___playerModelTriangle_3; }
	inline void set_playerModelTriangle_3(GameObject_t3674682005 * value)
	{
		___playerModelTriangle_3 = value;
		Il2CppCodeGenWriteBarrier(&___playerModelTriangle_3, value);
	}

	inline static int32_t get_offset_of_playerModelSquare_4() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerModelSquare_4)); }
	inline GameObject_t3674682005 * get_playerModelSquare_4() const { return ___playerModelSquare_4; }
	inline GameObject_t3674682005 ** get_address_of_playerModelSquare_4() { return &___playerModelSquare_4; }
	inline void set_playerModelSquare_4(GameObject_t3674682005 * value)
	{
		___playerModelSquare_4 = value;
		Il2CppCodeGenWriteBarrier(&___playerModelSquare_4, value);
	}

	inline static int32_t get_offset_of_playerModelCircle_5() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerModelCircle_5)); }
	inline GameObject_t3674682005 * get_playerModelCircle_5() const { return ___playerModelCircle_5; }
	inline GameObject_t3674682005 ** get_address_of_playerModelCircle_5() { return &___playerModelCircle_5; }
	inline void set_playerModelCircle_5(GameObject_t3674682005 * value)
	{
		___playerModelCircle_5 = value;
		Il2CppCodeGenWriteBarrier(&___playerModelCircle_5, value);
	}

	inline static int32_t get_offset_of_playerTriangleMesh_6() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerTriangleMesh_6)); }
	inline Mesh_t4241756145 * get_playerTriangleMesh_6() const { return ___playerTriangleMesh_6; }
	inline Mesh_t4241756145 ** get_address_of_playerTriangleMesh_6() { return &___playerTriangleMesh_6; }
	inline void set_playerTriangleMesh_6(Mesh_t4241756145 * value)
	{
		___playerTriangleMesh_6 = value;
		Il2CppCodeGenWriteBarrier(&___playerTriangleMesh_6, value);
	}

	inline static int32_t get_offset_of_playerSquareMesh_7() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerSquareMesh_7)); }
	inline Mesh_t4241756145 * get_playerSquareMesh_7() const { return ___playerSquareMesh_7; }
	inline Mesh_t4241756145 ** get_address_of_playerSquareMesh_7() { return &___playerSquareMesh_7; }
	inline void set_playerSquareMesh_7(Mesh_t4241756145 * value)
	{
		___playerSquareMesh_7 = value;
		Il2CppCodeGenWriteBarrier(&___playerSquareMesh_7, value);
	}

	inline static int32_t get_offset_of_playerCircleMesh_8() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerCircleMesh_8)); }
	inline Mesh_t4241756145 * get_playerCircleMesh_8() const { return ___playerCircleMesh_8; }
	inline Mesh_t4241756145 ** get_address_of_playerCircleMesh_8() { return &___playerCircleMesh_8; }
	inline void set_playerCircleMesh_8(Mesh_t4241756145 * value)
	{
		___playerCircleMesh_8 = value;
		Il2CppCodeGenWriteBarrier(&___playerCircleMesh_8, value);
	}

	inline static int32_t get_offset_of_finalKey1_9() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalKey1_9)); }
	inline bool get_finalKey1_9() const { return ___finalKey1_9; }
	inline bool* get_address_of_finalKey1_9() { return &___finalKey1_9; }
	inline void set_finalKey1_9(bool value)
	{
		___finalKey1_9 = value;
	}

	inline static int32_t get_offset_of_finalKey2_10() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalKey2_10)); }
	inline bool get_finalKey2_10() const { return ___finalKey2_10; }
	inline bool* get_address_of_finalKey2_10() { return &___finalKey2_10; }
	inline void set_finalKey2_10(bool value)
	{
		___finalKey2_10 = value;
	}

	inline static int32_t get_offset_of_finalKey3_11() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalKey3_11)); }
	inline bool get_finalKey3_11() const { return ___finalKey3_11; }
	inline bool* get_address_of_finalKey3_11() { return &___finalKey3_11; }
	inline void set_finalKey3_11(bool value)
	{
		___finalKey3_11 = value;
	}

	inline static int32_t get_offset_of_finalLock1_12() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalLock1_12)); }
	inline GameObject_t3674682005 * get_finalLock1_12() const { return ___finalLock1_12; }
	inline GameObject_t3674682005 ** get_address_of_finalLock1_12() { return &___finalLock1_12; }
	inline void set_finalLock1_12(GameObject_t3674682005 * value)
	{
		___finalLock1_12 = value;
		Il2CppCodeGenWriteBarrier(&___finalLock1_12, value);
	}

	inline static int32_t get_offset_of_finalLock2_13() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalLock2_13)); }
	inline GameObject_t3674682005 * get_finalLock2_13() const { return ___finalLock2_13; }
	inline GameObject_t3674682005 ** get_address_of_finalLock2_13() { return &___finalLock2_13; }
	inline void set_finalLock2_13(GameObject_t3674682005 * value)
	{
		___finalLock2_13 = value;
		Il2CppCodeGenWriteBarrier(&___finalLock2_13, value);
	}

	inline static int32_t get_offset_of_finalLock3_14() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalLock3_14)); }
	inline GameObject_t3674682005 * get_finalLock3_14() const { return ___finalLock3_14; }
	inline GameObject_t3674682005 ** get_address_of_finalLock3_14() { return &___finalLock3_14; }
	inline void set_finalLock3_14(GameObject_t3674682005 * value)
	{
		___finalLock3_14 = value;
		Il2CppCodeGenWriteBarrier(&___finalLock3_14, value);
	}

	inline static int32_t get_offset_of_finalDoorL_15() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalDoorL_15)); }
	inline GameObject_t3674682005 * get_finalDoorL_15() const { return ___finalDoorL_15; }
	inline GameObject_t3674682005 ** get_address_of_finalDoorL_15() { return &___finalDoorL_15; }
	inline void set_finalDoorL_15(GameObject_t3674682005 * value)
	{
		___finalDoorL_15 = value;
		Il2CppCodeGenWriteBarrier(&___finalDoorL_15, value);
	}

	inline static int32_t get_offset_of_finalDoorR_16() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___finalDoorR_16)); }
	inline GameObject_t3674682005 * get_finalDoorR_16() const { return ___finalDoorR_16; }
	inline GameObject_t3674682005 ** get_address_of_finalDoorR_16() { return &___finalDoorR_16; }
	inline void set_finalDoorR_16(GameObject_t3674682005 * value)
	{
		___finalDoorR_16 = value;
		Il2CppCodeGenWriteBarrier(&___finalDoorR_16, value);
	}

	inline static int32_t get_offset_of_unlockedDoorLight_17() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___unlockedDoorLight_17)); }
	inline Material_t3870600107 * get_unlockedDoorLight_17() const { return ___unlockedDoorLight_17; }
	inline Material_t3870600107 ** get_address_of_unlockedDoorLight_17() { return &___unlockedDoorLight_17; }
	inline void set_unlockedDoorLight_17(Material_t3870600107 * value)
	{
		___unlockedDoorLight_17 = value;
		Il2CppCodeGenWriteBarrier(&___unlockedDoorLight_17, value);
	}

	inline static int32_t get_offset_of_unlockedDoor_18() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___unlockedDoor_18)); }
	inline Material_t3870600107 * get_unlockedDoor_18() const { return ___unlockedDoor_18; }
	inline Material_t3870600107 ** get_address_of_unlockedDoor_18() { return &___unlockedDoor_18; }
	inline void set_unlockedDoor_18(Material_t3870600107 * value)
	{
		___unlockedDoor_18 = value;
		Il2CppCodeGenWriteBarrier(&___unlockedDoor_18, value);
	}

	inline static int32_t get_offset_of_bossBlocker1_19() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___bossBlocker1_19)); }
	inline GameObject_t3674682005 * get_bossBlocker1_19() const { return ___bossBlocker1_19; }
	inline GameObject_t3674682005 ** get_address_of_bossBlocker1_19() { return &___bossBlocker1_19; }
	inline void set_bossBlocker1_19(GameObject_t3674682005 * value)
	{
		___bossBlocker1_19 = value;
		Il2CppCodeGenWriteBarrier(&___bossBlocker1_19, value);
	}

	inline static int32_t get_offset_of_bossBlocker2_20() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___bossBlocker2_20)); }
	inline GameObject_t3674682005 * get_bossBlocker2_20() const { return ___bossBlocker2_20; }
	inline GameObject_t3674682005 ** get_address_of_bossBlocker2_20() { return &___bossBlocker2_20; }
	inline void set_bossBlocker2_20(GameObject_t3674682005 * value)
	{
		___bossBlocker2_20 = value;
		Il2CppCodeGenWriteBarrier(&___bossBlocker2_20, value);
	}

	inline static int32_t get_offset_of_bossBlocker3_21() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___bossBlocker3_21)); }
	inline GameObject_t3674682005 * get_bossBlocker3_21() const { return ___bossBlocker3_21; }
	inline GameObject_t3674682005 ** get_address_of_bossBlocker3_21() { return &___bossBlocker3_21; }
	inline void set_bossBlocker3_21(GameObject_t3674682005 * value)
	{
		___bossBlocker3_21 = value;
		Il2CppCodeGenWriteBarrier(&___bossBlocker3_21, value);
	}

	inline static int32_t get_offset_of_bossBlocker2Z_22() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___bossBlocker2Z_22)); }
	inline GameObject_t3674682005 * get_bossBlocker2Z_22() const { return ___bossBlocker2Z_22; }
	inline GameObject_t3674682005 ** get_address_of_bossBlocker2Z_22() { return &___bossBlocker2Z_22; }
	inline void set_bossBlocker2Z_22(GameObject_t3674682005 * value)
	{
		___bossBlocker2Z_22 = value;
		Il2CppCodeGenWriteBarrier(&___bossBlocker2Z_22, value);
	}

	inline static int32_t get_offset_of_bossBlocker1Z_23() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___bossBlocker1Z_23)); }
	inline GameObject_t3674682005 * get_bossBlocker1Z_23() const { return ___bossBlocker1Z_23; }
	inline GameObject_t3674682005 ** get_address_of_bossBlocker1Z_23() { return &___bossBlocker1Z_23; }
	inline void set_bossBlocker1Z_23(GameObject_t3674682005 * value)
	{
		___bossBlocker1Z_23 = value;
		Il2CppCodeGenWriteBarrier(&___bossBlocker1Z_23, value);
	}

	inline static int32_t get_offset_of_rb_24() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___rb_24)); }
	inline Rigidbody2D_t1743771669 * get_rb_24() const { return ___rb_24; }
	inline Rigidbody2D_t1743771669 ** get_address_of_rb_24() { return &___rb_24; }
	inline void set_rb_24(Rigidbody2D_t1743771669 * value)
	{
		___rb_24 = value;
		Il2CppCodeGenWriteBarrier(&___rb_24, value);
	}

	inline static int32_t get_offset_of_jumpCounter_25() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___jumpCounter_25)); }
	inline int32_t get_jumpCounter_25() const { return ___jumpCounter_25; }
	inline int32_t* get_address_of_jumpCounter_25() { return &___jumpCounter_25; }
	inline void set_jumpCounter_25(int32_t value)
	{
		___jumpCounter_25 = value;
	}

	inline static int32_t get_offset_of_playerIsFlying_26() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerIsFlying_26)); }
	inline bool get_playerIsFlying_26() const { return ___playerIsFlying_26; }
	inline bool* get_address_of_playerIsFlying_26() { return &___playerIsFlying_26; }
	inline void set_playerIsFlying_26(bool value)
	{
		___playerIsFlying_26 = value;
	}

	inline static int32_t get_offset_of_moveSpeed_27() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___moveSpeed_27)); }
	inline float get_moveSpeed_27() const { return ___moveSpeed_27; }
	inline float* get_address_of_moveSpeed_27() { return &___moveSpeed_27; }
	inline void set_moveSpeed_27(float value)
	{
		___moveSpeed_27 = value;
	}

	inline static int32_t get_offset_of_screenTransition_28() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___screenTransition_28)); }
	inline bool get_screenTransition_28() const { return ___screenTransition_28; }
	inline bool* get_address_of_screenTransition_28() { return &___screenTransition_28; }
	inline void set_screenTransition_28(bool value)
	{
		___screenTransition_28 = value;
	}

	inline static int32_t get_offset_of_facingLeft_29() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___facingLeft_29)); }
	inline bool get_facingLeft_29() const { return ___facingLeft_29; }
	inline bool* get_address_of_facingLeft_29() { return &___facingLeft_29; }
	inline void set_facingLeft_29(bool value)
	{
		___facingLeft_29 = value;
	}

	inline static int32_t get_offset_of_facingRight_30() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___facingRight_30)); }
	inline bool get_facingRight_30() const { return ___facingRight_30; }
	inline bool* get_address_of_facingRight_30() { return &___facingRight_30; }
	inline void set_facingRight_30(bool value)
	{
		___facingRight_30 = value;
	}

	inline static int32_t get_offset_of_playerInvulnerable_31() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerInvulnerable_31)); }
	inline bool get_playerInvulnerable_31() const { return ___playerInvulnerable_31; }
	inline bool* get_address_of_playerInvulnerable_31() { return &___playerInvulnerable_31; }
	inline void set_playerInvulnerable_31(bool value)
	{
		___playerInvulnerable_31 = value;
	}

	inline static int32_t get_offset_of_playerjustDied_32() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerjustDied_32)); }
	inline bool get_playerjustDied_32() const { return ___playerjustDied_32; }
	inline bool* get_address_of_playerjustDied_32() { return &___playerjustDied_32; }
	inline void set_playerjustDied_32(bool value)
	{
		___playerjustDied_32 = value;
	}

	inline static int32_t get_offset_of_health_33() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___health_33)); }
	inline int32_t get_health_33() const { return ___health_33; }
	inline int32_t* get_address_of_health_33() { return &___health_33; }
	inline void set_health_33(int32_t value)
	{
		___health_33 = value;
	}

	inline static int32_t get_offset_of_healthRecovery_34() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___healthRecovery_34)); }
	inline bool get_healthRecovery_34() const { return ___healthRecovery_34; }
	inline bool* get_address_of_healthRecovery_34() { return &___healthRecovery_34; }
	inline void set_healthRecovery_34(bool value)
	{
		___healthRecovery_34 = value;
	}

	inline static int32_t get_offset_of_firstPlaythrough_35() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___firstPlaythrough_35)); }
	inline bool get_firstPlaythrough_35() const { return ___firstPlaythrough_35; }
	inline bool* get_address_of_firstPlaythrough_35() { return &___firstPlaythrough_35; }
	inline void set_firstPlaythrough_35(bool value)
	{
		___firstPlaythrough_35 = value;
	}

	inline static int32_t get_offset_of_secondPlaythrough_36() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___secondPlaythrough_36)); }
	inline bool get_secondPlaythrough_36() const { return ___secondPlaythrough_36; }
	inline bool* get_address_of_secondPlaythrough_36() { return &___secondPlaythrough_36; }
	inline void set_secondPlaythrough_36(bool value)
	{
		___secondPlaythrough_36 = value;
	}

	inline static int32_t get_offset_of_thirdPlaythrough_37() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___thirdPlaythrough_37)); }
	inline bool get_thirdPlaythrough_37() const { return ___thirdPlaythrough_37; }
	inline bool* get_address_of_thirdPlaythrough_37() { return &___thirdPlaythrough_37; }
	inline void set_thirdPlaythrough_37(bool value)
	{
		___thirdPlaythrough_37 = value;
	}

	inline static int32_t get_offset_of_playerHasKey_38() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerHasKey_38)); }
	inline bool get_playerHasKey_38() const { return ___playerHasKey_38; }
	inline bool* get_address_of_playerHasKey_38() { return &___playerHasKey_38; }
	inline void set_playerHasKey_38(bool value)
	{
		___playerHasKey_38 = value;
	}

	inline static int32_t get_offset_of_HP1_39() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___HP1_39)); }
	inline GameObject_t3674682005 * get_HP1_39() const { return ___HP1_39; }
	inline GameObject_t3674682005 ** get_address_of_HP1_39() { return &___HP1_39; }
	inline void set_HP1_39(GameObject_t3674682005 * value)
	{
		___HP1_39 = value;
		Il2CppCodeGenWriteBarrier(&___HP1_39, value);
	}

	inline static int32_t get_offset_of_HP2_40() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___HP2_40)); }
	inline GameObject_t3674682005 * get_HP2_40() const { return ___HP2_40; }
	inline GameObject_t3674682005 ** get_address_of_HP2_40() { return &___HP2_40; }
	inline void set_HP2_40(GameObject_t3674682005 * value)
	{
		___HP2_40 = value;
		Il2CppCodeGenWriteBarrier(&___HP2_40, value);
	}

	inline static int32_t get_offset_of_HP3_41() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___HP3_41)); }
	inline GameObject_t3674682005 * get_HP3_41() const { return ___HP3_41; }
	inline GameObject_t3674682005 ** get_address_of_HP3_41() { return &___HP3_41; }
	inline void set_HP3_41(GameObject_t3674682005 * value)
	{
		___HP3_41 = value;
		Il2CppCodeGenWriteBarrier(&___HP3_41, value);
	}

	inline static int32_t get_offset_of_canMove_42() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___canMove_42)); }
	inline bool get_canMove_42() const { return ___canMove_42; }
	inline bool* get_address_of_canMove_42() { return &___canMove_42; }
	inline void set_canMove_42(bool value)
	{
		___canMove_42 = value;
	}

	inline static int32_t get_offset_of_playerHasFlight_43() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerHasFlight_43)); }
	inline bool get_playerHasFlight_43() const { return ___playerHasFlight_43; }
	inline bool* get_address_of_playerHasFlight_43() { return &___playerHasFlight_43; }
	inline void set_playerHasFlight_43(bool value)
	{
		___playerHasFlight_43 = value;
	}

	inline static int32_t get_offset_of_playerHasDoubleJump_44() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___playerHasDoubleJump_44)); }
	inline bool get_playerHasDoubleJump_44() const { return ___playerHasDoubleJump_44; }
	inline bool* get_address_of_playerHasDoubleJump_44() { return &___playerHasDoubleJump_44; }
	inline void set_playerHasDoubleJump_44(bool value)
	{
		___playerHasDoubleJump_44 = value;
	}

	inline static int32_t get_offset_of_RM1Checkpoint_45() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM1Checkpoint_45)); }
	inline bool get_RM1Checkpoint_45() const { return ___RM1Checkpoint_45; }
	inline bool* get_address_of_RM1Checkpoint_45() { return &___RM1Checkpoint_45; }
	inline void set_RM1Checkpoint_45(bool value)
	{
		___RM1Checkpoint_45 = value;
	}

	inline static int32_t get_offset_of_RM2CheckpointL_46() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM2CheckpointL_46)); }
	inline bool get_RM2CheckpointL_46() const { return ___RM2CheckpointL_46; }
	inline bool* get_address_of_RM2CheckpointL_46() { return &___RM2CheckpointL_46; }
	inline void set_RM2CheckpointL_46(bool value)
	{
		___RM2CheckpointL_46 = value;
	}

	inline static int32_t get_offset_of_RM2CheckpointR_47() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM2CheckpointR_47)); }
	inline bool get_RM2CheckpointR_47() const { return ___RM2CheckpointR_47; }
	inline bool* get_address_of_RM2CheckpointR_47() { return &___RM2CheckpointR_47; }
	inline void set_RM2CheckpointR_47(bool value)
	{
		___RM2CheckpointR_47 = value;
	}

	inline static int32_t get_offset_of_RM3CheckpointL_48() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM3CheckpointL_48)); }
	inline bool get_RM3CheckpointL_48() const { return ___RM3CheckpointL_48; }
	inline bool* get_address_of_RM3CheckpointL_48() { return &___RM3CheckpointL_48; }
	inline void set_RM3CheckpointL_48(bool value)
	{
		___RM3CheckpointL_48 = value;
	}

	inline static int32_t get_offset_of_RM3CheckpointR_49() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM3CheckpointR_49)); }
	inline bool get_RM3CheckpointR_49() const { return ___RM3CheckpointR_49; }
	inline bool* get_address_of_RM3CheckpointR_49() { return &___RM3CheckpointR_49; }
	inline void set_RM3CheckpointR_49(bool value)
	{
		___RM3CheckpointR_49 = value;
	}

	inline static int32_t get_offset_of_RM4CheckpointL_50() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM4CheckpointL_50)); }
	inline bool get_RM4CheckpointL_50() const { return ___RM4CheckpointL_50; }
	inline bool* get_address_of_RM4CheckpointL_50() { return &___RM4CheckpointL_50; }
	inline void set_RM4CheckpointL_50(bool value)
	{
		___RM4CheckpointL_50 = value;
	}

	inline static int32_t get_offset_of_RM4CheckpointR_51() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM4CheckpointR_51)); }
	inline bool get_RM4CheckpointR_51() const { return ___RM4CheckpointR_51; }
	inline bool* get_address_of_RM4CheckpointR_51() { return &___RM4CheckpointR_51; }
	inline void set_RM4CheckpointR_51(bool value)
	{
		___RM4CheckpointR_51 = value;
	}

	inline static int32_t get_offset_of_RM5CheckpointL_52() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM5CheckpointL_52)); }
	inline bool get_RM5CheckpointL_52() const { return ___RM5CheckpointL_52; }
	inline bool* get_address_of_RM5CheckpointL_52() { return &___RM5CheckpointL_52; }
	inline void set_RM5CheckpointL_52(bool value)
	{
		___RM5CheckpointL_52 = value;
	}

	inline static int32_t get_offset_of_RM5CheckpointR_53() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM5CheckpointR_53)); }
	inline bool get_RM5CheckpointR_53() const { return ___RM5CheckpointR_53; }
	inline bool* get_address_of_RM5CheckpointR_53() { return &___RM5CheckpointR_53; }
	inline void set_RM5CheckpointR_53(bool value)
	{
		___RM5CheckpointR_53 = value;
	}

	inline static int32_t get_offset_of_RM6CheckpointL_54() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM6CheckpointL_54)); }
	inline bool get_RM6CheckpointL_54() const { return ___RM6CheckpointL_54; }
	inline bool* get_address_of_RM6CheckpointL_54() { return &___RM6CheckpointL_54; }
	inline void set_RM6CheckpointL_54(bool value)
	{
		___RM6CheckpointL_54 = value;
	}

	inline static int32_t get_offset_of_RM6CheckpointR_55() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM6CheckpointR_55)); }
	inline bool get_RM6CheckpointR_55() const { return ___RM6CheckpointR_55; }
	inline bool* get_address_of_RM6CheckpointR_55() { return &___RM6CheckpointR_55; }
	inline void set_RM6CheckpointR_55(bool value)
	{
		___RM6CheckpointR_55 = value;
	}

	inline static int32_t get_offset_of_RM7CheckpointL_56() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM7CheckpointL_56)); }
	inline bool get_RM7CheckpointL_56() const { return ___RM7CheckpointL_56; }
	inline bool* get_address_of_RM7CheckpointL_56() { return &___RM7CheckpointL_56; }
	inline void set_RM7CheckpointL_56(bool value)
	{
		___RM7CheckpointL_56 = value;
	}

	inline static int32_t get_offset_of_RM7CheckpointR_57() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM7CheckpointR_57)); }
	inline bool get_RM7CheckpointR_57() const { return ___RM7CheckpointR_57; }
	inline bool* get_address_of_RM7CheckpointR_57() { return &___RM7CheckpointR_57; }
	inline void set_RM7CheckpointR_57(bool value)
	{
		___RM7CheckpointR_57 = value;
	}

	inline static int32_t get_offset_of_RM8CheckpointL_58() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM8CheckpointL_58)); }
	inline bool get_RM8CheckpointL_58() const { return ___RM8CheckpointL_58; }
	inline bool* get_address_of_RM8CheckpointL_58() { return &___RM8CheckpointL_58; }
	inline void set_RM8CheckpointL_58(bool value)
	{
		___RM8CheckpointL_58 = value;
	}

	inline static int32_t get_offset_of_RM8CheckpointR_59() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM8CheckpointR_59)); }
	inline bool get_RM8CheckpointR_59() const { return ___RM8CheckpointR_59; }
	inline bool* get_address_of_RM8CheckpointR_59() { return &___RM8CheckpointR_59; }
	inline void set_RM8CheckpointR_59(bool value)
	{
		___RM8CheckpointR_59 = value;
	}

	inline static int32_t get_offset_of_RM9CheckpointL_60() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM9CheckpointL_60)); }
	inline bool get_RM9CheckpointL_60() const { return ___RM9CheckpointL_60; }
	inline bool* get_address_of_RM9CheckpointL_60() { return &___RM9CheckpointL_60; }
	inline void set_RM9CheckpointL_60(bool value)
	{
		___RM9CheckpointL_60 = value;
	}

	inline static int32_t get_offset_of_RM9CheckpointR_61() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM9CheckpointR_61)); }
	inline bool get_RM9CheckpointR_61() const { return ___RM9CheckpointR_61; }
	inline bool* get_address_of_RM9CheckpointR_61() { return &___RM9CheckpointR_61; }
	inline void set_RM9CheckpointR_61(bool value)
	{
		___RM9CheckpointR_61 = value;
	}

	inline static int32_t get_offset_of_RM10CheckpointL_62() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM10CheckpointL_62)); }
	inline bool get_RM10CheckpointL_62() const { return ___RM10CheckpointL_62; }
	inline bool* get_address_of_RM10CheckpointL_62() { return &___RM10CheckpointL_62; }
	inline void set_RM10CheckpointL_62(bool value)
	{
		___RM10CheckpointL_62 = value;
	}

	inline static int32_t get_offset_of_RM10CheckpointR_63() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM10CheckpointR_63)); }
	inline bool get_RM10CheckpointR_63() const { return ___RM10CheckpointR_63; }
	inline bool* get_address_of_RM10CheckpointR_63() { return &___RM10CheckpointR_63; }
	inline void set_RM10CheckpointR_63(bool value)
	{
		___RM10CheckpointR_63 = value;
	}

	inline static int32_t get_offset_of_RM11CheckpointL_64() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___RM11CheckpointL_64)); }
	inline bool get_RM11CheckpointL_64() const { return ___RM11CheckpointL_64; }
	inline bool* get_address_of_RM11CheckpointL_64() { return &___RM11CheckpointL_64; }
	inline void set_RM11CheckpointL_64(bool value)
	{
		___RM11CheckpointL_64 = value;
	}

	inline static int32_t get_offset_of_Boss1CheckpointL_65() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___Boss1CheckpointL_65)); }
	inline bool get_Boss1CheckpointL_65() const { return ___Boss1CheckpointL_65; }
	inline bool* get_address_of_Boss1CheckpointL_65() { return &___Boss1CheckpointL_65; }
	inline void set_Boss1CheckpointL_65(bool value)
	{
		___Boss1CheckpointL_65 = value;
	}

	inline static int32_t get_offset_of_Boss1CheckpointR_66() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___Boss1CheckpointR_66)); }
	inline bool get_Boss1CheckpointR_66() const { return ___Boss1CheckpointR_66; }
	inline bool* get_address_of_Boss1CheckpointR_66() { return &___Boss1CheckpointR_66; }
	inline void set_Boss1CheckpointR_66(bool value)
	{
		___Boss1CheckpointR_66 = value;
	}

	inline static int32_t get_offset_of_Boss2CheckpointL_67() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___Boss2CheckpointL_67)); }
	inline bool get_Boss2CheckpointL_67() const { return ___Boss2CheckpointL_67; }
	inline bool* get_address_of_Boss2CheckpointL_67() { return &___Boss2CheckpointL_67; }
	inline void set_Boss2CheckpointL_67(bool value)
	{
		___Boss2CheckpointL_67 = value;
	}

	inline static int32_t get_offset_of_Boss2CheckpointR_68() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___Boss2CheckpointR_68)); }
	inline bool get_Boss2CheckpointR_68() const { return ___Boss2CheckpointR_68; }
	inline bool* get_address_of_Boss2CheckpointR_68() { return &___Boss2CheckpointR_68; }
	inline void set_Boss2CheckpointR_68(bool value)
	{
		___Boss2CheckpointR_68 = value;
	}

	inline static int32_t get_offset_of_Boss3CheckpointL_69() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___Boss3CheckpointL_69)); }
	inline bool get_Boss3CheckpointL_69() const { return ___Boss3CheckpointL_69; }
	inline bool* get_address_of_Boss3CheckpointL_69() { return &___Boss3CheckpointL_69; }
	inline void set_Boss3CheckpointL_69(bool value)
	{
		___Boss3CheckpointL_69 = value;
	}

	inline static int32_t get_offset_of_Boss3CheckpointR_70() { return static_cast<int32_t>(offsetof(playerMove_t2095641170, ___Boss3CheckpointR_70)); }
	inline bool get_Boss3CheckpointR_70() const { return ___Boss3CheckpointR_70; }
	inline bool* get_address_of_Boss3CheckpointR_70() { return &___Boss3CheckpointR_70; }
	inline void set_Boss3CheckpointR_70(bool value)
	{
		___Boss3CheckpointR_70 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
