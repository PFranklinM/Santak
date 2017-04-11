#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.TextAsset
struct TextAsset_t3836129977;
// shadowCharacterTextBoxManager
struct shadowCharacterTextBoxManager_t2636567224;
// UnityEngine.GameObject
struct GameObject_t3674682005;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// activateText2
struct  activateText2_t1618066290  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.TextAsset activateText2::theText
	TextAsset_t3836129977 * ___theText_2;
	// System.Int32 activateText2::startLine
	int32_t ___startLine_3;
	// System.Int32 activateText2::endLine
	int32_t ___endLine_4;
	// shadowCharacterTextBoxManager activateText2::textBox
	shadowCharacterTextBoxManager_t2636567224 * ___textBox_5;
	// UnityEngine.GameObject activateText2::lockedInWall
	GameObject_t3674682005 * ___lockedInWall_6;
	// System.Boolean activateText2::textHasPlayed
	bool ___textHasPlayed_7;
	// System.Boolean activateText2::otherCharacterTalk
	bool ___otherCharacterTalk_8;

public:
	inline static int32_t get_offset_of_theText_2() { return static_cast<int32_t>(offsetof(activateText2_t1618066290, ___theText_2)); }
	inline TextAsset_t3836129977 * get_theText_2() const { return ___theText_2; }
	inline TextAsset_t3836129977 ** get_address_of_theText_2() { return &___theText_2; }
	inline void set_theText_2(TextAsset_t3836129977 * value)
	{
		___theText_2 = value;
		Il2CppCodeGenWriteBarrier(&___theText_2, value);
	}

	inline static int32_t get_offset_of_startLine_3() { return static_cast<int32_t>(offsetof(activateText2_t1618066290, ___startLine_3)); }
	inline int32_t get_startLine_3() const { return ___startLine_3; }
	inline int32_t* get_address_of_startLine_3() { return &___startLine_3; }
	inline void set_startLine_3(int32_t value)
	{
		___startLine_3 = value;
	}

	inline static int32_t get_offset_of_endLine_4() { return static_cast<int32_t>(offsetof(activateText2_t1618066290, ___endLine_4)); }
	inline int32_t get_endLine_4() const { return ___endLine_4; }
	inline int32_t* get_address_of_endLine_4() { return &___endLine_4; }
	inline void set_endLine_4(int32_t value)
	{
		___endLine_4 = value;
	}

	inline static int32_t get_offset_of_textBox_5() { return static_cast<int32_t>(offsetof(activateText2_t1618066290, ___textBox_5)); }
	inline shadowCharacterTextBoxManager_t2636567224 * get_textBox_5() const { return ___textBox_5; }
	inline shadowCharacterTextBoxManager_t2636567224 ** get_address_of_textBox_5() { return &___textBox_5; }
	inline void set_textBox_5(shadowCharacterTextBoxManager_t2636567224 * value)
	{
		___textBox_5 = value;
		Il2CppCodeGenWriteBarrier(&___textBox_5, value);
	}

	inline static int32_t get_offset_of_lockedInWall_6() { return static_cast<int32_t>(offsetof(activateText2_t1618066290, ___lockedInWall_6)); }
	inline GameObject_t3674682005 * get_lockedInWall_6() const { return ___lockedInWall_6; }
	inline GameObject_t3674682005 ** get_address_of_lockedInWall_6() { return &___lockedInWall_6; }
	inline void set_lockedInWall_6(GameObject_t3674682005 * value)
	{
		___lockedInWall_6 = value;
		Il2CppCodeGenWriteBarrier(&___lockedInWall_6, value);
	}

	inline static int32_t get_offset_of_textHasPlayed_7() { return static_cast<int32_t>(offsetof(activateText2_t1618066290, ___textHasPlayed_7)); }
	inline bool get_textHasPlayed_7() const { return ___textHasPlayed_7; }
	inline bool* get_address_of_textHasPlayed_7() { return &___textHasPlayed_7; }
	inline void set_textHasPlayed_7(bool value)
	{
		___textHasPlayed_7 = value;
	}

	inline static int32_t get_offset_of_otherCharacterTalk_8() { return static_cast<int32_t>(offsetof(activateText2_t1618066290, ___otherCharacterTalk_8)); }
	inline bool get_otherCharacterTalk_8() const { return ___otherCharacterTalk_8; }
	inline bool* get_address_of_otherCharacterTalk_8() { return &___otherCharacterTalk_8; }
	inline void set_otherCharacterTalk_8(bool value)
	{
		___otherCharacterTalk_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
