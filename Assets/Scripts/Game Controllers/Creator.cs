using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour {

    [SerializeField]
    private GameObject[] clouds;
    private List<GameObject> cloudList = new List<GameObject>();
    private float minX, maxX;
    private float cloudXPostion;
    private bool isCloudAtLeftSide = true;

	// Use this for initialization
	void Start () {
        SetMinAndMaxX();
        AddObjectsToTheList(clouds, cloudList);
        StartCoroutine(SpawnRandomClouds());
	}

    void SetMinAndMaxX()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
    }

    void SetCloudXposition()
    {
        if (isCloudAtLeftSide)
        {
            cloudXPostion = Random.Range(0f, maxX);
            isCloudAtLeftSide = false;
        }
        else
        {
            cloudXPostion = Random.Range(minX, 0f);
            isCloudAtLeftSide = true;
        }
    }

    void AddObjectsToTheList(GameObject[] array, List<GameObject> list)
    {
        for (int i = 0; i < array.Length; i++)
        {
            GameObject obj = Instantiate(array[i], new Vector3(0f, 0f, 0f), Quaternion.identity);
            obj.SetActive(false);
            list.Add(obj);
        }
    }

    IEnumerator SpawnRandomClouds()
    {
        yield return new WaitForSeconds(Random.Range(2f, 2.2f));
        int index = Random.Range(0, cloudList.Count);
        while (true)
        {
            if (cloudList[index].activeInHierarchy)
            {
                index = Random.Range(0, cloudList.Count);
            }
            else
            {
                cloudList[index].SetActive(true);
                SetCloudXposition();
                cloudList[index].transform.position = new Vector3(cloudXPostion, transform.position.y, 0f);
                break;
            }
            
        }
        StartCoroutine(SpawnRandomClouds());
    }
}
