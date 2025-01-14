using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefub;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefub);
            igaguri.GetComponent<IgaguriController>().Shoot(new Vector3(0, 200, 200));
        }
    }
}
