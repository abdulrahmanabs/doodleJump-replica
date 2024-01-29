using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoseBorder : MonoBehaviour
{
    [SerializeField] private Transform targetPos;
    [SerializeField] private Vector3 offset;
    
    private void Update() {
        transform.position=targetPos.position+offset;
    }
    
}
