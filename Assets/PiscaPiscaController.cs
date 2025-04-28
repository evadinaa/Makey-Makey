using UnityEngine;

public class PiscaPiscaController : MonoBehaviour
{
    public Light luzDireita;
    public Light luzEsquerda;
    private bool piscandoDireita = false;
    private bool piscandoEsquerda = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) // Aperta seta direita
        {
            piscandoDireita = !piscandoDireita;
            piscandoEsquerda = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) // Aperta seta esquerda
        {
            piscandoEsquerda = !piscandoEsquerda;
            piscandoDireita = false;
        }

        if (piscandoDireita)
        {
            LuzPiscar(luzDireita);
        }
        else
        {
            luzDireita.enabled = false;
        }

        if (piscandoEsquerda)
        {
            LuzPiscar(luzEsquerda);
        }
        else
        {
            luzEsquerda.enabled = false;
        }
    }

    void LuzPiscar(Light luz)
    {
        if (Time.time % 1 < 0.5f)
        {
            luz.enabled = true;
        }
        else
        {
            luz.enabled = false;
        }
    }
}
