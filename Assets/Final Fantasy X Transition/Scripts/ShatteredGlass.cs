using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShatteredGlass : MonoBehaviour {
    public float StartTime;
    Rigidbody _Rb;
    ConstantForce _Force;

    private void Start()
    {
        _Rb = GetComponent<Rigidbody>();
        _Force = GetComponent<ConstantForce>();
    }

    public void StartAnimate()
    {
        transform.DOLocalRotate(new Vector3(Random.Range(-5, 5), Random.Range(-2, 2)), 0.5f);
        transform.DOScale(new Vector3(transform.localScale.x * 0.98f, transform.localScale.y, transform.localScale.z * 0.98f), 0.5f);
    }

    public void StartCountForce()
    {
        float a = 0, b = 0;
        DOTween.To(() => a, x => a = x, 12, 5).OnUpdate(()=> _Force.force = new Vector3(a, _Force.force.y, _Force.force.z));
        DOTween.To(() => b, x => b = x, -7, 3).OnUpdate(() => _Force.force = new Vector3(_Force.force.x, _Force.force.y, b));
        _Force.torque = new Vector3(Random.Range(-1,1), Random.Range(-1, 1), Random.Range(-1, 1));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GlassTrigger")
        _Rb.isKinematic = false;
    }

}
