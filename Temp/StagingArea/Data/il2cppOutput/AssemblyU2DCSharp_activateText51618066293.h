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
// mainCharacterTextBoxManager
struct mainCharacterTextBoxManager_t3999869439;
// shadowCharacterTextBoxManager
struct shadowCharacterTextBoxManager_t2636567224;
// activateText4
struct activateText4_t1618066292;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// activateText5
struct  activateText5_t1618066293  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.TextAsset activateText5::theText
	TextAsset_t3836129977 * ___theText_2;
	// System.Int32 activateText5::startLine
	int32_t ___startLine_3;
	// System.Int32 activateText5::endLine
	int32_t ___endLine_4;
	// mainCharacterTextBoxManager activateText5::MCTextBox
	mainCharacterTextBoxManager_t3999869439 * ___MCTextBox_5;
	// shadowCharacterTextBoxManager activateText5::SCTextBox
	shadowCharacterTextBoxManager_t2636567224 * ___SCTextBox_6;
	// System.Boolean activateText5::textHasPlayed
	bool ___textHasPlayed_7;
	// System.Boolean activateText5::otherCharacterTalk
	bool ___otherCharacterTalk_8;
	// activateText4 activateText5::previousText
	activateText4_t1618066292 * ___previousText_9;

public:
	inline static int32_t get_offset_of_theText_2() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___theText_2)); }
	inline TextAsset_t3836129977 * get_theText_2() const { return ___theText_2; }
	inline TextAsset_t3836129977 ** get_address_of_theText_2() { return &___theText_2; }
	inline void set_theText_2(TextAsset_t3836129977 * value)
	{
		___theText_2 = value;
		Il2CppCodeGenWriteBarrier(&___theText_2, value);
	}

	inline static int32_t get_offset_of_startLine_3() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___startLine_3)); }
	inline int32_t get_startLine_3() const { return ___startLine_3; }
	inline int32_t* get_address_of_startLine_3() { return &___startLine_3; }
	inline void set_startLine_3(int32_t value)
	{
		___startLine_3 = value;
	}

	inline static int32_t get_offset_of_endLine_4() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___endLine_4)); }
	inline int32_t get_endLine_4() const { return ___endLine_4; }
	inline int32_t* get_address_of_endLine_4() { return &___endLine_4; }
	inline void set_endLine_4(int32_t value)
	{
		___endLine_4 = value;
	}

	inline static int32_t get_offset_of_MCTextBox_5() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___MCTextBox_5)); }
	inline mainCharacterTextBoxManager_t3999869439 * get_MCTextBox_5() const { return ___MCTextBox_5; }
	inline mainCharacterTextBoxManager_t3999869439 ** get_address_of_MCTextBox_5() { return &___MCTextBox_5; }
	inline void set_MCTextBox_5(mainCharacterTextBoxManager_t3999869439 * value)
	{
		___MCTextBox_5 = value;
		Il2CppCodeGenWriteBarrier(&___MCTextBox_5, value);
	}

	inline static int32_t get_offset_of_SCTextBox_6() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___SCTextBox_6)); }
	inline shadowCharacterTextBoxManager_t2636567224 * get_SCTextBox_6() const { return ___SCTextBox_6; }
	inline shadowCharacterTextBoxManager_t2636567224 ** get_address_of_SCTextBox_6() { return &___SCTextBox_6; }
	inline void set_SCTextBox_6(shadowCharacterTextBoxManager_t2636567224 * value)
	{
		___SCTextBox_6 = value;
		Il2CppCodeGenWriteBarrier(&___SCTextBox_6, value);
	}

	inline static int32_t get_offset_of_textHasPlayed_7() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___textHasPlayed_7)); }
	inline bool get_textHasPlayed_7() const { return ___textHasPlayed_7; }
	inline bool* get_address_of_textHasPlayed_7() { return &___textHasPlayed_7; }
	inline void set_textHasPlayed_7(bool value)
	{
		___textHasPlayed_7 = value;
	}

	inline static int32_t get_offset_of_otherCharacterTalk_8() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___otherCharacterTalk_8)); }
	inline bool get_otherCharacterTalk_8() const { return ___otherCharacterTalk_8; }
	inline bool* get_address_of_otherCharacterTalk_8() { return &___otherCharacterTalk_8; }
	inline void set_otherCharacterTalk_8(bool value)
	{
		___otherCharacterTalk_8 = value;
	}

	inline static int32_t get_offset_of_previousText_9() { return static_cast<int32_t>(offsetof(activateText5_t1618066293, ___previousText_9)); }
	inline activateText4_t1618066292 * get_previousText_9() const { return ___previousText_9; }
	inline activateText4_t1618066292 ** get_address_of_previousText_9() { return &___previousText_9; }
	inline void set_previousText_9(activateText4_t1618066292 * value)
	{
		___previousText_9 = value;
		Il2CppCodeGenWriteBarrier(&___previousText_9, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
