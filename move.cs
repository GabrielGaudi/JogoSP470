using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    Vector3 rotacao;
    float speed = 1f;
    bool colis180, colis90 = false;

    void OnTriggerEnter(Collider parede)
    {
        speed = speed * -1;
       // rotacao.y += 180;
        Debug.Log("bateu");
    }

    // Start is called before the first frame update
    void Start()
    {
        rotacao = new Vector3(0f, 0f, 0f);


    }

    // Update is called once per frame
    void Update()
    {
       


        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(rotacao);

        /*  if(transform.position.z > 16 || transform.position.z < 8.5)
          {
              speed = speed * -1;
              rotacao.y += 180;
          }



      }
    /*  private void OnTriggerEnter(Collider other)
      {
          speed = speed * -1;
          rotacao.y += 180;
      }*/
    }

    private void LateUpdate()
    {
        if (speed < 0f)
        {
            rotacao.y = 180f;
        }
    }
}
