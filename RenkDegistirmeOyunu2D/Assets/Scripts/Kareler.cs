using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.Lumin;

public class Kareler : MonoBehaviour
{
    public AudioSource ses;
    private MeshRenderer ressam;
    public Material sari, kirmizi, yesil, mavi, turuncu;

    void Start()
    {
        ressam = GetComponent<MeshRenderer>();
        renkVer();

    }



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            renkVer();
            ses.Play();
        }
    }

    void renkVer()
    {
        int rastgele = Random.Range(1, 6);

        switch (rastgele)
        {
            case 1:
                ressam.material = sari;
                break;
            case 2:
                ressam.material = kirmizi;
                break;
            case 3:
                ressam.material = yesil;
                break;
            case 4:
                ressam.material = mavi;
                break;
            case 5:
                ressam.material = turuncu;
                break;
        }

               
        }
    }

