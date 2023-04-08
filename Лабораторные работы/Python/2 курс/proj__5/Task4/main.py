'''
Реализовать приведённые ниже тексты в PyCharm
с выводом результата на печать в консоли и дать объяснение полученных результатов.
Комментарии в тексте указывают на результат!
class Base:
    def __init__(self):
        self.foo='foo'

class Sub(Base):
    def __init__(self):
        super().__init__()

@>>> obj = Base()
@>>> sub_obj = Sub()
@>>> isinstance(obj, Base)
# True
@>>> isinstance(obj, Sub)
# False
@>>> isinstance(sub_obj, Base)
# True
@>>> isinstance(sub_obj, Sub)
# True
@>>> type(sub_obj) == Base
# False
@>>> type(sub_obj)
# <class '__main__.Sub'>
@>>> type(sub_obj) == Sub
# True
@>>> issubclass(type(sub_obj), Base)
# True


@>>> x = 1
@>>> isinstance(x, int)
# True
@>>> x = [1, 2, 3]
@>>> isinstance(x, list)
# True
@>>> x = (1, 2, 3)
@>>> isinstance(x, tuple)
# True

# Проверим, является ли строка 'Hello' одним из типов, описанных в параметре type
@>>> isinstance('Hello', (float, int, str, list, dict, tuple))
# True

# Проверка, на принадлежность к экземпляром myObj
class myObj:
  name = "John"

y = myObj()
@>>> isinstance(y, myObj)
# True

'''


class Base:
    def __init__(self):
        self.foo='foo'

class Sub(Base):
    def __init__(self):
        super().__init__()

