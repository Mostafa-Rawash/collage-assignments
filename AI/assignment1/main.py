import os
from array import *


matrix_first_diagonal = 0
matrix_sec_diagonal = 0


rows = cols = int(
    input("Enter the size of your matrix (note that the matrix is square matrix!!)"))


arr = [[int(input("")) for i in range(cols)]
       for j in range(rows)]
print(arr)


for x in range(len(arr)):
    for y in range(len(arr)):
        print(arr[x][y], end=" ")
        if x == y:
            matrix_first_diagonal += arr[x][y]
        if x+y == 2:
            matrix_sec_diagonal += arr[x][y]
    print()

print(f'{matrix_first_diagonal} - {matrix_sec_diagonal} =  {abs(matrix_first_diagonal - matrix_sec_diagonal)}')
