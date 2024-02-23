# define Person class, first name, last name, and age.
class Person:
    def __init__(self, first_name, last_name, age):
        self.first_name = first_name
        self.last_name = last_name
        self.age = age

    # printing out a person
    def __repr__(self):
        return f"{self.first_name} {self.last_name}, Age: {self.age}"


# queue class
class Queue:
    def __init__(self):
        self.items = [] # where we're going to store our people

    def enqueue(self, person):
        # ddd a person to the end of the queue
        self.items.append(person)

    def dequeue(self):
        if not self.is_empty():
            return self.items.pop(0)
        else:
            return None # no one's there

    def is_empty(self):
        # check to see if the queue is empty
        return len(self.items) == 0

    def sort_by_last_name(self):
        # quick sort
        self.quick_sort(0, len(self.items) - 1, key=lambda p: p.last_name, reverse=True)

    # sort by age
    def sort_by_age(self):
        self.quick_sort(0, len(self.items) - 1, key=lambda p: p.age, reverse=True)

    # quick sort algorithm
    def quick_sort(self, low, high, key, reverse=False):
        if low < high:
            pi = self.partition(low, high, key, reverse)
            self.quick_sort(low, pi-1, key, reverse)
            self.quick_sort(pi+1, high, key, reverse)

    def partition(self, low, high, key, reverse):
        i = (low - 1)
        pivot = key(self.items[high])

        for j in range(low, high):
            # if we're reversing, check one way, otherwise check the other
            if (key(self.items[j]) < pivot and reverse) or (key(self.items[j]) > pivot and not reverse):
                i = i+1
                # swap them around
                self.items[i], self.items[j] = self.items[j], self.items[i]
        # final swap
        self.items[i+1], self.items[high] = self.items[high], self.items[i+1]
        return i+1 # return the pivot index

    def __repr__(self):
        # printing the queue so we can actually see what's going on
        return str(self.items)


# function to add people to our queue
def add_people_to_queue(queue):
    for i in range(5): # adding 5 people
        first_name = input(f"Enter the first name for person {i+1}: ")
        last_name = input(f"Enter the last name for person {i+1}: ")
        age = int(input(f"Enter the age for person {i+1}: "))
        queue.enqueue(Person(first_name, last_name, age))
    return queue

# test this out with data
queue = Queue()
people_data = [
    ("Skyler", "Metzger", 23),
    ("Mike", "Tyson", 54),
    ("Hugh", "Mungus", 99),
    ("Carrie", "Scott", 22),
    ("Ouch-ma", "Toe", 30)
]

# add people to the queue
for first_name, last_name, age in people_data:
    queue.enqueue(Person(first_name, last_name, age))

# display the queue
print("Queue before sorting:")
print(queue)

# sort by last name and display
queue.sort_by_last_name()
print("\nQueue sorted by last name in descending order:")
print(queue)

# sort by age and display
queue.sort_by_age()
print("\nQueue sorted by age in descending order:")
print(queue)


