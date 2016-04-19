using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinScript : MonoBehaviour {

    private Image win;
    private GameObject sun;
    
    private Image pause;
    private Image tryagain;
    private GameObject [] cloud;
    private GameObject spaceback;

    
    void Start () {

        
        win = GameObject.Find("Win").GetComponent<Image>();
        sun = GameObject.Find("Sun");
        pause = GameObject.Find("Pause").GetComponent<Image>();
        sun = GameObject.Find("Sun");
        cloud = GameObject.FindGameObjectsWithTag("Cloud");
        spaceback = GameObject.Find("Space");
        tryagain = GameObject.Find("Try").GetComponent<Image>();

        win.enabled = false;
        tryagain.enabled = false;
        spaceback.SetActive(false);
    }



    void OnTriggerEnter2D(Collider2D col)
    {
       if (col.tag == "Character")
        {
            Time.timeScale = 0;

            win.enabled = true;
            spaceback.SetActive(true);
            tryagain.enabled = true;


            sun.GetComponent<Animator>().Play("Win");
            pause.enabled = false;

        }

    }
}
