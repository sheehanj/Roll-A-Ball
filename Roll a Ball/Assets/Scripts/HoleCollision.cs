using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleCollision : MonoBehaviour
{
    private static int count;

    public Text countText;
    public Text winText;
    public Text loseText;

    // Use this for initialization
    void Start ()
    {
        count = 0;
        UpdateCountText();
        winText.text = "";
        loseText.text = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            loseText.text = "Scratch! You Lose!";
        }

        else if(other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.SetActive(false);
            count++;
            UpdateCountText();
        }
    }

    void UpdateCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 6)
        {
            winText.text = "You Win!";
        }
    }
}
