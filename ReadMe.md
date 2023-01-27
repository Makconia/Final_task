## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

## Алгоритм решения:

1) Запрашиваем у пользователя количество элементов массива (проверяем ответ на соответствие int).
2) Даем пользователю ввести элементы массива (строки) с клавиатуры. При этом запускаем счетчик “count” фиксирующий элементы длина которых <=3, что бы определить размер второго массива (для избежание лишних ячеек).
3) Создаем второй массив исходя из значения счетчика “count”.
4) С помощью цикла заполняем второй массив элементами первого массива отвечающие условию: длина строки <=3.
5) Выводим на консоль второй массив для демонстрации результата.