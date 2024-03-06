#pragma once
#include "Test.h"

template <typename T> class AggT {
	
public:
	T M;
	AggT(Test m) {
		M = m;
		std::cout << "start template and " << std::endl;
	};
	~AggT() {
		std::cout << "end template and " << std::endl;
	}
	
};


