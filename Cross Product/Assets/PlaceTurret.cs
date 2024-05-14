using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTurret : MonoBehaviour
{
    public Transform turret;

    private void OnDrawGizmos()
    {

        if(turret == null)
        {
            return;

        }
        Ray ray = new Ray(transform.position, transform.forward);


        RaycastHit hit;


        if(Physics.Raycast(ray, out hit))
        {

            turret.position = hit.point;

            Vector3 yAxis = hit.normal;
            Vector3 zAxis = Vector3.Cross(transform.right, yAxis);



            Gizmos.color = Color.green;
            Gizmos.DrawRay(hit.point, yAxis * 2);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(hit.point, zAxis); 
            Gizmos.color = Color.white;
            Gizmos.DrawLine(ray.origin, hit.point);

            turret.rotation = Quaternion.LookRotation(zAxis, yAxis);








        }


    }

}
