using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour {

    private Image menu_back;
    private Image play;
    private Image pause;
    public Image dead;
    public Image reload;

    public Text score;

    public Image splash;


    void Start () {
        menu_back = GameObject.Find("Menu_Back").GetComponent<Image>();
        play = GameObject.Find("Play").GetComponent<Image>();
        pause = GameObject.Find("Pause").GetComponent<Image>();
        dead = GameObject.Find("Dead").GetComponent<Image>();
        score = GameObject.Find("Score").GetComponent<Text>();




        menu_back.enabled = true;
        play.enabled = true;
        pause.enabled = false;
        dead.enabled = false;
        pause.enabled = false;
        

        GameObject.Find("Sun").GetComponent<SpriteRenderer>().enabled = true;

        Time.timeScale = 0;

        
    }

    void Update()
    {
        
    }

    public void Reload()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;

    }




    public void StartButton()
    {
        menu_back.enabled = false;
        play.enabled = false;
        pause.enabled = true;

        Time.timeScale = 1;

        //score.GetComponent<ScoreScript>().Init();
    }

   
}
