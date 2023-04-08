class Car:
    def __init__(self, model, speed):
        self.model = model
        self.speed = speed
    def show_info(self):
        print('Модель = ', self.model)
        print('Скорость = ', self.speed)

class Truck(Car):
    # carring - грузоподъемность
    # transport_price - цена перевозки
    def __init__(self, model, speed, carring, transport_price):
        super().__init__(model, speed)
        self.__carring = carring
        self.__transport_price = transport_price
    # loading - погрузка
    def loading(self):
        print('Погрузка товаров')
    def show_carring(self):
        print('Грузоподъемность = ', self.__carring)
    def show_transport_price(self):
        print('Цена перевозки = ', self.__transport_price)


