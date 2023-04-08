class vector0:
    def __init__(self, x: int = 0, y: int = 0) -> None:
        self.x = x
        self.y = y

class vector1:
    def __init__(self, x: int = 0, y: int = 0) -> None:
        self._x = x
        self._y = y

class vector2:
    def __init__(self, x: int = 0, y: int = 0) -> None:
        self.__x = x
        self.__y = y

        print(self.__x)

    def show_x(self):
        return self.__x