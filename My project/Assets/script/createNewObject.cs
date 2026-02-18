using UnityEngine;

public class CreateNewObject : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            GameObject created = Instantiate(myPrefab); // instanciar myPrefab
            created.transform.position = new Vector3(3, 3, 3); // es del prefab que acabamos de crear
        }
    }
}
