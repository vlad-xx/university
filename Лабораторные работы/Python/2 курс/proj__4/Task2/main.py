'''
Задание 2

2.1 Написать скрипт, доказывающий справедливость представленного
выше правила работы при совпадении имён
методов базового и производного класса.
'''

class Class1:
    def func1(self):
        print("Main class")

class Class2(Class1):
    def func1(self):
        print("Base class")

obj = Class2()
obj2 = Class1()
print(obj.func1())
print(obj2.func1())


