#pragma once
#include "Test.h"


class Child :
    public Test
{
public:
    Child() {
        std::cout << "hello child" << std::endl;
    }
    ~Child() {
        std::cout << "bye child" << std::endl;
    }

};

