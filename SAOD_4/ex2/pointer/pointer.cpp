﻿// pointer.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "utils_p.h"
using namespace std;


int main()
{
    int x = 3;
    int y = 5;

    Swap(x, y);


    cout << x << y << endl;
    cout << "Hello World!\n";


   /* int x = 3;
    int *p = &x;
    cout << x << ' ' << *p << ' ' << p << ' '  << endl;

    p++;
    cout << p - &x << endl;
    cout << x << endl;

    typedef unsigned char byte;     
    byte* pb = (byte*)--p;		    
    cout << pb << endl;
    for (byte* pt = pb; pt - pb < sizeof(int); pt++)
        cout << (int)*pt << ' ';	*/


    cout << endl;
}


// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
