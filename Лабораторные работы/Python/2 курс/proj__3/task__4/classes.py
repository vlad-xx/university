class Person:

    def __init__(self, name: str = None) -> None:
        self.__name = name

    @property
    def name(self):
        return self.__name

    @name.setter
    def set_name(self, new_name):
        self.__name = new_name


class Student:

    def __init__(self, first_name: str = None, second_name: str = None, last_name: str = None) -> None:
        self.__first_name = first_name
        self.__second_name = second_name
        self.__last_name = last_name

    @property
    def FSL(self) -> str:
        return f"{self.__second_name} {self.__first_name} {self.__last_name}"

    @FSL.setter
    def set_fname(self, first_name: str) -> None:
        self.__first_name = first_name

    @FSL.setter
    def set_sname(self, second_name: str) -> None:
        self.__second_name = second_name

    @FSL.setter
    def set_lname(self, last_name: str) -> None:
        self.__last_name = last_name

class Employee:

    def __init__(self, name, last_name, position):
        self.name = name
        self.last_name = last_name
        self.position = position

    @property
    def data(self):
        return f"{self.position} - {self.name} {self.last_name}"
