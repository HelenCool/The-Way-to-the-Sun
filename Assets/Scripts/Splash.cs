using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

   

    void Start () {
        Time.timeScale = 1.0f;
        Invoke("LoadGame", 0.1f);
    }

   /*void OnWillRenderObject()
    {
        Invoke("LoadGame", 1);
        //Debug.Log("2e113");
    }*/

    
   /* void Awake()
    {
        Invoke("LoadGame", 0.2f);
        
            //LoadScene(1); //переход на другую сцену;
      
    }*/

   /* void LateUpdate()
    {
        //SceneManager.LoadScene(1);
    }*/
	

    void LoadGame ()
    {
        SceneManager.LoadScene(1);
        //Debug.Log("2e113");
    }
}
