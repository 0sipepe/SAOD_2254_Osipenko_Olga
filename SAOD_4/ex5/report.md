# Отчет по заданию номер 5.

### Осипенко 2254

В задании мы создавали объекты разных классов в разных ситуациях и смотрели на время их жизни.

Ответим на вопросы:

1) В С++ объекты создаются в опр. области и уничтожаются в той же области, например, функции. Глобальные объекты объявляются вне всех блоков и уничтожаются после main. Динамические объекты нужно удалять вручную, прописывать деструктор.

2) В C# объекты тоже уничтожаются после выхода из области, где были объявлены, но даже динамические объекты будет удалять сборщик мусора (в основном). 

3) Случаи неявного копирования: при передаче объекта как параметра функции и , судя по всему, при присваивании (хотя у меня копия не была создана при присваивании)

4) Сначала создается экземпляр класса-предка, а потом и потомка/агрегата.

5) Чтобы сборщик мусора мог очистить объекты, которые требуют принудительного закрытия.

6) да, будет

7) через двоеточие вызвать коструктор с параметром (нужно, чтобы он был определен в предке)

8) через двоеточие и слово base 

9) через двоеточие вызываем конструктор класса от объекта - поля класса-агрегата. То есть передаем параметр объекту ???

10) В С# ссылка сама по себе является неким объектом, она может указывать на разные в разных областях памяти (можно изменить, на что она указывает), она может быть null, а еще используется со ссылочными типами данных.  В С++ ссылка привязана к объекту и области памяти, не может быть изменена и null.

11) Объявляем шаблон в заголовке, используя<typename …> , а при создании обекта в этих скобках пишем тип, который хотим использовать.