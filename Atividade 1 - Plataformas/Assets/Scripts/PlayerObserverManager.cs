using System;
using UnityEngine;

// Youtube
public static class PlayerObserverManager
{
  // criar o canal de moedas do player
  public static event Action<int> OnMoedasChanged;
  
 // posta um vídeo novo no canal (notifica os inscritos)
  public static void ChangedMoedas(int valor)
  {
    OnMoedasChanged?.Invoke(valor);
  }
}
