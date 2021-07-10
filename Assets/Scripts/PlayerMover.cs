using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float velocity = 1.0f; //W CamelCase pierwsze slowa nazw zmiennych zaczynaja sie mala, a kazde nastepne -- wielka litera
    void Start()
    {
        PrintTutorial();

    }

    void Update() // Update wykonuje swoj kod raz na kazda klatke (przy FPS = 30 -- 30 razy na sekunde)
    {
       MovePlayer(); 
    }

    void PrintTutorial() { // W camelCase wszystkie slowa w nazwach metod (funkcji) zaczynaja sie Wielka Litera
        Debug.Log("Welcome to the game!\nUse the WASD keys to move around! (Don't worry about inverted controls, we'll fix that later.)");
        Debug.Log("Make sure not to hit the walls!");
    }
    void MovePlayer() {
        float distX = Time.deltaTime * Input.GetAxis("Horizontal") * velocity;
        float distZ = Time.deltaTime * Input.GetAxis("Vertical") * velocity;
        // Input.GetAxis() pozwala na odczytanie, ze gracz wcisnal przycisk odpowiadajacy za dana os ruchu
        // Time.deltaTime to ilosc czasu, jaka mija miedzy klatkami (przy FPS = 10 -- 0,1 sekundy)

        transform.Translate(distX, 0, distZ);
        // transform.Translate() pozwala zmienic pozycje obiektu
    }
}
