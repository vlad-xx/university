from employee import Employee


emp1 = Employee("Олег", 60000)
emp2 = Employee("Андрей", 70000)

emp1.pr_salary()
emp2.pr_salary()

emp1.pr_count()

################
print("#" * 16)

# gattr = getattr(Employee, "count_employees", "Атрибут отсутствует") # доступ к атрибуту объекта
# print(f"[#INFO] getattr -> {gattr}")

# hattr = hasattr(Employee, "count_employees") # проверка существует ли атрибут
# print(f"[#INFO] hasattr -> {hattr}")

# sattr = setattr(Employee, "count_employees", 0) # установка значения атрибута
# gattr = getattr(Employee, "count_employees") # доступ к атрибуту объекта
# print(f"[#INFO] setattr / getattr -> {gattr}")
#
# emp1.pr_count()
#
# emp1.pr_salary()
# emp2.pr_salary()

# dattr = delattr(Employee, "count_employees") # удаление атрибута
# gattr = getattr(Employee, "count_employees", "Атрибут отсутствует") # доступ к атрибуту объекта
# print(f"[#INFO] delattr / getattr -> {gattr}")
#
# emp1.pr_count()
#
# emp1.pr_salary()
# emp2.pr_salary()
