using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cambio : MonoBehaviour
{
public Button btnJugar;

    // Start is called before the first frame update
    void Start()
    {
        
        btnJugar.onClick.AddListener(()=>Escena());


    }


    void Escena()
    {
        SceneManager.LoadScene("SampleScene 1");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
