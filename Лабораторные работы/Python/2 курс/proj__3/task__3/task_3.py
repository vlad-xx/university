from Vector import vector0, vector1, vector2

# vector0
print("vector0")
v0 = vector0(1, 1)
print(f"attrs: x = {v0.x}; y = {v0.y}\n"
      f"attrs type: x - {type(v0.x)}; y - {type(v0.y)}\n"
      f"obj type: {type(v0)}")
v0.x = 2
print(f"attrs: x = {v0.x}; y = {v0.y}")
print()

# vector1
print("vector1")
v1 = vector1(1, 1)
print(f"attrs: x = {v1._x}; y = {v1._y}\n"
      f"attrs type: x - {type(v1._x)}; y - {type(v1._y)}\n"
      f"obj type: {type(v1)}")
v1._x = 2
print(f"attrs: x = {v1._x}; y = {v1._y}")
print()

# vector2
print("vector2")
v2 = vector2(1, 1)
print(f"obj type: {type(v2)}")
v2.__x = 2
attr = v2.show_x()
print(f"attrs: x = {v2.__x}; y = {v2.__y}")
print(f"show_x: {attr}; type - {type(attr)}")
