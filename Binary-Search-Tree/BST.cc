#include <queue>
#include <iostream>
using namespace std;
//************** class
class BST
{
private:
    struct Node
    {
        int data;
        Node *left, *right;
    };
    Node *root = nullptr;

public:
    //*************Initialize functions
    void insert(int);
    void show();
    void min();
    void dispaly();
    void max();
};

//****************FUNCTIONS

void BST::insert(int val)
{
    Node *n = new Node;
    n->data = val;
    n->left = nullptr;
    n->right = nullptr;

    if (root == nullptr)
    {
        root = n;
        return;
    }
    Node *temp = root;
    Node *parent = temp;
    while (temp != nullptr)
    {
        parent = temp;
        if (val <= temp->data)
            temp = temp->left;
        else
            temp = temp->right;
    }
    if (val <= parent->data)
        parent->left = n;
    else
        parent->right = n;
}
void BST::show()
{
    queue<Node *> q;
    q.push(root);
    while (!q.empty())
    {
        Node *current = q.front();
        q.pop();
        cout << current->data << "   ";
        if (current->left != nullptr)
            q.push(current->left);
        if (current->right != nullptr)
            q.push(current->right);
    }
    cout << endl;
}

//****************MAIN
int main()
{
    BST n1;
    n1.insert(44);
    n1.insert(4);
    n1.insert(42);
    n1.show();
}
