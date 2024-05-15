#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include "Str.h"


using namespace std;
int main()
{
    cout << "Hello World!\n";
    Str s = "hello";
    cout << s << '\n';
    s += " mama";
    cout << s << " " << s.len() << '\n';
    cout;
    cout << s.rfind("llo", 11);


}
