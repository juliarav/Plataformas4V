using UnityEngine;
using UnityEngine.UI;

public class SodaMachine : MonoBehaviour
{
    public Animator anima;

    public Button bInserir;
    public Button bCancelar;
    public Button bComprar;
    public Button bManutencao;

    public Text statusText;
    public GameObject[] sodaCans;
    public Transform outputSlot;

    private int estoque = 0;
    private bool temMoeda = false;
    private bool emManutencao = false;

    void Start()
    {
        UpdateState();
        bInserir.onClick.AddListener(InserirMoeda);
        bCancelar.onClick.AddListener(Cancelar);
        bComprar.onClick.AddListener(Comprar);
        bManutencao.onClick.AddListener(ToggleMaintenance);
    }

    void UpdateState()
    {
        Animator.SetBool("manutencao", emManutencao);
        Animator.SetBool("temMoeda", temMoeda);
        Animator.SetBool("estoque", estoque == 0);

        if (emManutencao)
        {
            statusText.text = "MANUTENÇÃO";
            MostrarEStoque();
        }
        
        else if (estoque == 0)
        {
            statusText.text = "ESTOQUE";
        }
        
        else if (temMoeda)
        {
            statusText.text = "OKAY";
        }

        else
        {
            statusText.text = "";
        }
    }

    void MostrarEStoque()
    {
        for (int i = 0; i < sodaCans.Length; i++)
        {
            sodaCans[i].SetActive(i < estoque);
        }
    }

    void InserirMoeda()
    {
        if (emManutencao) // Adiciona lata no modo manutenção
        {
            estoque++;
            MostrarEStoque();
        }
        
        else if (estoque > 0 && !temMoeda)
        {
            temMoeda = true;
        }
        
        UpdateState();
    }

    void Cancelar()
    {
        if (emManutencao) return;
        if (temMoeda)
        {
            temMoeda = false;
            UpdateState();
        }
    }

    void Comprar()
    {
        if (emManutencao) return;
        if (temMoeda && estoque > 0)
        {
            temMoeda = false;
            estoque--;
            Animator.SetTrigger("dispense");
            StartCoroutine(Dispense());
        }
        
        UpdateState();
    }

    System.Collections.IEnumerator Dispense()
    {
        DisableAllButtons();
        yield return new WaitForSeconds(1f);
        Instantiate(sodaCans[0], outputSlot.position, Quaternion.identity);
        UpdateState();
        EnableAllButtons();
    }

    void ToggleMaintenance()
    {
        if (temMoeda) return; // Não pode entrar em manutenção se tiver moeda
        emManutencao = !emManutencao;
        UpdateState();
    }

    void DisableAllButtons()
    {
        bInserir.interactable = false;
        bCancelar.interactable = false;
        bComprar.interactable = false;
        bManutencao.interactable = false;
    }

    void EnableAllButtons()
    {
        bInserir.interactable = true;
        bCancelar.interactable = true;
        bComprar.interactable = true;
        bManutencao.interactable = true;
    }
    
}
