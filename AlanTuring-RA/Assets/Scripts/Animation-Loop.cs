using UnityEngine;

public class InteracaoObjeto : MonoBehaviour
{
    private Animator anim;
    public string triggerAnimacao = "AcionarInteracao"; 
    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.LogError("Animator não encontrado no GameObject!");
        }
        AcionarAnimacaoLoop();
    }

    //TODO: precisa de um stop caso tenha uma outra interação?
    /*void Update()
    {
        // Exemplo: Se o jogador pressionar a tecla 'E' perto do objeto
        if (Input.GetKeyDown(KeyCode.E) && IsPlayerNear())
        {
            PararAnimacaoInteracao();
        }
    }

*/
    // Metodo para acionar a animação
    public void AcionarAnimacaoLoop()
    {
        if (anim != null)
        {
            anim.SetTrigger(triggerAnimacao);
        }
    }

    //  colisão 2D
  /*  private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Player entrou na área de interação!");
              nao sei se precisa disso aqui
            // AcionarAnimacaoInteracao();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player saiu da área de interação!");
        }
    } */
}