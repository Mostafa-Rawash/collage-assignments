# /   ,   0   ,   0   ,   -
# 0   ,   /   ,   -   ,   0
# 0   ,   -   ,   /   ,   0
# -   ,   0   ,   0   ,   /

# /'s is for primary diagonal and -'s is for secondary diagonal
matrix_first_diagonal = 0
matrix_sec_diagonal = 0

#  ask user for size of matrix
rows = cols = int(
    input("Enter the size of your matrix (note that the matrix is square matrix!!)"))


# make 2 loops to take data of matrix from user 
arr = [[int(input("")) for i in range(cols)]
       for j in range(rows)]
print(arr)



#  2 for loop to show the data and get diagonals val.
for x in range(len(arr)):
    for y in range(len(arr)):
        print(arr[x][y], end=" ")
        if x == y:
            matrix_first_diagonal += arr[x][y]
        if x+y == len(arr):
            matrix_sec_diagonal += arr[x][y]
    print()


# print the val. of imary diagonal and secondary diagonal and absolute result of subtract  
print(f'{matrix_first_diagonal} - {matrix_sec_diagonal} =  {abs(matrix_first_diagonal - matrix_sec_diagonal)}')
