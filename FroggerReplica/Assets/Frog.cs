using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public AudioSource HopSound;
    public AudioSource DeathSound;
    bool freezeControls = false;
    public int lives = 3;
    public Transform[] lifeIcons;
    //public static GameObject icons;
    private void Start()
    {
        
    }
    void Update () {
        if (!HopSound.isPlaying && !freezeControls)
        {
        
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.MovePosition(rb.position + Vector2.right); HopSound.Play();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.MovePosition(rb.position + Vector2.left); HopSound.Play();
            }
            
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                    rb.MovePosition(rb.position + Vector2.up); HopSound.Play();
            }
            
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.MovePosition(rb.position + Vector2.down); HopSound.Play();
            }
                
        }

    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("WE LOST!");
            freezeControls = true;

            if(!DeathSound.isPlaying)
                StartCoroutine(Restart());
            //while (DeathSound.isPlaying) { }
            
            			
		}
        
	}

    private IEnumerator Restart()
    {
        DeathSound.Play();
        yield return new WaitWhile(() => DeathSound.isPlaying);
        subtractLife();
        if (lives == 0)
	        SceneManager.LoadScene("End");
        gameObject.transform.localPosition = Vector2.zero;
        freezeControls = false;
    }
    private void subtractLife()
    {

       GameObject life = GameObject.Find("Lives");
        Debug.Log(life.name);

        for (int x= life.transform.childCount-1; x >-1; x--)
        {
            GameObject lifeIcon = life.transform.GetChild(x).gameObject;
            //Debug.Log(life.transform.GetChild(x).gameObject.name);
            if (lifeIcon.activeInHierarchy)
            {
                lifeIcon.SetActive(false);
                break;
            }
        }
        
        lives--;
    }
}
