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

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// activateText3A
struct  activateText3A_t2915414830  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.TextAsset activateText3A::theText
	TextAsset_t3836129977 * ___theText_2;
	// System.Int32 activateText3A::startLine
	int32_t ___startLine_3;
	// System.Int32 activateText3A::endLine
	int32_t ___endLine_4;
	// mainCharacterTextBoxManager activateText3A::textBox
	mainCharacterTextBoxManager_t3999869439 * ___textBox_5;
	// System.Boolean activateText3A::textHasPlayed
	bool ___textHasPlayed_6;

public:
	inline static int32_t get_offset_of_theText_2() { return static_cast<int32_t>(offsetof(activateText3A_t2915414830, ___theText_2)); }
	inline TextAsset_t3836129977 * get_theText_2() const { return ___theText_2; }
	inline TextAsset_t3836129977 ** get_address_of_theText_2() { return &___theText_2; }
	inline void set_theText_2(TextAsset_t3836129977 * value)
	{
		___theText_2 = value;
		Il2CppCodeGenWriteBarrier(&___theText_2, value);
	}

	inline static int32_t get_offset_of_startLine_3() { return static_cast<int32_t>(offsetof(activateText3A_t2915414830, ___startLine_3)); }
	inline int32_t get_startLine_3() const { return ___startLine_3; }
	inline int32_t* get_address_of_startLine_3() { return &___startLine_3; }
	inline void set_startLine_3(int32_t value)
	{
		___startLine_3 = value;
	}

	inline static int32_t get_offset_of_endLine_4() { return static_cast<int32_t>(offsetof(activateText3A_t2915414830, ___endLine_4)); }
	inline int32_t get_endLine_4() const { return ___endLine_4; }
	inline int32_t* get_address_of_endLine_4() { return &___endLine_4; }
	inline void set_endLine_4(int32_t value)
	{
		___endLine_4 = value;
	}

	inline static int32_t get_offset_of_textBox_5() { return static_cast<int32_t>(offsetof(activateText3A_t2915414830, ___textBox_5)); }
	inline mainCharacterTextBoxManager_t3999869439 * get_textBox_5() const { return ___textBox_5; }
	inline mainCharacterTextBoxManager_t3999869439 ** get_address_of_textBox_5() { return &___textBox_5; }
	inline void set_textBox_5(mainCharacterTextBoxManager_t3999869439 * value)
	{
		___textBox_5 = value;
		Il2CppCodeGenWriteBarrier(&___textBox_5, value);
	}

	inline static int32_t get_offset_of_textHasPlayed_6() { return static_cast<int32_t>(offsetof(activateText3A_t2915414830, ___textHasPlayed_6)); }
	inline bool get_textHasPlayed_6() const { return ___textHasPlayed_6; }
	inline bool* get_address_of_textHasPlayed_6() { return &___textHasPlayed_6; }
	inline void set_textHasPlayed_6(bool value)
	{
		___textHasPlayed_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
