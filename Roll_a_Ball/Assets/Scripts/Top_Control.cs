using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Top_Control : MonoBehaviour
{
    public Rigidbody fizik;
    public int hiz;
    public int sayac = 0;
    public int objeSayisi;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finishText;
    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        //Debug.Log("yatay = " +yatay);
        //Debug.Log("dikey = " + dikey);
        Vector3 vektor = new Vector3(yatay * hiz, 0, dikey * hiz);
        fizik.AddForce(vektor);
    }
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        sayac++;
        scoreText.text = "Score: " + sayac;
        if(sayac == objeSayisi)
        {
            finishText.gameObject.SetActive(true);
        }
    }
}
