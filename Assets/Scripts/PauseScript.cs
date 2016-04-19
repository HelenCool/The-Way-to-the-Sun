using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour {

    private bool isPause = false;
    private Image pauseIm;
    private Image restart;
    public Sprite onPause;
    public Sprite offPause;
    public Sprite onVoice;
    public Sprite offVoice;
    private Image panel;
    private Image contin;
    private Image music;
    private Image voice;

    private bool canMute = true;





    void Start () {
        pauseIm = GameObject.Find("Pause").GetComponent<Image>();
        restart = GameObject.Find("Restart").GetComponent<Image>();
        panel = GameObject.Find("Panel").GetComponent<Image>();
        contin = GameObject.Find("Continue").GetComponent<Image>();
        music = GameObject.Find("Music").GetComponent<Image>();
        voice = GameObject.Find("Voice").GetComponent<Image>();


        restart.enabled = false;
        panel.enabled = false;
        contin.enabled = false;
        music.enabled = false;
        voice.enabled = false;
    }

    public void Pause()
    {
        isPause = !isPause;

        if (isPause){
            pauseIm.sprite = onPause;
           
            Time.timeScale = 0;
            
            restart.enabled = true;
            panel.enabled = true;
            contin.enabled = true;
            music.enabled = true;
            voice.enabled = true;
        }

        else
        {

             pauseIm.sprite = onPause;
            Time.timeScale = 1;


            restart.enabled = false;
            panel.enabled = false;
            contin.enabled = false;
            music.enabled = false;
            voice.enabled = false;
        }
    }

    public void MusicUI()
    {
        canMute = !canMute;
        if (canMute)
        {
            AudioListener.pause = true;
            voice.sprite = offVoice;
        }
        else
        {
            AudioListener.pause = false;
            voice.sprite = onVoice;
        }
    }



}
