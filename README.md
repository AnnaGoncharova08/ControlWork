# Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

# Описание решения:

* Задаем два строковых массив, элементы для первого задаем сразу. 
* Описываем метод для печати массива и применяем его для первого массива.
* Создаем метод, где описываем цикл, в котором будут перебираться элементы массива. Внутри цикла задаем проверку условия, чтобы количество символов в элементе было меньше или равно 3. Если проверяемый элемент удовлетворяет условию, то записываем элемент во второй массив. Если проверяемый элемент не удовлетворяет условию, то переходим к проверке следующего элемента. При этом после каждой проверки увеличиваем переменную count на 1 и возвращаемся к циклу for в котором i увеличивается на 1. И так проверяем весь массив.
* Применяет метод печати для второго масссива.