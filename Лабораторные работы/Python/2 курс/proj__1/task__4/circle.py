import math

class Circle:

    def __init__(self, radius: [int, float]) -> None:
        self.radius = radius
        self.area = pow(self.radius, 2) * math.pi

    def change_radius(self, new_radius: [int, float]) -> None:
        self.radius = new_radius
        self.area = pow(self.radius, 2) * math.pi

    def get_area(self) -> float:
        return self.area

