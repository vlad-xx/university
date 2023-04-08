from classes import Phone

ph1 = Phone("Samsung", 100123, 60000)
print(f"Manufact: {ph1.get_manufact()};\n"
      f"Model: {ph1.get_model()};\n"
      f"Retail price: {ph1.get_retail_price()};\n")

ph2 = Phone("Motorola", 100987, 24000)
print(f"Manufact: {ph2.get_manufact()};\n"
      f"Model: {ph2.get_model()};\n"
      f"Retail price: {ph2.get_retail_price()};\n")

ph3 = Phone("IPhone", 200456, 120000)
print(f"Manufact: {ph3.get_manufact()};\n"
      f"Model: {ph3.get_model()};\n"
      f"Retail price: {ph3.get_retail_price()};\n")
#############################################################
print("#" * 32)

ph1.set_model(123123)
print(f"Manufact: {ph1.get_manufact()};\n"
      f"Model: {ph1.get_model()};\n"
      f"Retail price: {ph1.get_retail_price()};\n")

ph2.set_manufact("XXphone")
print(f"Manufact: {ph2.get_manufact()};\n"
      f"Model: {ph2.get_model()};\n"
      f"Retail price: {ph2.get_retail_price()};\n")

ph3.set_retail_price(90000)
print(f"Manufact: {ph3.get_manufact()};\n"
      f"Model: {ph3.get_model()};\n"
      f"Retail price: {ph3.get_retail_price()};\n")