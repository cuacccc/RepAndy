using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Boton Carga escena del juego
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }
    // Boton Carga menu configuracion
    public void CargarConfiguracion(string Configuracion)
    {
        SceneManager.LoadScene(Configuracion);
    }
    // Boton Vuelve al menu de inicio
    public void VolverAlManinMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Boton Sale del juego
    public void Salir()
    {
        Application.Quit();
    }
}
