using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioBird : MonoBehaviour
{
   public GameObject[] pajaro;
   public Sprite[] Spritepajaro;
   public Animator ave;

   public Bird codigo;

   public Button btnatras;

    int cont=0;

    void Start()
    {
        btnatras.onClick.AddListener(()=> SceneManager.LoadScene("SampleScene 1"));
    }

    // Update is called once per frame
  void Update() {

	 Vector2 poss=  pajaro[0].transform.position;
		
		if(poss.x>-1 && cont==0){
			ave.SetBool("Disparo",true);
            StartCoroutine(Cambio());
            cont=1;
		}
}

IEnumerator Cambio()
{
 yield return new WaitForSeconds(3f);
 pajaro[0].SetActive(false);
 codigo.enabled=false;
pajaro[0].transform.position=new Vector2(-4.521727f,-0.4971042f);
pajaro[0].transform.rotation=new Quaternion(0,0,0,0);
pajaro[0].GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Kinematic;
 pajaro[0].GetComponent<SpriteRenderer>().sprite=Spritepajaro[1];
 pajaro[1].SetActive(false);
 pajaro[0].SetActive(true);
ave.Rebind();
// ave.Update(0f);


}


}