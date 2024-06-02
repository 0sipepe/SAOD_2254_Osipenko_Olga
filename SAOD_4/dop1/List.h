#pragma once
#include <iostream>
template <typename T>
class List
{
    inline class Node
    {

        
    public:
        T value;
        Node* Next;
        Node(const T& val) {
            value = val;
        }
        Node(Node& n) {
            Next = n.Next;
            value = n.value;
        }

        Node();

    };

   

    Node* last = nullptr;

public:
    int count;
    List() {}
    List(const List& l) {
        count = 0;
        
        for (int i = 0; i < l.count; i++) {
            Node* n(last);
            last->Next = n;
            last = n;
            count++;
        }
    }
  

    List(const std::initializer_list<T>& initList) : last(nullptr), count(0) {
        for (const T& value : initList) {
            push_back(value);
        }
    }

    // Оператор присваивания
    List& operator=(const List& other) {
        if (this != &other) {
            clear(); // Очищаем текущий список

            // Копируем элементы из 'other'
            if (other.last != nullptr) {
                Node* current = other.last->Next;
                do {
                    push_back(current->value);
                    current = current->Next;
                } while (current != other.last->Next);
            }
        }
        return *this;
    }

    // ... (другие методы)

    void push_back(const T & value) {
        if (count == 0) {
            last = new Node(value);
            last->Next = last;
            last = last->Next;
        }
        else {
            Node* first = last->Next;
            last->Next = new Node(value);
            last = last->Next;
            last->Next = first;
        }
        count++;
    }
      
    
    void push_front(const T& value) {
        if (count == 0) {
            last = new Node(value);
            last->Next = last;
            last = last->Next;
        }
        else {
            Node* tmp = new Node(value);
            tmp->Next = last->Next;
            last->Next  = tmp;

        }
        count++;
    }
    void insert(int index, const T& value) {
        if (index > count + 1) {
            return;
        }
        if (index == count) {
            push_back(value);
        }
        else if (index == 0) {
            push_front(value);
        }
        else {
            Node* tmp = last;
            for (int i = 0; i < index; i++) {
                tmp = tmp->Next;
            }
            Node* tmp1 = new Node(value);
            tmp1->Next = tmp->Next;
            tmp->Next = tmp1;
            count++;
        }

    }
    //– добавляет элемент по индексу;
    void pop_back() {
        if (count != 0) {
            Node* tmp = last;
            for (int i = 0; i < count - 1; i++) {
                tmp = tmp->Next;
            }
            tmp->Next = last->Next;
            delete last;
            last = tmp;
            count--;

        }
        else return;
    }//– удаляет последний элемент в списке;
    void pop_front() {
        if (count != 0) {
            Node* tmp = last->Next;
            last->Next = last->Next->Next;
            delete tmp;

            count--;
        }
        else return;
    }
    //– удаляет первый элемент в списке;
    void remove_at(int index) {
        if (index > count) {
            return;
        }
        if (count == 1) {
            clear();
        }
        else if (index == count - 1) {
            pop_back();
        }
        else if (index == 0) {
            pop_front();
        }
        else {
            Node* tmp = last;
            for (int i = 0; i < index; i++) {
                tmp = tmp->Next;
            }
            Node* tmp1 = tmp->Next;
            tmp->Next = tmp->Next->Next;
            delete tmp1;
            count--;
        }
        
       

    } //– удаляет элемент в списке по указанному индексу;
    T& operator[](const int index) {
        Node* tmp = last->Next;
        for (int i = 0; i < index; i++) {
            
            tmp = tmp->Next;    
        }
        //std::cout << tmp->value << '\n';
        return tmp->value;
    }
    //– для записи элемента по указанному индексу;
    T const& operator[](const int index) const {

        Node* tmp = last->Next;
        for (int i = 0; i < index; i++) {
            tmp = tmp->Next;
        }
        return tmp->value;
    }//– для чтения по индексу;
    //– для чтения по индексу;
    int size() const {
        return count;
    }//– возвращает количество элементов в списке;
    bool empty() const {
        if (count != 0) {
            return false;
        }
        return true;
    }//– отвечает на вопрос пустой ли список;
    void clear() 
    {
        for (int i = 0; i < count - 1; i++) {
            Node* tmp = last->Next;
            last->Next = last->Next->Next; 
            delete tmp;
           
        }
        last = nullptr;
        count = 0;
    }

    //– очищает список, удаляет все узлы;
    T front() const {
        Node tmp(last);
        for (int i = 0; i < count - 1; i++) {
            tmp = tmp->Next;
        }
        return tmp->value;
    }
    //– возвращает первый элемент списка;
    T back() const {
        return last->value;
    } //– возвращает последний элемент списка.
    ~List() {
        clear();
    }
    

};