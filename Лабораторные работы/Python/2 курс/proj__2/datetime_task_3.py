from datetime import *


print("1) текущие дата и время")
# текущие дата и время
dt_now = datetime.now()
print(dt_now)


print("\n2) текущая дата")
# текущая дата
cur_date = date.today()
print(cur_date)


print("\n3) текущее время")
# текущее время
cur_time = dt_now.time()
print(cur_time)


print("\n4) объекты даты и времени")
# объекты даты и времени
time_obj = time(8,40,50)
print(time_obj)
date_obj = datetime(2007,11,5)
print(date_obj)


print("\n5) разница дат")
# разница дат
date_obj1 = datetime(2007,11,5)
date_obj2 = datetime(2007,10,1)
print(date_obj1 - date_obj2)