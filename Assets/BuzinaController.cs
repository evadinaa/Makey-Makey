using UnityEngine;

public class BuzinaController : MonoBehaviour
{
    public AudioSource buzinaSom;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Quando aperta "SPACE" no Makey Makey
        {
            buzinaSom.Play(); // Toca a buzina
        }
    }
}
