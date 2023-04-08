class Grandfather:
    def __init__(self, arm, leg, head):
        self.arm = arm
        self.leg = leg
        self.head = head


class Parent(Grandfather):
    def __init__(self, arm, leg, head, eyes):
        Grandfather.__init__(self, arm, leg, head)
        self.eyes = eyes


class Son(Grandfather):
    def __init__(self, arm, leg, head, eyes, hair):
        Parent.__init__(self, arm, leg, head, eyes)
        self.hair = hair
    def info1(self):
        print(self.arm, self.leg, self.head, self.eyes, self.hair)

obj1 = Son(1, 2, 3, 4, 5)
obj1.info1()

