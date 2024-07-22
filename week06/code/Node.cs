public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value != Data)
        {
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);

            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        if (Data == value)
        {
            return true;
        }
        else if (value < Data && Left != null)
        {
            return Left.Contains(value);
        }
        else if (value > Data && Right != null)
        {
            return Right.Contains(value);
        }
        else
        {
            return false;
        }
    }

    public int GetHeight()
    {

        if (Left is null && Right is null)
        {
            return 1;
        }
        else
        {
            int leftCount;
            int rightCount;

            if (Left is null)
            {
                leftCount = 0;
            }
            else
            {
                leftCount = Left.GetHeight();
            }
            if (Right is null)
            {
                rightCount = 0;
            }
            else
            {
                rightCount = Right.GetHeight();
            }

            if (leftCount > rightCount)
            {
                return leftCount + 1;
            }
            else
            {
                return rightCount + 1;
            }
        }
    }
}