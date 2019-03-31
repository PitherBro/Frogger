using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
        Score.change();
        GameObject.Find("Frog").transform.localPosition = Vector2.zero;
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}   

}
