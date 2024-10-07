
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class VasselDriverAgent : Agent {

    [SerializeField] private TrackCheckpoints trackCheckpoints;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private float distanceMultiplier = 5f; 
    [SerializeField] private float stayStillPenalty = -0.1f; 
    private float previousDistance;
    private float episodeStartTime;
    public float movementThreshold = 0.1f;
    private VasselDriver vasselDriver;

    private void Awake() {
        vasselDriver = GetComponent<VasselDriver>();
    }

    private void Start() {
        trackCheckpoints.OnVasselCorrectCheckpoint += TrackCheckpoints_OnVasselCorrectCheckpoint;
        trackCheckpoints.OnVasselWrongCheckpoint += TrackCheckpoints_OnVasselWrongCheckpoint;
    }

    private void TrackCheckpoints_OnVasselWrongCheckpoint(object sender, TrackCheckpoints.VasselCheckpointEventArgs e) {
        //Debug.Log("Trying to get minus points");
        if (e.vasselTransform == transform) {
            //Debug.Log("Minus points!!!");
            AddReward(-1f);
        }
    }

    private void TrackCheckpoints_OnVasselCorrectCheckpoint(object sender, TrackCheckpoints.VasselCheckpointEventArgs e) {
        //Debug.Log("Trying to get plus points");
        if (e.vasselTransform == transform) {
            //Debug.Log("Plus points!!!");
            AddReward(5f);
        }
    }

    public override void OnEpisodeBegin() {
        //transform.position = spawnPosition.position + new Vector3(Random.Range(-5f, +5f), 0, Random.Range(-5f, +5f));
        transform.position = spawnPosition.position;
        transform.forward = spawnPosition.forward;
        //trackCheckpoints.ResetCheckpoint(transform);
        vasselDriver.StopCompletely();
        episodeStartTime = Time.time;
        previousDistance = 900000.0f;
    }

    public override void CollectObservations(VectorSensor sensor) {
        //Debug.Log("CollectObservations called");
        Vector3 checkpointForward = trackCheckpoints.GetNextCheckpoint(transform).transform.forward;
        float directionDot = Vector3.Dot(transform.forward, checkpointForward);
        //Debug.Log("Direction Dot Product: " + directionDot); 
        sensor.AddObservation(directionDot);
    }

    public override void OnActionReceived(ActionBuffers actions) {
        float forwardAmount = 0f;
        float turnAmount = 0f;

        switch (actions.DiscreteActions[0]) {
            case 0: forwardAmount =  0f; break;
            case 1: forwardAmount = +1f; break;
            case 2: forwardAmount = -1f; break;
        }
        switch (actions.DiscreteActions[1]) {
            case 0: turnAmount =  0f; break;
            case 1: turnAmount = +1f; break;
            case 2: turnAmount = -1f; break; 
        }
        vasselDriver.SetInputs(forwardAmount, turnAmount);
        /*
        float movementMagnitude = Mathf.Abs(forwardAmount); 
        //float movementMagnitude = Mathf.Sqrt(moveX * moveX + moveZ * moveZ);
        Vector3 normalizedAction = movementMagnitude > movementThreshold ? transform.forward : Vector3.zero;
        //Vector3 normalizedAction = movementMagnitude > 0.1f ? new Vector3(moveX, 0, moveZ).normalized : Vector3.zero;
        //transform.localPosition += normalizedAction * Time.deltaTime * vasselDriver.speed;
        float currentDistance = Vector3.Distance(transform.position, trackCheckpoints.GetNextCheckpoint(transform).transform.position );
        //Debug.Log("I think the next checkpoint is: " + trackCheckpoints.checkpointSingleList.IndexOf(trackCheckpoints.GetNextCheckpoint(transform)));
        //Debug.Log("I think it is a coordinate: " + trackCheckpoints.GetNextCheckpoint(transform).transform.position);
        //Debug.Log("current distance: " + currentDistance);
        float distanceReward = 0f;
        if (currentDistance < previousDistance){
            distanceReward = distanceMultiplier * Mathf.Exp(-currentDistance);
        } else if (movementMagnitude > 0.1f){
            distanceReward = -distanceMultiplier * Mathf.Pow(currentDistance - previousDistance, 2);
        }else{
            distanceReward = stayStillPenalty;
        }
        previousDistance = currentDistance;
        float timePenaltyReward = -Mathf.Pow(Time.time - episodeStartTime, 0.5f) * 0.1f;

        AddReward(distanceReward + timePenaltyReward);
        */
    }

    public override void Heuristic(in ActionBuffers actionsOut) {
        int forwardAction = 0;
        if (Input.GetKey(KeyCode.UpArrow)) forwardAction = 1;
        if (Input.GetKey(KeyCode.DownArrow)) forwardAction = 2;

        int turnAction = 0;
        if (Input.GetKey(KeyCode.RightArrow)) turnAction = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) turnAction = 2;

        ActionSegment<int> discreteActions = actionsOut.DiscreteActions;
        discreteActions[0] = forwardAction;
        discreteActions[1] = turnAction;
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.TryGetComponent<Wall>(out Wall wall)) {
            // Hit a Wall
            AddReward(-20f);
            EndEpisode();
        } 
        if (collision.gameObject.TryGetComponent<Goal>(out Goal goal)) {
            AddReward(100f);
            EndEpisode();
        }
    }

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.TryGetComponent<Wall>(out Wall wall)) {
            // Staying on a Wall
            AddReward(-2f);
        }
    }
}
