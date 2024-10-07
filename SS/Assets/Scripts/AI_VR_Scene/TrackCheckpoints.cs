using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{

    public class VasselCheckpointEventArgs : EventArgs{
        public Transform vasselTransform { get; set; }
    }
    public event EventHandler<VasselCheckpointEventArgs> OnVasselCorrectCheckpoint;
    public event EventHandler<VasselCheckpointEventArgs> OnVasselWrongCheckpoint;
    //public event EventHandler OnVasselCorrectCheckpoint;
    //public event EventHandler OnVasselWrongCheckpoint;

    [SerializeField] private List<Transform> vasselTransformList;
    public List<CheckpointSingle> checkpointSingleList;
    private List<int> nextCheckpointSingleIndexList;

    private void Awake(){
        Transform checkpointsTransform = transform.Find("Checkpoints");

        checkpointSingleList = new List<CheckpointSingle>();
        foreach (Transform checkpointSingleTransform in checkpointsTransform){
            //Debug.Log(checkpointSingleTransform);
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();

            checkpointSingle.SetTrackCheckpoints(this);

            checkpointSingleList.Add(checkpointSingle);
        }

        nextCheckpointSingleIndexList = new List<int>();
        foreach (Transform vasselTransform in vasselTransformList){
            nextCheckpointSingleIndexList.Add(0);
        }
        //nextCheckpointSingleIndexList = 0;
    }

    public void VasselThroughCheckpoint(CheckpointSingle checkpointSingle, Transform vasselTransform){
        int nextCheckpointSingleIndex = nextCheckpointSingleIndexList[vasselTransformList.IndexOf(vasselTransform)];
        if(checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex){
            Debug.Log("Correct checkpoint");
            Debug.Log("actual :" + nextCheckpointSingleIndex);
            CheckpointSingle correctCheckpointSingle = checkpointSingleList[nextCheckpointSingleIndex];
            //nextCheckpointSingleIndex ++;
            nextCheckpointSingleIndexList[vasselTransformList.IndexOf(vasselTransform)] =  (nextCheckpointSingleIndex + 1) % checkpointSingleList.Count;
            //OnVasselCorrectCheckpoint?.Invoke(this, EventArgs.Empty);
            OnVasselCorrectCheckpoint?.Invoke(this, new VasselCheckpointEventArgs { vasselTransform = vasselTransform });

        } else {
            Debug.Log("Wrong checkpoint");
            OnVasselWrongCheckpoint?.Invoke(this, new VasselCheckpointEventArgs { vasselTransform = vasselTransform });
            CheckpointSingle correctCheckpointSingle = checkpointSingleList[nextCheckpointSingleIndex];
        }
    }

    public CheckpointSingle GetNextCheckpoint(Transform vasselTransform){
        int nextCheckpointSingleIndex = nextCheckpointSingleIndexList[vasselTransformList.IndexOf(vasselTransform)];
        Debug.Log("next: " + nextCheckpointSingleIndex);
        return checkpointSingleList[nextCheckpointSingleIndex];
    }
}
