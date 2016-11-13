#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2244299850;

#include "t3012272455.h"
#include "t3525329788.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3412528602  : public t3012272455
{
public:
	t2244299850 * f2;
	t3525329788  f3;
	t3525329788  f4;
	t3525329788  f5;
	t3525329788  f6;
	float f7;
	float f8;
	float f9;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3412528602, f2)); }
	inline t2244299850 * fg2() const { return f2; }
	inline t2244299850 ** fag2() { return &f2; }
	inline void fs2(t2244299850 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3412528602, f3)); }
	inline t3525329788  fg3() const { return f3; }
	inline t3525329788 * fag3() { return &f3; }
	inline void fs3(t3525329788  value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t3412528602, f4)); }
	inline t3525329788  fg4() const { return f4; }
	inline t3525329788 * fag4() { return &f4; }
	inline void fs4(t3525329788  value)
	{
		f4 = value;
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t3412528602, f5)); }
	inline t3525329788  fg5() const { return f5; }
	inline t3525329788 * fag5() { return &f5; }
	inline void fs5(t3525329788  value)
	{
		f5 = value;
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t3412528602, f6)); }
	inline t3525329788  fg6() const { return f6; }
	inline t3525329788 * fag6() { return &f6; }
	inline void fs6(t3525329788  value)
	{
		f6 = value;
	}

	inline static int32_t fog7() { return static_cast<int32_t>(offsetof(t3412528602, f7)); }
	inline float fg7() const { return f7; }
	inline float* fag7() { return &f7; }
	inline void fs7(float value)
	{
		f7 = value;
	}

	inline static int32_t fog8() { return static_cast<int32_t>(offsetof(t3412528602, f8)); }
	inline float fg8() const { return f8; }
	inline float* fag8() { return &f8; }
	inline void fs8(float value)
	{
		f8 = value;
	}

	inline static int32_t fog9() { return static_cast<int32_t>(offsetof(t3412528602, f9)); }
	inline float fg9() const { return f9; }
	inline float* fag9() { return &f9; }
	inline void fs9(float value)
	{
		f9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
