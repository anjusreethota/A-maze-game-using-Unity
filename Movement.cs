using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public TMP_Text ScoreText;
    public TMP_Text WinText;
    private int Count;
    public AudioSource coinsound;
    //public Button Nextlevelbutton;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Count = 0;
        WinText.text = "";
        setCount();
        //Nextlevelbutton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward*speed);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back*speed);

        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right*speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left*speed);
        }
        else if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * speed);
        }


    }
    
    public void OnTriggerEnter(Collider other)
    {
        //coin is the tag name
        if (other.CompareTag("coin"))
        {
            coinsound.Play();
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);

            Count++;
            setCount();
        }
    }
    void setCount()
    {
        ScoreText.text = "Score:"+Count.ToString();
        //STOP THE PLAYER AFTER WINNING THE GAME
        if(Count >= 33) {
            WinText.text = "YOU WIN";
        //    SceneManager.LoadScene("Scene-3");
            Time.timeScale = 0;//TO freeze the player

        }
       

    }

}
//can change the other name differently