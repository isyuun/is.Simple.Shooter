using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipItemDrop : _MonoBehaviour {
    public GameObject[] _itemPrefab;

    public void Drop()
    {
        int itemNum = UnityEngine.Random.Range(0, _itemPrefab.Length);

        Instantiate(_itemPrefab[itemNum], transform.position, Quaternion.identity);
    }

    private void OnDestroy()
    {
        Drop();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
