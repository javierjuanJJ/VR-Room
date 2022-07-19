using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class print : MonoBehaviour
{

    public GameObject objectToPrint;
    public GameObject objectWherePutDuplicateObject;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    public void DuplicateObject()
    {
        //GameObject.Instantiate(objectToPrint, objectWherePutDuplicateObject);
        Transform spawnLocation = objectWherePutDuplicateObject.transform;
        GameObject gameObject = Instantiate(objectToPrint, spawnLocation.position, spawnLocation.rotation, spawnLocation);
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / 10, gameObject.transform.localScale.y / 10, gameObject.transform.localScale.z / 10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
