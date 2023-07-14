using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public GameObject invManager; // ref to inventory manager
    public bool canCollect;
    public int itemIndex;
    public GameObject Text;


    // Start is called before the first frame update
    void Start()
    {
        invManager = GameObject.Find("InventoryManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && canCollect == true)
        {
            // turn on the cursor
            invManager.GetComponent<Inventory>().GetsItem(itemIndex);
            Destroy(gameObject);
            // should set up object destruction here
            Text.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canCollect = true;
            Debug.Log("Item can be collected");
            Text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canCollect= false;
            Debug.Log("Item out of range again");
            Text.SetActive(false);
        }
    }
}
