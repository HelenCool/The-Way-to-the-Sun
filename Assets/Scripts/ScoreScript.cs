using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	private Text counterText;
	public Transform player;

	private float currentHeight = 0f;
	//private float currentTime = 0f;

	private float recordHeight = 0f;
	//private float recordTime = 0f;

	private float startY = 0f;

    void Start()
    {
		Init ();
    }

	public void Init () {
		//Debug.LogError ("Init");
		counterText = GetComponent<Text>();
		InitRecords ();
		startY = player.position.y;
		UpdateText ();
	}

    void Update()
    {
		//CalcTime ();
		CalcHeight ();
		StoreHeight ();
		UpdateText ();
	}

	//public void StoreTime () {
	//	PlayerPrefs.SetFloat ("RecordTime", recordTime);
	//}

	void StoreHeight (){
		PlayerPrefs.SetFloat ("RecordHeight", Mathf.Max(currentHeight, recordHeight));
	}

	void InitRecords () {
	//	recordTime = PlayerPrefs.GetFloat ("RecordTime", 0f);
		recordHeight = PlayerPrefs.GetFloat ("RecordHeight", 0f);
	}

	//string TimeToMMSS (float _time) {
	//	var minutes = (int)(Time.timeSinceLevelLoad / 60f);
	//	var seconds = (int)(Time.timeSinceLevelLoad % 60f);
	//	return minutes.ToString("00") + ":" + seconds.ToString("00");
	//}

	string HeightToText (float height) {
		return "" + (int)(height * 1.4f) + "m";
	}

	void CalcHeight () {
		currentHeight = Mathf.Max (currentHeight, player.position.y - startY);
	}

	//void CalcTime () {
	//	currentTime += Time.deltaTime; 
	//}

	void UpdateText () {
		//counterText.text = "Time: " + TimeToMMSS (currentTime) + " Record: " + TimeToMMSS (recordTime);
		counterText.text = "Height: " + HeightToText(currentHeight) + " Record: " + HeightToText(recordHeight);
	}
}




   
