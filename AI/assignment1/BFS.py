graph = {
    'A': ['B', 'C'],
    'B': ['D', 'E'],
    'C': ['F'],
    'D': [],
    'E': ['F'],
    'F': []
}
visited = []  # List to keep track of visited nodes.
queue = []  # Initialize a queue
token = ['A', 'B', 'C', 'D', 'E', 'F']


def user_frindlly():
    #  will show some chicess
    the_input = input(
        "Enter the number of you choice \n 1- adding new noode \n 2- show the graph \n 3- find the BFS for the graph \n ")
    if the_input == "1":
        creating_new_node()
    elif the_input == "2":
        print(graph)
    elif the_input == "3":
        node = str(input("Enter the node to start in it"))
        bfs(visited, graph, node)
    user_frindlly()


def adding_node(parent):
    children = []
    for i in range(int(input("the number of children"))):
        new_chiled = str(input("please Enter the chiled name"))
        if new_chiled in graph:
            print("this chiled un_avilabole")
        else:
            children.append(new_chiled)

    token.append(parent)
    graph[parent] = children


def creating_new_node():
    parent = str(input("Enter the parent name"))
    if parent in token:
        if input("watch-out this node created before so did you want to edit it?? ") == "yes":
            adding_node(parent)
        else:
            user_frindlly()
            pass
    else:
        adding_node(parent)


def bfs(visited, graph, node):
    visited = []
    visited.append(node)
    queue.append(node)

    while queue:
        s = queue.pop(0)
        print(s, end=" ")
        try:
            if s in graph:
                for neighbour in graph[s]:
                    if neighbour not in visited:
                        visited.append(neighbour)
                        queue.append(neighbour)
        except:
            print("s", s)
# Driver Code
# bfs(visited, graph, 'A')


user_frindlly()
