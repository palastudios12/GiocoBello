using UnityEngine;
using System.Collections;

public class Attacco : MonoBehaviour {

    public float CaricamentoAttacco = 0f;
    public float CaricamentoAttaccoDebole = 5f;
    public float CaricamentoAttaccoMedio = 10f;
    public float CaricamentoAttaccoForte = 15f;



	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Space))
        {
            CaricamentoAttacco += Time.deltaTime * 5f;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Spadata();
        }
	}

    void Spadata()
    {
        if(CaricamentoAttacco >= CaricamentoAttaccoForte)
        {
            Debug.Log("Attacco FORTE!");
        }
        else if (CaricamentoAttacco >= CaricamentoAttaccoMedio)
        {
            Debug.Log("Attacco Medio!");
        }
        else
        {
            Debug.Log("Attacco debole :( ");
        }

        CaricamentoAttacco = 0f;

    }
}
