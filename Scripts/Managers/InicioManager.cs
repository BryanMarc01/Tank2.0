using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InicioManager : MonoBehaviour {
void Update () {
//Si pulsa la tecla P o hace clic izquierdo empieza el juego
if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0)){
//Cargo la escena de Juego
// Nombre de la scene del juego, en mi caso es SampleScene
SceneManager.LoadScene("Principal");
}
/* Añade en el método Update */

//Si pulsa la tecla I vuelve al inicio
else if (Input.GetKeyDown(KeyCode.I)){
  //Cargo la escena de Inicio
  SceneManager.LoadScene("Inicio");
}
}
}
