using UnityEngine;

public class SwapCommand : InterfaceICommand
{
   private Piece pieceA, pieceB;
   
   public SwapCommand (Piece a, Piece b)
   {
      pieceA = a;
      pieceB = b;
   }
   
   public void Do()
   {
      SwapPositions(pieceA, pieceB);
   }

   public void Undo()
   {
      SwapPositions(pieceB, pieceA);
   }
   
   private void SwapPositions(Piece a, Piece b)
   {
      Vector3 tempPos = a.transform.position;
      a.transform.position = b.transform.position;
      b.transform.position = tempPos;
   }
}
