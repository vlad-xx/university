'''
2.1. Реализовать описанный в этом разделе (5.1.3.3)
вариант полиморфизма с использованием абстрактного метола.

2.2. Проверить (показать на примере)
исключение NotImplementedError в действии.
'''

from Vector import Vector2D, Vector3D, Vector4D


def main():
    v1_2d = Vector2D(2.5, 2)
    v1_3d = Vector3D(3, 4.3, 5)
    v1_4d = Vector4D(4, 3.2, 5, 7)

    list_vectors = [v1_2d, v1_3d, v1_4d]

    for vector in list_vectors:
        print(vector.get_params())


if __name__ == '__main__':
    main()
