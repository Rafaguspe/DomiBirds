using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Niveles : MonoBehaviour
{
public Button btnatras,btn1,btn2;

    // Start is called before the first frame update
    void Start()
    {
        
         btnatras.onClick.AddListener(()=>Escena(1));
          btn1.onClick.AddListener(()=>Escena(2));
           btn2.onClick.AddListener(()=>Escena(3));


    }


    void Escena( int n)
    {
        switch (n)
        {
            
            case 1:
              SceneManager.LoadScene("SampleScene");
              
              break;

            case 2:
              SceneManager.LoadScene("Main");
              break;  

            case 3:
              SceneManager.LoadScene("Nivel 2");
              break;

        }

      


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
