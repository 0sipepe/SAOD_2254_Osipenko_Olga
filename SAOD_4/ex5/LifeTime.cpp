// LifeTime.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Test.h"
#include "Child.h"
#include "Aggregate.h"
#include "AggT.h"

using namespace std;

Test gt  = Test(1);

void foo(Test t) {
    cout << "foo is running" << endl;
}
int main()
{
    int x;
    cin >> x;
    
    cout << "Your num is " << x << endl;

    //cout << "pre-creating" << endl;
    Test t(2);
    ////cout << "post-creating + pre-destructing" << endl;
    //foo(t);
   
    ////cout << "post-destructing" << endl;

    //Test* t2 = new Test();
    //t2->~Test();

    //Test* arr = new Test[3];
    //for (Test* p = arr; p - arr < 3; p++) {
    //    p->~Test();
    //}
    //delete[] arr;

    //Child c;
    Aggregate a(t);
    //AggT<Test> at(t);
    //t.~Test();

    cout << "END" << endl;
    
}


