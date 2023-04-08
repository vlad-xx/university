class Person:
    name = ""
    age = 0

    def __init__(self, personName, personAge):
        self.name = personName
        self.age = personAge

    def __str__(self):
        return f"Person\n/name: {self.name}\n/age: {self.age}"

    def __repr__(self):
        return {
            "name": self.name,
            "age": self.age
        }

person1 = Person("Andrey", 20)

print(person1.__str__())
print(person1.__repr__())

print("#"*32)

print(str(person1))
try:
    print(repr(person1))
except Exception as ex:
    print(ex)

print("#"*32)

print(type(person1.__str__()))
print(type(person1.__repr__()))