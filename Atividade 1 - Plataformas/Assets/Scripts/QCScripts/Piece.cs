using UnityEngine;

public class Piece : MonoBehaviour
{
    public static Piece selectedPiece; // Cada peça armazena se ela foi a peça selecionada.
    public CommandManager commandManager; // Tem acesso ao CommandManager para executar comandos.
    
    void OnMouseDown()
    {
        if (selectedPiece == null)
        {
            selectedPiece = this;
        }
        else
        {
            if (selectedPiece != this)
            {
                InterfaceICommand cmd = new SwapCommand(selectedPiece, this);
                commandManager.DoCommand(cmd);
            }

            selectedPiece = null;
        }
    }
}
