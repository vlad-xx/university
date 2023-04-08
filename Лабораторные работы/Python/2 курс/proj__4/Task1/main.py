import Automobile

car1 = Automobile.Car("MAZDA", "3", 90_000, 400_000, "Выставлена на продажу", 4)
car2 = Automobile.Car("TOYOTA", "Camry", 70_000, 3_500_000, "Продан", 4)

jeep1 = Automobile.Jeep("CADILLAC", "Escalade", 100_000, 4_000_000, "Продан", 5)
jeep2 = Automobile.Jeep("VOLVO", "XC60", 90_000, 3_500_000, "Продано", 5)

pickup1 = Automobile.Pickup("HONDA", "Ridgeline", 110_000,6_200_000, "Продан", 5)
pickup2 = Automobile.Pickup("CHEVROLET", "Silverado", 120_000, 4_500_000, "Выставлена на продажу", 5)

car1.print_info()
print(f"num of doors: {car1.get_num_doors()}\n")
car2.print_info()
print(f"num of doors: {car2.get_num_doors()}\n")
jeep1.print_info()
print(f"num of doors: {jeep1.get_num_doors()}\n")
jeep2.print_info()
print(f"num of doors: {jeep2.get_num_doors()}\n")
pickup1.print_info()
print(f"num of doors: {pickup1.get_num_doors()}\n")
pickup2.print_info()
print(f"num of doors: {pickup2.get_num_doors()}\n")