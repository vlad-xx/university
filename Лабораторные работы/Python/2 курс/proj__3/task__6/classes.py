class Phone:

    def __init__(self, manufact: str, model: int, retail_price: int) -> None:
        self._manufact = manufact
        self._model = model
        self._retail_price = retail_price

    def set_manufact(self, manufact: str) -> None:
        self._manufact = manufact

    def set_model(self, model: int) -> None:
        self._model = model

    def set_retail_price(self, retail_price: int) -> None:
        self._retail_price = retail_price

    def get_manufact(self):
        return self._manufact

    def get_model(self):
        return self._model

    def get_retail_price(self):
        return self._retail_price

