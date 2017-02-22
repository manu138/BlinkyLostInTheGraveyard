using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenMovement : MonoBehaviour {
   public Transform pfinal;
    public Ease easeType;
    public float duration;
	// Use this for initialization
	void Start () {
        transform.DOMove(pfinal.position,duration).SetEase(easeType).SetLoops(-1, LoopType.Yoyo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
