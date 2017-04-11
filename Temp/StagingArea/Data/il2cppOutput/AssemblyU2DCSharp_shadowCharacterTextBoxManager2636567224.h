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
// UnityEngine.UI.Text
struct Text_t9039225;
// UnityEngine.TextAsset
struct TextAsset_t3836129977;
// System.String[]
struct StringU5BU5D_t4054002952;
// playerMove
struct playerMove_t2095641170;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// shadowCharacterTextBoxManager
struct  shadowCharacterTextBoxManager_t2636567224  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject shadowCharacterTextBoxManager::textBox
	GameObject_t3674682005 * ___textBox_2;
	// UnityEngine.UI.Text shadowCharacterTextBoxManager::theText
	Text_t9039225 * ___theText_3;
	// UnityEngine.TextAsset shadowCharacterTextBoxManager::textFile
	TextAsset_t3836129977 * ___textFile_4;
	// System.String[] shadowCharacterTextBoxManager::textLines
	StringU5BU5D_t4054002952* ___textLines_5;
	// System.Int32 shadowCharacterTextBoxManager::currentLine
	int32_t ___currentLine_6;
	// System.Int32 shadowCharacterTextBoxManager::endAtLine
	int32_t ___endAtLine_7;
	// playerMove shadowCharacterTextBoxManager::thePlayer
	playerMove_t2095641170 * ___thePlayer_8;
	// System.Boolean shadowCharacterTextBoxManager::isActive
	bool ___isActive_9;

public:
	inline static int32_t get_offset_of_textBox_2() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___textBox_2)); }
	inline GameObject_t3674682005 * get_textBox_2() const { return ___textBox_2; }
	inline GameObject_t3674682005 ** get_address_of_textBox_2() { return &___textBox_2; }
	inline void set_textBox_2(GameObject_t3674682005 * value)
	{
		___textBox_2 = value;
		Il2CppCodeGenWriteBarrier(&___textBox_2, value);
	}

	inline static int32_t get_offset_of_theText_3() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___theText_3)); }
	inline Text_t9039225 * get_theText_3() const { return ___theText_3; }
	inline Text_t9039225 ** get_address_of_theText_3() { return &___theText_3; }
	inline void set_theText_3(Text_t9039225 * value)
	{
		___theText_3 = value;
		Il2CppCodeGenWriteBarrier(&___theText_3, value);
	}

	inline static int32_t get_offset_of_textFile_4() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___textFile_4)); }
	inline TextAsset_t3836129977 * get_textFile_4() const { return ___textFile_4; }
	inline TextAsset_t3836129977 ** get_address_of_textFile_4() { return &___textFile_4; }
	inline void set_textFile_4(TextAsset_t3836129977 * value)
	{
		___textFile_4 = value;
		Il2CppCodeGenWriteBarrier(&___textFile_4, value);
	}

	inline static int32_t get_offset_of_textLines_5() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___textLines_5)); }
	inline StringU5BU5D_t4054002952* get_textLines_5() const { return ___textLines_5; }
	inline StringU5BU5D_t4054002952** get_address_of_textLines_5() { return &___textLines_5; }
	inline void set_textLines_5(StringU5BU5D_t4054002952* value)
	{
		___textLines_5 = value;
		Il2CppCodeGenWriteBarrier(&___textLines_5, value);
	}

	inline static int32_t get_offset_of_currentLine_6() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___currentLine_6)); }
	inline int32_t get_currentLine_6() const { return ___currentLine_6; }
	inline int32_t* get_address_of_currentLine_6() { return &___currentLine_6; }
	inline void set_currentLine_6(int32_t value)
	{
		___currentLine_6 = value;
	}

	inline static int32_t get_offset_of_endAtLine_7() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___endAtLine_7)); }
	inline int32_t get_endAtLine_7() const { return ___endAtLine_7; }
	inline int32_t* get_address_of_endAtLine_7() { return &___endAtLine_7; }
	inline void set_endAtLine_7(int32_t value)
	{
		___endAtLine_7 = value;
	}

	inline static int32_t get_offset_of_thePlayer_8() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___thePlayer_8)); }
	inline playerMove_t2095641170 * get_thePlayer_8() const { return ___thePlayer_8; }
	inline playerMove_t2095641170 ** get_address_of_thePlayer_8() { return &___thePlayer_8; }
	inline void set_thePlayer_8(playerMove_t2095641170 * value)
	{
		___thePlayer_8 = value;
		Il2CppCodeGenWriteBarrier(&___thePlayer_8, value);
	}

	inline static int32_t get_offset_of_isActive_9() { return static_cast<int32_t>(offsetof(shadowCharacterTextBoxManager_t2636567224, ___isActive_9)); }
	inline bool get_isActive_9() const { return ___isActive_9; }
	inline bool* get_address_of_isActive_9() { return &___isActive_9; }
	inline void set_isActive_9(bool value)
	{
		___isActive_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
