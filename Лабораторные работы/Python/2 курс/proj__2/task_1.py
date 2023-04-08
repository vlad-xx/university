from random import randint


class Coin:

    count = 0
    count1 = 0
    count2 = 0

    def __init__(self):
        n = randint(0, 1)
        if n == 1:
            self.side = "Решка"
        else:
            self.side = "Орел"

    def flip(self):
        n = randint(0, 1)
        if n == 1:
            self.side = "Решка"
            Coin.count1 += 1
        else:
            self.side = "Орел"
            Coin.count2 += 1

        Coin.count += 1

    def res(self):
        return self.side

coin1 = Coin()
coin2 = Coin()
coin3 = Coin()

coins = [coin1, coin2, coin3]

for coin in coins:
    for j in range(5):
        coin.flip()
        print(coin.res())
    print()

print(coin1.count)

















