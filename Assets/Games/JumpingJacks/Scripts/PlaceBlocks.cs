using UnityEngine;

public class PlaceBlocks : MonoBehaviour
{
    [SerializeField] GameObject block;
    [SerializeField] GameObject block_up;
    [SerializeField] GameObject block_up2;


    /// <summary>
    /// ��������� ����� ��������� ������� � ������� �����������.
    /// ���������� ���������� �� �������� ������ �� ������ � ��������� ����� - 2 ����� �� 1 �����.
    /// </summary>
    /// <param name="startPosR">��������� ������� ���������� ��� ������ ���������.</param>
    /// <param name="startPosL">��������� ������� ���������� ��� ����� ���������.</param>
    /// <param name="max">���������� ���������� z.</param>
    /// <param name="step">��� ����� �������, �� ������� ����������� �����.</param>
    /// <param name="height">������, �� ������� ����������� �����.</param>
    /// <param name="block">������ ����� ��� ����������.</param>
    void Place(Vector3 startPosR, Vector3 startPosL, int max, float step, float height, GameObject block)
    {
        int x1 = Random.Range(-3, 4);
        Vector3 posR = new Vector3(0, height, startPosR.z) + new Vector3(x1, 0, step);
        Instantiate(block, posR, Quaternion.identity);
        Vector3 posL = new Vector3(0, height, startPosL.z) - new Vector3(x1, 0, step);
        Instantiate(block, posL, Quaternion.identity);
        x1 = Random.Range(-3, 4);
        posR = new Vector3(0, height, startPosR.z) + new Vector3(x1, 0, step);
        Instantiate(block, posR, Quaternion.identity);
        posL = new Vector3(0, height, startPosL.z) - new Vector3(x1, 0, step);
        Instantiate(block, posL, Quaternion.identity);
        if (posR.z < max)
            Place(posR, posL, max, step, height, block);
    }

    // Start is called before the first frame update
    void Start()
    {
        Place(new Vector3(0, 0, 23), new Vector3(0, 0, -23), 100, 7, 0.76f, block);
        Place(new Vector3(0, 0, 23), new Vector3(0, 0, -23), 100, 7, 0.76f, block);

        Place(new Vector3(0, 0, 100), new Vector3(0, 0, -100), 196, 6, 0.76f, block);
        Place(new Vector3(0, 0, 100), new Vector3(0, 0, -100), 196, 6, 0.76f, block);

        Place(new Vector3(0, 0, 196), new Vector3(0, 0, -196), 296, 5, 0.76f, block);
        Place(new Vector3(0, 0, 196), new Vector3(0, 0, -196), 296, 5, 0.76f, block);

        Place(new Vector3(0, 0, 296), new Vector3(0, 0, -296), 396, 5, 0.76f, block);
        Place(new Vector3(0, 0, 296), new Vector3(0, 0, -296), 396, 5, 0.76f, block);
        Place(new Vector3(0, 0, 296), new Vector3(0, 0, -296), 396, 5, 1.46f, block_up);

        Place(new Vector3(0, 0, 396), new Vector3(0, 0, -396), 496, 5, 0.76f, block);
        Place(new Vector3(0, 0, 396), new Vector3(0, 0, -396), 496, 5, 0.76f, block);
        Place(new Vector3(0, 0, 396), new Vector3(0, 0, -396), 496, 5, 2.16f, block_up2);

        Place(new Vector3(0, 0, 496), new Vector3(0, 0, -496), 596, 4, 0.76f, block);
        Place(new Vector3(0, 0, 496), new Vector3(0, 0, -496), 596, 4, 0.76f, block);

        Place(new Vector3(0, 0, 596), new Vector3(0, 0, -596), 696, 4, 0.76f, block);
        Place(new Vector3(0, 0, 596), new Vector3(0, 0, -596), 696, 4, 0.76f, block);
        Place(new Vector3(0, 0, 596), new Vector3(0, 0, -596), 696, 4, 1.46f, block_up);

        Place(new Vector3(0, 0, 696), new Vector3(0, 0, -696), 796, 4, 0.76f, block);
        Place(new Vector3(0, 0, 696), new Vector3(0, 0, -696), 796, 4, 0.76f, block);
        Place(new Vector3(0, 0, 696), new Vector3(0, 0, -696), 796, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 696), new Vector3(0, 0, -696), 796, 4, 2.16f, block_up2);

        Place(new Vector3(0, 0, 796), new Vector3(0, 0, -796), 896, 4, 0.76f, block);
        Place(new Vector3(0, 0, 796), new Vector3(0, 0, -796), 896, 4, 0.76f, block);
        Place(new Vector3(0, 0, 796), new Vector3(0, 0, -796), 896, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 796), new Vector3(0, 0, -796), 896, 4, 2.16f, block_up2);

        Place(new Vector3(0, 0, 896), new Vector3(0, 0, -896), 996, 4, 0.76f, block);
        Place(new Vector3(0, 0, 896), new Vector3(0, 0, -896), 996, 4, 0.76f, block);
        Place(new Vector3(0, 0, 896), new Vector3(0, 0, -896), 996, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 896), new Vector3(0, 0, -896), 996, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 896), new Vector3(0, 0, -896), 996, 4, 2.16f, block_up2);

        Place(new Vector3(0, 0, 996), new Vector3(0, 0, -996), 1096, 4, 0.76f, block);
        Place(new Vector3(0, 0, 996), new Vector3(0, 0, -996), 1096, 4, 0.76f, block);
        Place(new Vector3(0, 0, 996), new Vector3(0, 0, -996), 1096, 4, 0.76f, block);
        Place(new Vector3(0, 0, 996), new Vector3(0, 0, -996), 1096, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 996), new Vector3(0, 0, -996), 1096, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 996), new Vector3(0, 0, -996), 1096, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 996), new Vector3(0, 0, -996), 1096, 4, 2.16f, block_up2);

        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 0.76f, block);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 0.76f, block);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 0.76f, block);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 0.76f, block);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 1.4f, block_up);
        Place(new Vector3(0, 0, 1096), new Vector3(0, 0, -1096), 1196, 4, 2.16f, block_up2);

    }

    // Update is called once per frame
    void Update()
    {

    }
}