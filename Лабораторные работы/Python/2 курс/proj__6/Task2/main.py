class Student:
    def __init__(self, name, id):
        self.name = name
        self.id = id

    @property
    def get_name(self):
        return self.name

    @get_name.getter
    def full_id(self):
        return f"{self.name} {self.id}"


stud1 = Student("Bob", 1000)
stud2 = Student("Marie", 1001)

print(stud1.get_name)
print(stud1.full_id)

print(stud2.get_name)
print(stud2.full_id)