# Для выполнения финального задания было сделано:
|  №  | Действие   | Статус |
| ------- | -------- | ------|
| 1   | Создан репозиторий на GitHub    | +
| 2   | Нарисована блок-схема алгоритма (файл «block diagram.png»)    | +
| 3   | В репозиторий добавлено текстовое описание решения (файл README.md)    | +
| 4   | Написана программа, решающую поставленную задачу (Program.cs)    | +
| 5   | Использован контроль версий в работе над этим проектом    | +

<!-- title only -->
<h2 align="center"> № 3 </h2> 
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
