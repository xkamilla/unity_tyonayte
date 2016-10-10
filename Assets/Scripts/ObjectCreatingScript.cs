using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectCreatingScript : MonoBehaviour {

    public GameObject goalPrefab;
    public GameObject playerPrefab;

    Vector3 position;
    Vector3 scale;

    List<Vector3> positionList = new List<Vector3>();

    Vector3 normalScale = new Vector3(1.130318f, 0.2375012f, 6.137504f);
    Vector3 firstScale = new Vector3(10, 0.2375012f, 6.137504f);

    int listNumber = 0;
    float zPosition = -1.794429f;

    void Start()
    {
        positionList.Add(new Vector3(-0.6484542f, -3.846225f, zPosition));
        positionList.Add(new Vector3(-2.562506f, -2.7f, zPosition));
        positionList.Add(new Vector3(-0.49f, -1.986225f, zPosition));
        positionList.Add(new Vector3(1.107494f, -1.04f, zPosition));
        positionList.Add(new Vector3(-1.332506f, -0.2362251f, zPosition));
        positionList.Add(new Vector3(0.1174943f, 1.383775f, zPosition));
        positionList.Add(new Vector3(-1.64f, 4.71f, zPosition));
        positionList.Add(new Vector3(0.11f, 4.98f, zPosition));
        positionList.Add(new Vector3(2, 5.12f, zPosition));
        positionList.Add(new Vector3(-2.54f, 8.36f, zPosition));
        positionList.Add(new Vector3(-1.38f, 9.81f, zPosition));

        foreach (Vector3 pos in positionList)
        {
            if(listNumber != 0)
            {
                scale = normalScale;
            }
            else
            {
                scale = firstScale;
            }

            PlatformClass PlatformObject = new PlatformClass(listNumber, pos, scale);
            listNumber++;
        }
        Instantiate(playerPrefab, new Vector3(0.49f, -3.5f, -4.28f), Quaternion.identity);
        Instantiate(goalPrefab, new Vector3(-1.42f, 9.6f, 2.0f), Quaternion.identity);
    }
}

class PlatformClass
{
        string name = "Platform ";
        Vector3 position;
        Vector3 scale;

        GameObject platform;
        MovingPlatformScript mps;

    public PlatformClass(int listNumber, Vector3 pos, Vector3 platformScale)
    {
        name += listNumber;
        position = pos;
        scale = platformScale;

        CreateCube(name, position, scale);

        switch (listNumber)
        {
            case 6:
                mps = platform.AddComponent<MovingPlatformScript>();
                mps.vertical = true;
                mps.goingUpOrRight = false;
                break;
            case 8:
                mps = platform.AddComponent<MovingPlatformScript>();
                mps.goingUpOrRight = true;
                mps.vertical = true;
                break;
            case 9:
                mps = platform.AddComponent<MovingPlatformScript>();
                mps.goingUpOrRight = true;
                mps.vertical = false;
                break;
            default:
                break;
        }

    }

    void CreateCube(string n, Vector3 p, Vector3 s)
    {
        platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
        platform.name = n;
        platform.transform.position = p;
        platform.transform.localScale = s;
    }
}