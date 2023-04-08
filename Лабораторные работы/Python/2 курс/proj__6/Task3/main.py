class Phone:
    person = "Bob"
    phoneNumber = "+79218304451"


print(f"Имя владельца: {Phone.person}")
print(f"Имя владельца (метод getattr): {getattr(Phone, 'person')}")
print(f"Номер телефона (метод getattr): {getattr(Phone, 'phoneNumber')}")


Phone.person = "Jone"
print(f"Новое имя владельца: {Phone.person}")

setattr(Phone, 'person', 'Jill')
print(f"Новое имя владельца: {getattr(Phone, 'person')}")

setattr(Phone, 'phoneNumber', '+79315304150')
print(f"Новый номер телефона: {getattr(Phone, 'phoneNumber')}")
