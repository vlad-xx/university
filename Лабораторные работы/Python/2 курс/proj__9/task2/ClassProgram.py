from tkinter import *
from abc import ABC, abstractmethod
import re


class Program(Tk):

    def __init__(self, width: int, height: int, xWinPos: int = 0, yWinPos: int = 0, title: str = "tk"):
        super().__init__()                                      # наследуются методы класса Tk

        self.title(title)                                       # задается заголовок окна программы
        self.geometry(f"{width}x{height}+{xWinPos}+{yWinPos}")  # задаются параметры окна программы

        check = (self.register(self.isValid), '%P')                                             # проверка ввода
        self.blockEntry = BlockEntry(self, 'key', check)                                        # блок полей ввода
        self.blockOperation = BlockOperation(self, self.add, self.sub, self.mul, self.div)      # блок операций
        self.blockResult = BlockResult(self, "резульат")                                        # блок поля вывода

        self.blockResult.setColor(bg="#000000", fg="#ffffff")

        # задается сетка
        self.blockEntry.setGrid(
            row=[1, 2], column=[0, 0], columnspan=[2, 2], sticky="NSEW"
        )
        self.blockOperation.setGrid(
            row=[3, 4, 3, 4], column=[0, 0, 1, 1], columnspan=[1, 1, 1, 1], sticky="NSEW"
        )
        self.blockResult.setGrid(
            row=5, column=0, columnspan=4, sticky="NSEW"
        )

        self.columnconfigure(0, weight=1)  # распределение столбца 0 по всей ширине окна
        self.columnconfigure(1, weight=1)  # распределение столбца 1 по всей ширине окна

        # задаются начальные значения полей ввода
        self.value1 = 0
        self.value2 = 0


    def isValid(self, val):
        '''
        проверка вводимых символов
        :param val: вводимый символ
        '''

        pattern = re.match('^-?\d*\.?\d*$', val)  # паттерн строки
                                                  # ( ^-? - в начале строки может быть 1 или 0 вхождений символа "-",
                                                  # \d* - числа от 0 вхождений и более,
                                                  # \.? - может быть 1 или 0 вхождений символа ".",
                                                  # \d*$ - числа от 0 вхождений и более в конце строки )

        return pattern is not None  # возвращает объект match если вводимые символы соответстуют паттерну


    def isNums(self) -> bool:
        '''
        проверка заданных значений
        если значения заданы они конвертируются в тип float
        '''

        self.value1 = self.blockEntry.getValue()[0]
        self.value2 = self.blockEntry.getValue()[1]
        if (self.value1 != '' and self.value2 != ''):
            self.value1, self.value2 = float(self.value1), float(self.value2)
            return True
        return False


    def add(self) -> None:
        self.blockResult.updateText(self.value1 + self.value2 if (self.isNums()) else "ошибка")


    def sub(self) -> None:
        self.blockResult.updateText(self.value1 - self.value2 if (self.isNums()) else "ошибка")


    def mul(self) -> None:
        self.blockResult.updateText(self.value1 * self.value2 if (self.isNums()) else "ошибка")


    def div(self) -> None:
        self.blockResult.updateText(self.value1 / self.value2 if (self.isNums()) else "ошибка")


    def run(self):
        self.mainloop()     # запуск программы


class Block(ABC):

    @abstractmethod
    def setGrid(self, row, column, columnspan, sticky):
        print("Grid was set")


class BlockEntry(Block):

    def __init__(self, master, validate, validatecommand):
        self.entry1 = Entry(master=master, validate=validate, validatecommand=validatecommand)
        self.entry2 = Entry(master=master, validate=validate, validatecommand=validatecommand)


    def setGrid(self, row, column, columnspan, sticky):
        self.entry1.grid(row=row[0], column=column[0], columnspan=columnspan[0], sticky=sticky)
        self.entry2.grid(row=row[1], column=column[1], columnspan=columnspan[1], sticky=sticky)


    def getValue(self):
        return [self.entry1.get(), self.entry2.get()]



class BlockOperation(Block):

    def __init__(self, master, funcAdd, funcSub, funcMul, funcDiv):
        self.btnAdd = Button(master=master, text='+', command=funcAdd)
        self.btnSub = Button(master=master, text='-', command=funcSub)
        self.btnMul = Button(master=master, text='*', command=funcMul)
        self.btnDiv = Button(master=master, text='/', command=funcDiv)


    def setGrid(self, row, column, columnspan, sticky):
        self.btnAdd.grid(row=row[0], column=column[0], columnspan=columnspan[0], sticky=sticky)
        self.btnSub.grid(row=row[1], column=column[1], columnspan=columnspan[1], sticky=sticky)
        self.btnMul.grid(row=row[2], column=column[2], columnspan=columnspan[2], sticky=sticky)
        self.btnDiv.grid(row=row[3], column=column[3], columnspan=columnspan[3], sticky=sticky)


class BlockResult(Block):

    def __init__(self, master, text):
        self.lblResult = Label(master=master, text=text)


    def setGrid(self, row, column, columnspan, sticky):
        self.lblResult.grid(row=row, column=column, columnspan=columnspan, sticky=sticky)


    def setColor(self, bg, fg):
        self.lblResult['bg'] = bg
        self.lblResult['fg'] = fg


    def updateText(self, text):
        self.lblResult['text'] = text