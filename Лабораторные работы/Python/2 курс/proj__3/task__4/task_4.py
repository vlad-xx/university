from classes import Person, Student, Employee

# # person
# p1 = Person("IVAN")
# print(p1.name)
# p1.set_name = "DMITRY"
# print(p1.name)
# p1 = Person("IVAN")
# print(p1.name)
# p1.set_name = "DMITRY"
# print(p1.name)
#
# # student
# student1 = Student("IVAN", "IVANOV", "IVANOVICH")
# print(student1.FSL)
# student1.set_fname = "VLADIMIR"
# student1.set_sname = "VLADIMIROV"
# student1.set_lname = "VLADIMIROVICH"
# print(student1.FSL)

# employee
name = input("ИМЯ: ")
last_name = input("ФАМИЛИЯ: ")
position = input("ДОЛЖНОСТЬ: ")

obj = Employee(name, last_name, position)
print(obj.data)

















