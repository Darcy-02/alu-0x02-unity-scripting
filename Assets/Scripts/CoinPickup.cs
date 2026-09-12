using UnityEngine;

public class CoinPickup : MonoBehaviour {

	void OnTriggerEnter (Collider other) {

		if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            //add score
            Debug.Log("the coins collected:");
        }
		
	}
}
