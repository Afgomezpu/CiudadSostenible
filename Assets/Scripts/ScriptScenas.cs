using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void JuegoInicialEscena() {
        SceneManager.LoadScene("JuegoInicial");
    }
    public void InicioEscena() {
        SceneManager.LoadScene("Inicio");
    }
    public void FinalJuegoEscena() {
        SceneManager.LoadScene("FinalJuego");
    }
    public void SeleccionJugadoresEscena() {
        SceneManager.LoadScene("SeleccionJugadores");
    }
    public void VideoTutorialEscena() {
        SceneManager.LoadScene("VideoTutorial");
    }
     public void NumeroJugadoreslEscena() {
        SceneManager.LoadScene("NumeroJugadores");
    }
    public void ExitGame() {
        Application.Quit();
    }
}