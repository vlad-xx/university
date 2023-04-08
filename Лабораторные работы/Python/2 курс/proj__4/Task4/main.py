'''
Задание 4

Проверить варианты наследования конструктора базового класса
дочерним на примере рисунков 4.7-4.9 добавив
для класса грузовиков ещё одно свойство «цена_перевозки».
'''
from Car import Truck

truck1 = Truck(model='Камаз', speed=120, carring=2.5, transport_price=5000)
truck1.show_info()
truck1.loading()
truck1.show_carring()
# цена_перевозки
truck1.show_transport_price()

