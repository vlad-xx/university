import faker
import random

fake = faker.Faker(locale='ru_RU')
fake.seed_instance(0)

def fake_info(n):


    fake_list = []

    for i in range(n):
        fake_name = str(fake.name()).split()
        print(fake_name)

        fake_list.append(
            (fake_name[0], fake_name[1], fake_name[2], )
        )

fake_info(2)