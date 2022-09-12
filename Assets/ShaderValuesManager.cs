using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderValuesManager : MonoBehaviour
{
    [Range(0, 1)] [SerializeField] private float ka = 1;
    [Range(0, 1)] [SerializeField] private float kd = 1;
    [Range(0, 1)] [SerializeField] private float ks = 1;
    [Range(0, 1)] [SerializeField] private float fAtt = 1;
    [Range(1, 100)] [SerializeField] private float specN = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Material mat = this.GetComponent<MeshRenderer>().material;
        mat.SetFloat("_Ka", ka);
        mat.SetFloat("_Kd", kd);
        mat.SetFloat("_Ks", ks);
        mat.SetFloat("_fAtt", fAtt);
        mat.SetFloat("_specN", specN);
        
    }
}
