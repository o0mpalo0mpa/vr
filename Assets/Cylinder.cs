using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public int a;
    public int b;
    public int c;

    public GameObject roll;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            a = Random.Range(0, 255);
            b = Random.Range(0, 255);
            c = Random.Range(0, 255);

            this.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 1);
        }
    }

    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void OnMouseEnter()
    {
        roll.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        roll.gameObject.GetComponent<Renderer>().material.color = Color.black;

    }
}

