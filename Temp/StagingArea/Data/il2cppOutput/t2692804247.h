﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3505791693;

#include "t1733537956.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2692804247  : public t1733537956
{
public:
	t3505791693 * f0;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2692804247, f0)); }
	inline t3505791693 * fg0() const { return f0; }
	inline t3505791693 ** fag0() { return &f0; }
	inline void fs0(t3505791693 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
