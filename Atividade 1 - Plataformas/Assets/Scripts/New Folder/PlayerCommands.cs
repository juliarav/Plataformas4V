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
    
    public void Undo ()
    {
        mvPlayerTransform.position -= Vector3.right;
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
    
    public void Undo()
    {
        mvPlayerTransform.position -= Vector3.up;
    }
}

public class GetCoin : ICommand
{
    private GameObject coinObject;
    private SimplePlayer player;

    public GetCoin(GameObject coin, SimplePlayer player)
    {
        coinObject = coin;
        this.player = player;
    }

    public void Do()
    {
        player.moedas++;
        coinObject.SetActive(false);
    }

    public void Undo()
    {
        player.moedas--;
        coinObject.SetActive(true);
        player.UndoLastCommand();
    }

}