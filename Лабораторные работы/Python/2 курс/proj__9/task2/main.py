from ClassProgram import Program


def main():
    program = Program(
        width=160,
        height=160,
        xWinPos=500,
        yWinPos=200,
        title="Простой калькулятор"
    )

    program.run()


if __name__ == '__main__':
    main()

