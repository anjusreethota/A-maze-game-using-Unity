using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;
    public float speed;//float
    public TMP_Text youlose;
    public AudioSource enemysound;
    void Start()
    {
        //youlose.gameObject.SetActive(false);
        //youlose.text=string.Empty;
        youlose.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        offset = player.transform.position - transform.position;
        offset = offset.normalized;
        transform.Translate(offset.x * Time.deltaTime*speed, offset.y * Time.deltaTime * speed, offset.z * Time.deltaTime * speed);
    }
    public void OnTriggerEnter(Collider Other)
    {
        if(Other.CompareTag("Enemy"))        
        {
            enemysound.Play();
            Other.gameObject.SetActive(false);
            Time.timeScale = 0;
            youlose.text = "You lost";
        }

    }
}
