using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;

	public Text scoreText;

	void Start ()
	{
        //scoreText = gameObject.GetComponent<Text>();
		scoreText.text = CurrentScore.ToString();
	}
    private void Update()
    {
        scoreText.text = CurrentScore.ToString();
    }
    public static void change()
    {
        //scoreText.text = CurrentScore.ToString();
    }

}
