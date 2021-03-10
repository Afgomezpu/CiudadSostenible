using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeleccionJugadores : MonoBehaviour
{
    ControladorJugadores NumeroJugadores;
    private int jugadores;
    public GameObject jugador;
    public GameObject siguiente;
    public GameObject aceptar;
    public GameObject TextAceptar;
    public GameObject TextSiguiente;
    public GameObject Seleccionar;
    public GameObject Asignarnombre;
    private string nombreJugador;
    private List<string> listaJugadores;
    private List<int> listaNumeroJugadores;
    private List<string> listaColor; 
    private string colorDePiel;
    private int numeroPelo;
    private List<int> listaPelo; 
    private int numeroJugador;
    private int contador;
  
    void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        listaJugadores=new List<string>();
        listaNumeroJugadores=new List<int>();
        listaColor=new List<string>();
        listaPelo=new List<int>();
        NumeroJugadores=FindObjectOfType<ControladorJugadores>();
        //print(NumeroJugadores.Jugadores);
         jugadores=NumeroJugadores.Jugadores;
         siguiente.SetActive(false);
         aceptar.SetActive(false);
         TextSiguiente.SetActive(false);
         TextAceptar.SetActive(false);   
         contador=0;
         Seleccionar.SetActive(true);
         Asignarnombre.SetActive(false);
    }

      public void textJugador(int player){
        jugador.GetComponent<TextMeshProUGUI>().text = "player "+player ;
      }


    void Update()
    {

    }

    public void ingresarJugadores(string nombre){
        listaJugadores.Add(nombre);
    }

     public void ingresarNumeroJugadores(int numero){
        listaNumeroJugadores.Add(numero);
    }

     public void ingresarColor(string nombre){
        listaColor.Add(nombre);
    }

     public void ingresarNumeroPelo(int numero){
        listaPelo.Add(numero);
    }

     public List<string> ListaJugadores   // property
  {
    get { return listaJugadores; }
    set { listaJugadores = value; }
  }

      public List<string> ListaColor   // property
  {
    get { return listaColor; }
    set { listaColor = value; }
  }

      public List<int> ListaPelo   // property
  {
    get { return listaPelo; }
    set { listaPelo = value; }
  }
     public List<int> ListaNumeroJugadores   // property
  {
    get { return listaNumeroJugadores; }
    set { listaNumeroJugadores = value; }
  }

       public int  Jugadores  // property
  {
    get { return jugadores; }
    set { jugadores = value; }
  }

      public string  NombreJugador  // property
  {
    get { return nombreJugador; }
    set { nombreJugador = value; }
  }

        public int  NumeroJugador  // property
  {
    get { return numeroJugador; }
    set { numeroJugador = value; }
  }
      public int Contador  // property
     {
    get { return contador; }
    set { contador = value; }
    }


          public string  ColorDePiel  // property
  {
    get { return colorDePiel; }
    set { colorDePiel = value; }
  }

        public int  NumeroPelo  // property
  {
    get { return numeroPelo; }
    set { numeroPelo = value; }
  }
}
