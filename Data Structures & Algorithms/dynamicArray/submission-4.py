class DynamicArray:
    
    def __init__(self, capacity: int):
        self.arr = [None] * capacity
        self.size = capacity
        self.curr = 0


    def get(self, i: int) -> int:
        i = i % self.size
        return self.arr[i % self.size]

    def set(self, i: int, n: int) -> None:
        self.arr[i % self.size] = n

    def pushback(self, n: int) -> None:
        if self.curr == self.size:
            self.resize()
        self.arr[self.curr] = n
        self.curr += 1
        

    def popback(self) -> int:
        while True:
            x = self.arr.pop()
            if x is not None:
                return x

    def resize(self) -> None:
        self.arr.extend([None] * self.size)
        self.size = len(self.arr)

    def getSize(self) -> int:
        return sum([1 for x in self.arr if x is not None])
    
    def getCapacity(self) -> int:
        return self.size

