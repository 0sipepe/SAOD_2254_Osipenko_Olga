#pragma once
#include <iostream>

class Test
{
	

public:

	int id;
	static int nCount;
	Test(int n);
	Test(const Test& t);
	Test();
	~Test();
	
};


