using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RTSManager : MonoBehaviour
{
    static RTSManager _instance;
    public static RTSManager Instance{
        get{
            if (_instance == null){
                _instance = FindObjectOfType(typeof(RTSManager)) as RTSManager;
                if (_instance == null){
                    GameObject go = new GameObject("RTSManager");
                    _instance = go.AddComponent<RTSManager>();
                }
            }
            return _instance;
        }
    }

    public void RTSControl(List<GameObject> moveObjects,GameObject moveToPositionObj,float[] ringDistance,int[] ringPositionCount,float moveTime)
    {
        Vector3 moveToPosition=moveToPositionObj.transform.position;
        // Right Mouse Button Pressed
        //Vector3 moveToPosition = UtilsClass.GetMouseWorldPosition();

        //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(moveToPosition);
        Vector3 worldPosition = moveToPosition;
        worldPosition.z=0;

        //List<Vector3> targetPositionList = GetPositionListAround(worldPosition, new float[] { 10f, 20f, 30f }, new int[] { 5, 10, 20 });
        List<Vector3> targetPositionList = GetPositionListAround(worldPosition,ringDistance,ringPositionCount);

        int targetPositionListIndex = 0;

        foreach (var unitRTS in moveObjects) {
            //unitRTS.MoveTo(targetPositionList[targetPositionListIndex]);
            unitRTS.transform.DOMove(targetPositionList[targetPositionListIndex],moveTime);
            targetPositionListIndex = (targetPositionListIndex + 1) % targetPositionList.Count;
        }
    }



    private List<Vector3> GetPositionListAround(Vector3 startPosition, float[] ringDistanceArray, int[] ringPositionCountArray) {
        List<Vector3> positionList = new List<Vector3>();
        positionList.Add(startPosition);
        for (int i = 0; i < ringDistanceArray.Length; i++) {
            positionList.AddRange(GetPositionListAround(startPosition, ringDistanceArray[i], ringPositionCountArray[i]));
            
        }
        return positionList;
    }

    private List<Vector3> GetPositionListAround(Vector3 startPosition, float distance, int positionCount) {
        List<Vector3> positionList = new List<Vector3>();
        for (int i = 0; i < positionCount; i++) {
            float angle = i * (360f / positionCount);
            Vector3 dir = ApplyRotationToVector(new Vector3(1, 0), angle);
            Vector3 position = startPosition + dir * distance;
            positionList.Add(position);
        }
        return positionList;
    }

    private Vector3 ApplyRotationToVector(Vector3 vec, float angle) {
        return Quaternion.Euler(0, 0, angle) * vec;
    }
}
