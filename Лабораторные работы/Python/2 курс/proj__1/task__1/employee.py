class Employee:  # сотрудник
    """Базовый класс для всех сотрудников"""

    count_employees = 0

    def __init__(self, name: str, salary: int) -> None:
        self.name = name
        self.salary = salary
        Employee.count_employees += 1

    def pr_count(self) -> None:
        print(f"Кол-во сотрудников: {Employee.count_employees}")

    def pr_salary(self) -> None:
        print(f"{self.name}: ${self.salary}")