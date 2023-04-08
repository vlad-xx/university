class Vector:
    def get_params(self):
        raise NotImplementedError("В дочернем классе должен быть переопределен метод get_params()")


class Vector2D(Vector):
    def __init__(self, x: int | float = 0, y: int | float = 0) -> None:
        self.x = x
        self.y = y

    def get_params(self) -> str:
        return f"Vector2D: {self.x = }; {self.y = }"


class Vector3D(Vector):
    def __init__(self, x: int | float = 0, y: int | float = 0, z: int | float = 0) -> None:
        self.x = x
        self.y = y
        self.z = z

    def get_params(self) -> str:
        return f"Vector3D: {self.x = }; {self.y = }; {self.z = }"


class Vector4D(Vector):
    def __init__(self, x: int | float = 0, y: int | float = 0, z: int | float = 0, t: int | float = 0) -> None:
        self.x = x
        self.y = y
        self.z = z
        self.t = t
