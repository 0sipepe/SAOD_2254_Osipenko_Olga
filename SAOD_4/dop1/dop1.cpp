﻿#include <iostream>
#include "List.h"
#include <numeric>

void print_lst(const List<char >& l) {
    for (int i = 0; i < l.count - 1; i++) {
        std::cout << l[i] << " -> ";
    }
    std::cout << l[l.count - 1] << '\n';
}
int main() {
    List<char > lst; // ваш список
    std::cout << std::boolalpha << lst.empty() << std::endl;
    
         for (int i = 0; i < 5; i++)
        lst.push_back(char('a' + i));
    
         print_lst(lst);
    
         for (int i = 0; i < 5; i++)
         lst.insert(0, char('z' - i));
     print_lst(lst);
     for (size_t i = 0; i != lst.size(); i++)
         lst[i] = char('a' + i);
     print_lst(lst);
     lst.pop_back();
     lst.pop_front();
     print_lst(lst);
    
         lst.remove_at(5);
    lst.insert(3, 'o');
     print_lst(lst);
     lst.clear();
     lst.push_back('q');
     lst.push_back('w');
     std::cout << lst.size() << ' ' << std::boolalpha << lst.empty() << std::endl;





}