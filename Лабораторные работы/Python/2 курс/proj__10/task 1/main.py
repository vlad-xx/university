"""
Задание 1
1.1.	Реализовать скрипт, данный на рисунке 10.1.
1.2.	Зафиксировать и проверить на практике разницу в использовании метода bind() и параметра command.
1.3.	Ответить на вопрос, каким образом кнопка2 привязывается к виджету окно2.
1.4.	Написать скрипт, в котором событие «клика» по 2-ой кнопке приводило бы к исчезновению первого окна.
1.5.	Определить, есть ли жёсткая связь двух окон, создаваемых по скрипту на рисунке 10.1. Вывод доказать.
"""

# from tkinter import *
#
# window1 = Tk()
# window1.title("Main window")
# window1.geometry("250x250")
#
# def click(event):
#     window2 = Tk()
#     window2.title("New window")
#     window2.geometry("200x200")
#     btn2 = Button(window2, text="Button without events and actions") # через master происходит привязка к окну
#     btn2.pack(anchor=CENTER, expand=1)
#
# btn1 = Button(text="Create window")
# btn1.bind('<Button-1>', click)
# btn1.pack(anchor=CENTER, expand=1)
#
# window1.mainloop()

# from tkinter import *
#
# window1 = Tk()
# window1.title("Main window")
# window1.geometry("250x250")
#
# def click(event):
#     window2 = Tk()
#     window2.title("New window")
#     window2.geometry("200x200")
#     btn2 = Button(window2, text="Button without events and actions")
#     btn2.pack(anchor=CENTER, expand=1)
#
#
# # к виджетам имеющим параметр command можно привязать только одно событие
# # не требует параметра event в функции
# # btn1 = Button(text="Create window", command=click)
#
# # может задавать виджету несколько событий
# # функция должна иметь параметр event (имя может быть любым, обязательно должно стоять на первом месте), через который передается событие.
# # функцию можно привязать виджетам не имеющим параметр command
# btn1.bind('<Button-1>', click)
# # lbl1 = Label(text="Click on me")
# # lbl1.bind('<Button-1>', click)
#
# btn1.pack(anchor=CENTER, expand=1)
# # lbl1.pack(anchor=CENTER, expand=1)
#
# window1.mainloop()

from tkinter import *

window1 = Tk()
window1.title("Main window")
window1.geometry("250x250")

def closeMainWindow(event):
    window1.destroy() # уничтожает окно
    # window1.quit() # завершает работу цикла

def createWindow(event):
    window2 = Tk()
    window2.title("New window")
    window2.geometry("200x200")
    btn2 = Button(window2, text="Button without events and actions") # через master происходит привязка к окну
    btn2.bind('<Button-1>', closeMainWindow)
    btn2.pack(anchor=CENTER, expand=1)


btn1 = Button(text="Create window")
btn1.bind('<Button-1>', createWindow)
btn1.pack(anchor=CENTER, expand=1)

window1.mainloop()































