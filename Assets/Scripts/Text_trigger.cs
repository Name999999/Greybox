
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


internal class Program
{
    public static void Main(string[] args)
    {
         OnTriggerExit() => gameObject.enabled = true;
        { 
        
        }


        Void OnTriggerEnter(collider other);
        {
            if (collider.tag == "Player")
            {
                gameObject.GetComponent<UiTrigger>().enabled = True;
            }

        }
    }
}