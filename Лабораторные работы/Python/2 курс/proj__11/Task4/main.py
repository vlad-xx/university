import sqlite3
import tkinter

# sqlite
database = sqlite3.connect('university.db')
controller = database.cursor()

# создание таблиц
controller.execute('''CREATE TABLE IF NOT EXISTS student_info (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    surname TEXT NOT NULL,
    midname TEXT NULL,
    sex TEXT NOT NULL,
    phone_number TEXT NOT NULL
)''')
database.commit()

controller.execute('''CREATE TABLE IF NOT EXISTS specialty (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    course INTEGER NOT NULL
)''')
database.commit()

controller.execute('''CREATE TABLE IF NOT EXISTS student_group (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    specialty_id INTEGER,
    FOREIGN KEY (specialty_id) REFERENCES specialty (id)
)''')
database.commit()

controller.execute('''CREATE TABLE IF NOT EXISTS student (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    info_id INTEGER,
    group_id INTEGER,
    FOREIGN KEY (group_id) REFERENCES student_group (id),
    FOREIGN KEY (info_id) REFERENCES student_info (id)
)''')
database.commit()


student_info_data = []


# tkinter

