using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    

    void Start()
    {
        
        //int pos = Screen.currentResolution.width;
        //var rwp = Camera.main.ScreenToWorldPoint(new Vector3(pos, 0, 0));
        //var lwp = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)); 
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y >0)
        {
           if  (player.transform.position.y>transform.position.y) //если позиция персонажа выше камеры
            {
                this.transform.position = new Vector3(3/5, player.transform.position.y, -10);
            }
        }

    }
}