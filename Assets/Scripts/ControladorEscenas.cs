using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

       public void SeleccionValoresDefecto() {
        SceneManager.LoadScene("ModificacionValores");
    }
    public void VideoTutorialJuegoPrincipal() {
        SceneManager.LoadScene("JuegoPrincipal");
    }
    public void ExitGame() {
        Application.Quit();
    }
}
