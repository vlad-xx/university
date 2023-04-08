'''
Задание 1

Самостоятельно создать дочерние классы для пикапов и джипов,
имеющих собственные специфические характеристики. Эти характеристики можно взять из интернета.

Изменить базовый класс таким образом,
чтобы была возможность дополнительно фиксировать
и менять одно из двух возможных состояний автомобиля: «выставлен на продажу» или «продан»

Продемонстрировать работу программы
на примере работы с двумя экземплярами автомобиля каждого из трёх классов.

Предложить вариант выделения печати в отдельную функцию.
'''

class Automobile:
    def __init__(self, make, model, mileage, price, status):
        self.__make = make
        self.__model = model
        self.__mileage = mileage
        self.__price = price
        self.__status = status

    def print_info(self):
        print("INFO\n"
        f"make: {self.__make}\n"
        f"model: {self.__model}\n"
        f"mileage: {self.__mileage}\n"
        f"price: {self.__price}\n"
        f"status: {self.__status}")

    def set_status(self, new_status):
        self.__status = new_status

    def set_make(self, make):
        self.__make = make

    def set_model(self, model):
        self.__model = model

    def set_mileage(self, mileage):
        self.__mileage = mileage

    def set_price(self, price):
        self.__price = price

    def get_status(self):
        return self.__status

    def get_make(self):
        return self.__make

    def get_model(self):
        return self.__model

    def get_mileage(self):
        return self.__mileage

    def get_price(self):
        return self.__price

class Car(Automobile):
    def __init__(self,  make, model, mileage, price, status, num_doors):
        Automobile.__init__(self, make, model, mileage, price, status)
        self.__num_doors = num_doors

    def set_num_doors(self, num_doors):
        self.__num_doors = num_doors

    def get_num_doors(self):
        return self.__num_doors

class Jeep(Automobile):
    def __init__(self, make, model, mileage, price, status, num_doors):
        Automobile.__init__(self, make, model, mileage, price, status)
        self.__num_doors = num_doors

    def set_num_doors(self, num_doors):
        self.__num_doors = num_doors

    def get_num_doors(self):
        return self.__num_doors

class Pickup(Automobile):
    def __init__(self, make, model, mileage, price, status, num_doors):
        Automobile.__init__(self, make, model, mileage, price, status)
        self.__num_doors = num_doors

    def set_num_doors(self, num_doors):
        self.__num_doors = num_doors

    def get_num_doors(self):
        return self.__num_doors