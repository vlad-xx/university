from datetime import date

class Person:

    def __init__(self, name: str, age: int) -> None:
        self.name = name
        self.age = age

        print(f"name: {self.name}\nage: {self.age}")
        if (self.stat_method(self.age)):
            print("mes: You can watch film\n")
        else:
            print("mes: You can not watch film\n")

    @classmethod
    def cls_method(cls, name: str, age: int) -> object:
        return cls(name, age)

    @staticmethod
    def stat_method(age: int) -> bool:
        return age >= 18


obj = Person("Kirill", 18)
obj2 = Person.cls_method("Dmitry", 17)




# is_majority = Person.stat_method(21) # majority - совершеннолетие
# if is_majority:
#     print("You can watch film")
# else:
#     print("You can not watch film")
