using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    public GameObject congratsPanel;
    public GameObject levelRestriction;
    [SerializeField]
    private CapsuleCollider flagPostCollider;
    public Vector3 prefabSpawnOffsetPosition;
    public Quaternion prefabSpawnOffsetRotation;
    private void Start()
    {
        flagPostCollider = GetComponent<CapsuleCollider>();
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "GolfBall")
        {
            Instantiate(congratsPanel, gameObject.transform.position + prefabSpawnOffsetPosition, prefabSpawnOffsetRotation);

            flagPostCollider.enabled = false;

            levelRestriction.SetActive(false);
        }
    }
    
    public void AddScore()
    {

    }
}
