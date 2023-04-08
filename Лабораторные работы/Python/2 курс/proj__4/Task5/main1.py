class Class1:
    def func1(self):
        print("func1: Class1")

class Class2(Class1):
    def func2(self):
        print("func2: Class2")

class Class3(Class1):
    def func1(self):
        print("func1: Class3")

    def func2(self):
        print("func2: Class3")

    def func3(self):
        print("func3: Class3")

    def func4(self):
        print("func4: Class3")

class Class4(Class2, Class3):
    def func4(self):
        print("func4: Class4")

obj = Class4()
obj.func1()
obj.func2()
obj.func3()
obj.func4()

