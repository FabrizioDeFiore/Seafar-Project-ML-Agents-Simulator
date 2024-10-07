using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class VasselMoveToPort : Agent
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private float moveSpeed = 8f;
    //[SerializeField] private float timePenalty = 0.01f; 
    [SerializeField] private float distanceMultiplier = 5f; 
    [SerializeField] private float stayStillPenalty = -0.1f; 
    [SerializeField] private AudioClip goalSound; 

    private float previousDistance;
    private float episodeStartTime;

    public override void OnEpisodeBegin(){
        //transform.localPosition = Vector3.zero;

        // Randomize agent and goal spawn position to improve training performance
        transform.localPosition = new Vector3(Random.Range(-290f, +30f), 0, Random.Range(-400f, 0f));
        targetTransform.localPosition = new Vector3(Random.Range(-290f, +30f), 0, Random.Range(-1200f, -500f));

        episodeStartTime = Time.time;
        previousDistance = 900000.0f;  // Mathf.Infinity;
    }

    public override void CollectObservations(VectorSensor sensor){
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransform.localPosition);
        //sensor.AddObservation(previousDistance);
    }

    public override void OnActionReceived(ActionBuffers actions){
        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];

        // Calculate movement magnitude
        float movementMagnitude = Mathf.Sqrt(moveX * moveX + moveZ * moveZ); // Calculates the overall magnitude (strength) of the agent's movement based on the received actions 
        // Normalize actions to prevent erratic movements
        Vector3 normalizedAction = movementMagnitude > 0.1f ? new Vector3(moveX, 0, moveZ).normalized : Vector3.zero; // If the movement magnitude is above a certain threshold, the actions (moveX and moveZ) are normalized to create a unit vector representing the direction of movement. This prevents the agent from making erratic, jerky movements caused by large or uneven action values.
        // Move the agent 
        transform.localPosition += normalizedAction * Time.deltaTime * moveSpeed;
        // Calculate current distance to the target
        float currentDistance= Vector3.Distance(transform.localPosition, targetTransform.localPosition);
        // Reward based on change in distance and time penalty
        float distanceReward = 0f;
        if (currentDistance < previousDistance){
            distanceReward = distanceMultiplier * Mathf.Exp(-currentDistance); // Exponentially positive reward for getting closer (Here, a negative distance is used because the closer the agent gets (smaller distance), the larger the reward becomes due to the negative exponent)
        } else if (movementMagnitude > 0.1f){ // Prevent penalizing small adjustments and distinguish between staying still and purposeful movement
            distanceReward = -distanceMultiplier * Mathf.Pow(currentDistance - previousDistance, 2); //  Negative reward for getting farther while moving (Here, the difference between the current and previous distances (currentDistance - previousDistance) is squared, and then multiplied by a negative distanceMultiplier. This penalizes the agent more severely if it gets farther from the goal while taking an action (i.e., has some movement magnitude))
        }else{
            distanceReward = stayStillPenalty; // Negative reward for staying still
        }
        // Update the distance
        previousDistance = currentDistance;
        // float timePenaltyReward = -Time.time * episodeStartTime * timePenalty; // Penalize for longer episodes 
        float timePenaltyReward = -Mathf.Pow(Time.time - episodeStartTime, 0.5f) * 0.1f; // Slower penalty increase

        AddReward(distanceReward + timePenaltyReward);
    }

    public override void Heuristic(in ActionBuffers actionsOut){
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter(Collider other){
        if (other.TryGetComponent<Goal>(out Goal goal)){
            SetReward(+500f);       
            // Play sound on goal collision
            if (goalSound != null){
                AudioSource audioSource = GetComponent<AudioSource>();
                if (audioSource != null){
                    //audioSource.PlayOneShot(goalSound);
                    audioSource.Play();
                }
            }
            EndEpisode();
        }
        else if (other.TryGetComponent<Wall>(out Wall wall)){
            SetReward(-200f);
            EndEpisode();
        }
    }
}
