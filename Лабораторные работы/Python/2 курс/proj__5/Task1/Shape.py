from math import pi


class Shape:
    def __init__(self, name: str = 'Shape') -> None:
        self.name = name

    def area(self) -> None:
        ...

    def fact(self) -> str:
        return f"I'm a shape"

    def __str__(self) -> str:
        return self.name


class Square(Shape):
    def __init__(self, length: [int, float]) -> None:
        super().__init__(name='Square')
        self.length = length

    def area(self) -> [int, float]:
        return self.length ** 2

    def fact(self) -> str:
        return f"I'm a square"


class Circle(Shape):
    def __init__(self, radius: [int, float]) -> None:
        super().__init__(name='Circle')
        self.radius = radius

    def area(self) -> [int, float]:
        return pi * self.radius ** 2
