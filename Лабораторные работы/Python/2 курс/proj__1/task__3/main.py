class Constructor:
    def __init__(self, first, second):
        self.first_name = first
        self.second_name = second

obj1 = Constructor("Пётр", "Андрей")
print(obj1.first_name, obj1.second_name)

class NoConstructor:
    def name(self, first, second):
        self.first_name = first
        self.second_name = second

obj2 = NoConstructor()
obj2.name("Пётр", "Андрей")
print(obj2.first_name, obj2.second_name)