#include "Test.h"
int Test::nCount = 0;

Test::Test() {

	nCount++;
	
	std::cout << "count: " << nCount << " , hi id " << id << std::endl;
};
Test::Test(const Test& t) //Константная ссылка на объект
{
	std::cout << "COPU" << std::endl;
	id = t.id + 10;
	nCount++;
	std::cout << "count: " << nCount << " , hii id " << id << std::endl;
	
}

Test::Test(int n) {
	id = n;
	nCount++;
	std::cout << "count: " << nCount << " , hiii id " << id << std::endl;
}
Test::~Test() {
	nCount--;
	
	std::cout << "count: " << nCount << " destructing with id: " << id << std::endl;;
}


