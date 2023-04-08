from circle import Circle

c1 = Circle(1)
c2 = Circle(2)

print(f"Площадь 1 круга: {c1.get_area()}")
print(f"Площадь 2 круга: {c2.get_area()}")


c1.change_radius(4)
c2.change_radius(8)

print(f"Площадь 1 круга: {c1.get_area()}")
print(f"Площадь 2 круга: {c2.get_area()}")

