using System.Collections.Generic;
using UnityEngine;

public class CManager : MonoBehaviour
{
    private Stack<InterfaceICommand> history = new Stack<InterfaceICommand>(); // history: armazena os comandos executados, para permitir desfazer (Undo).
    private List<InterfaceICommand> replayLog = new List<InterfaceICommand>(); // replayLog: salva todos os comandos feitos para reproduzir depois (Replay).
    
    public void DoCommand(InterfaceICommand command)
    {
        command.Do(); // Executa o comando.
        history.Push(command); // Salva o comando no histórico (para desfazer).
        replayLog.Add(command); // Também adiciona no replay (para repetir no fim).
    }
    
    public void Undo() // Desfaz o último comando, se houver algum no histórico.
    {
        if (history.Count > 0)
        {
            InterfaceICommand last = history.Pop();
            last.Undo();
        }
    }
    
    public IEnumerable<WaitForSeconds> Replay() // Reexecuta todos os comandos feitos durante o jogo, com um atraso de 1 segundo entre eles.
    {
        foreach (InterfaceICommand cmd in replayLog)
        {
            cmd.Do();
            yield return new WaitForSeconds(1f);
        }

        // exibir UI de vitória novamente
    }
    
    public void SkipReplay()
    {
        foreach (InterfaceICommand cmd in replayLog)
            cmd.Do();

        // exibir UI de vitória novamente
    }

}
