using UnityEngine;

public class MoveRight : ICommand
{
    private Transform mvPlayerTransform;

    public MoveRight(Transform playerTransform)
    {
        mvPlayerTransform = playerTransform;
    }
    public void Do()
    {
        mvPlayerTransform.position += Vector3.right;
    }
}

public class MoveUp : ICommand
{
    private Transform mvPlayerTransform;

    public MoveUp(Transform playerTransform)
    {
        mvPlayerTransform = playerTransform;
    }

    public void Do()
    {
        mvPlayerTransform.position += Vector3.up;
    }
}

public class GetCoin : ICommand
{
    private GameObject coinObject;
   
}