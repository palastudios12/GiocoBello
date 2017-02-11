using UnityEngine;
using System.Collections;

public class llllllllllllllllllllllllllllll : MonoBehaviour {
    public int amount = 2;
    public int cont = 0;
    public bool enableRotation= false;
    public bool enableScale = false;
    public bool enablePosition = false;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {//ciao
        if (cont++ == 10) { amount *= -1; cont = 0; }
        if (enableRotation)gameObject.GetComponent<Renderer>().transform.Rotate(new Vector3(0,0,1), 2);
        if (enablePosition) gameObject.GetComponent<Renderer>().transform.position=new Vector3(
            gameObject.GetComponent<Renderer>().transform.position.x+amount,
            gameObject.GetComponent<Renderer>().transform.position.y,
            gameObject.GetComponent<Renderer>().transform.position.z
        );
        if (enableScale) gameObject.GetComponent<Renderer>().transform.localScale = new Vector3(cont,cont,1);
    }
}
