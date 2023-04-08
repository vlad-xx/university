'''
4.1 Реализовать (в скрипте) и объяснить работу
обеспечения полиморфизма методов, показанных на рисунке 5.14.

4.2 Реализовать 3-4 варианта обеспечения полиморфизма методов,
показанных в таблице 1, не реализованных в предыдущем пункте задания.

4.4 Реализовать обеспечение полиморфизма методов сравнения, показанных в таблице 2.
'''

class Character:
    def __init__(self, hp: int | float) -> None:
        self.hp = hp


# игрок
class Player(Character):
    def __init__(self, hp: int | float = 100) -> None:
        super().__init__(hp=hp)
        self.hp = hp  # очки жизни

    def get_hp(self) -> int | float:
        return self.hp

    def __add__(self, hp) -> object:
        # Player + число
        self.hp += hp
        return self

    def __radd__(self, hp) -> object:
        # число + Player
        self.hp += hp
        return self

    def __iadd__(self, hp) -> object:
        # Player += число
        self.hp += hp
        return self

    def __sub__(self, hp) -> object:
        # Player - число
        self.hp -= hp
        return self

    def __rsub__(self, hp) -> object:
        # число - Player
        self.hp -= hp
        return self

    def __isub__(self, hp) -> object:
        # Player -= число
        self.hp -= hp
        return self

    def __abs__(self) -> object:
        self.hp = 100
        return self

    def __eq__(self, other):
        if (isinstance(other, Character)):
            if (other.hp == self.hp):
                return True
            else:
                return False
        else:
            if (other == self.hp):
                return True
            else:
                return False

    def __ne__(self, other):
        if (isinstance(other, Character)):
            if (other.hp != self.hp):
                return True
            else:
                return False
        else:
            if (other != self.hp):
                return True
            else:
                return False

    def __lt__(self, other):
        if (isinstance(other, Character)):
            if (self.hp < other.hp):
                return True
            else:
                return False
        else:
            if (self.hp < other):
                return True
            else:
                return False

    def __gt__(self, other):
        if (isinstance(other, Character)):
            if (self.hp > other.hp):
                return True
            else:
                return False
        else:
            if (self.hp > other):
                return True
            else:
                return False

    def __le__(self, other):
        if (isinstance(other, Character)):
            if (self.hp <= other.hp):
                return True
            else:
                return False
        else:
            if (self.hp <= other):
                return True
            else:
                return False

    def __ge__(self, other):
        if (isinstance(other, Character)):
            if (self.hp >= other.hp):
                return True
            else:
                return False
        else:
            if (self.hp >= other):
                return True
            else:
                return False

    def __contains__(self, other):
        if (isinstance(other, Player)):
            return True
        else:
            return False


class Enemy(Character):
    def __init__(self, hp: int | float = 100) -> None:
        super().__init__(hp=hp)
        self.hp = hp  # очки жизни


player = Player(100)
print(f"Кол-во очков жизни игрока: {player.get_hp()}")
player = player + 10
print(f"Прибавка жизней игроку - player + 10: {player.get_hp()}")
player = 10 + player
print(f"Еще прибавка жизней игроку - 10 + player: {player.get_hp()}")
player += 10
print(f"Еще прибавка жизней игроку - player += 10: {player.get_hp()}")


print(f"Кол-во очков жизни игрока: {player.get_hp()}")
player = player - 6
print(f"Вычитание жизней игроку - player - 6: {player.get_hp()}")
player = 1 - player
print(f"Еще вычитание жизней игроку - 1 - player: {player.get_hp()}")
player -= 20
print(f"Еще прибавка жизней игроку - player -= 20: {player.get_hp()}")

player = abs(player)
print(f"Кол-во очков жизни игрока: {player.get_hp()}")

enemy = Enemy(50)

print(f"Сравнение очков жизни игрока и врага - player > enemy: {player > enemy}")
print(f"Сравнение очков жизни игрока и врага - player < player: {enemy < player}")
print(f"Сравнение очков жизни игрока и врага - player == enemy: {player == enemy}")
print(f"Сравнение очков жизни игрока и врага - player != enemy: {player != enemy}")
print(f"Сравнение очков жизни игрока и врага - enemy <= player: {enemy <= player}")
print(f"Сравнение очков жизни игрока и врага - player >= enemy: {player >= enemy}")
print(f"Является ли противник другим игроком - enemy in player: {enemy in player}")

print(f"Сравнение очков жизни игрока - player > 50: {player > 50}")
print(f"Сравнение очков жизни игрока - 50 < player: {50 < player}")
print(f"Сравнение очков жизни игрока - player == 100: {player == 100}")
print(f"Сравнение очков жизни игрока - player != 100: {player != 100}")
print(f"Сравнение очков жизни игрока - 120 <= player: {120 <= player}")
print(f"Сравнение очков жизни игрока - player >= 120: {player >= 120}")
print(f"Является ли противник другим игроком - 33 in player: {33 in player}")
