#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t4012695102;
struct t284553113;
struct t2244299850;

#include "t3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2393081601  : public t3012272455
{
public:
	float f2;
	t4012695102 * f3;
	t284553113 * f4;
	t2244299850 * f5;
	float f6;
	float f7;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t2393081601, f2)); }
	inline float fg2() const { return f2; }
	inline float* fag2() { return &f2; }
	inline void fs2(float value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t2393081601, f3)); }
	inline t4012695102 * fg3() const { return f3; }
	inline t4012695102 ** fag3() { return &f3; }
	inline void fs3(t4012695102 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t2393081601, f4)); }
	inline t284553113 * fg4() const { return f4; }
	inline t284553113 ** fag4() { return &f4; }
	inline void fs4(t284553113 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t2393081601, f5)); }
	inline t2244299850 * fg5() const { return f5; }
	inline t2244299850 ** fag5() { return &f5; }
	inline void fs5(t2244299850 * value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t2393081601, f6)); }
	inline float fg6() const { return f6; }
	inline float* fag6() { return &f6; }
	inline void fs6(float value)
	{
		f6 = value;
	}

	inline static int32_t fog7() { return static_cast<int32_t>(offsetof(t2393081601, f7)); }
	inline float fg7() const { return f7; }
	inline float* fag7() { return &f7; }
	inline void fs7(float value)
	{
		f7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
