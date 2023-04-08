class Group:

    def __init__(self, students, marks):
        self.students = students
        self.marks = marks

    def __len__(self):
        return len(self.marks)

    def __getitem__(self, i):
        return self.students[i], self.marks[i]

    def __setitem__(self, i, m):
        self.marks[i] = m

students = [(1, "Petr"), (2, "Vladimir")]
marks = [4, 5]

group = Group(students, marks)

print(group.__len__())
print(len(group))

print("-"*32)

print(group.__getitem__(1))
print(group[1])

print("-"*32)

group[1] = 3
print(group[1])
group.__setitem__(1, 5)
print(group[1])