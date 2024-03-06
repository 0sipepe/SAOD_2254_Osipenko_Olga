#pragma once
#include "Test.h"
class Aggregate
{
	Test m_objTest;
	//Test* m_objTest = new Test();
public: 
	Aggregate(Test t) {
		m_objTest = t;
		//memcpy(m_objTest, t, 1);
		std::cout << "hello agreg id = " << m_objTest.id /* m_objTest->id */<< std::endl;
	}
	~Aggregate() {
		//delete m_objTest;
		std::cout << "bye agreg id = " << m_objTest.id /* m_objTest->id */ << std::endl;
	}
};

